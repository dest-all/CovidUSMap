namespace CovidUsMap.Models;

public class CovidLevels
{
    public byte OverallRisk { get; set; }
    public byte CasesDensity { get; set; }
    public byte TestPositivity { get; set; }
    public byte Infection { get; set; }
}
