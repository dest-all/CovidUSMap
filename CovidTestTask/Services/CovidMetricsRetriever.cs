using CovidUsMap.Models;
using System.Text.Json;

namespace CovidUsMap.Services;

public class CovidMetricsRetriever
{
    readonly HttpClient _httpClient;
    readonly string _apiKey;
    readonly TimeSpan _cacheValidFor;

    readonly object _locker = new();

    Task<IReadOnlyList<CovidApiContract>>? _runningRequest;
    DateTime _cacheValidTill;

    const string _baseUrl = "https://api.covidactnow.org";

    public CovidMetricsRetriever(HttpClient httpClient, string apiKey, TimeSpan cacheValidFor)
    {
        _httpClient = httpClient;
        _apiKey = apiKey;
        _cacheValidFor = cacheValidFor;
    }

    public Task<IReadOnlyList<CovidApiContract>> GetAsync()
    {
        if (_runningRequest is not null && _cacheValidTill >= DateTime.UtcNow)
        {
            return _runningRequest;
        }
        lock (_locker)
        {
            _runningRequest = GetDirectlyAsync().ContinueWith(task => {
                if (task.IsFaulted)
                {
                    throw task?.Exception ?? new AggregateException();
                }
                _cacheValidTill = DateTime.UtcNow + _cacheValidFor;
                return task.Result;
            });
            return _runningRequest;
        }
    }

    async Task<IReadOnlyList<CovidApiContract>> GetDirectlyAsync()
    {
        const string apiBaseRoute = _baseUrl + "/v2/states.json?apiKey=";
        string resultApiUrl = apiBaseRoute + _apiKey;

        var response = await _httpClient.GetAsync(resultApiUrl);

        var json = await response.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<CovidApiContract[]>(json);

        return result;
    }
}
