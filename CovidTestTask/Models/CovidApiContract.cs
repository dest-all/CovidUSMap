// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
public class Actuals
{
    [System.Text.Json.Serialization.JsonPropertyName("cases")]
    public int Cases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("deaths")]
    public int Deaths { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("positiveTests")]
    public int PositiveTests { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("negativeTests")]
    public int NegativeTests { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("contactTracers")]
    public int ContactTracers { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hospitalBeds")]
    public HospitalBeds HospitalBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsaHospitalBeds")]
    public HsaHospitalBeds HsaHospitalBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("icuBeds")]
    public IcuBeds IcuBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsaIcuBeds")]
    public HsaIcuBeds HsaIcuBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("newCases")]
    public int NewCases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("newDeaths")]
    public int NewDeaths { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinesDistributed")]
    public int? VaccinesDistributed { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsInitiated")]
    public int? VaccinationsInitiated { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsCompleted")]
    public int? VaccinationsCompleted { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsAdditionalDose")]
    public int? VaccinationsAdditionalDose { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsFall2022BivalentBooster")]
    public int? VaccinationsFall2022BivalentBooster { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinesAdministered")]
    public int? VaccinesAdministered { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinesAdministeredDemographics")]
    public VaccinesAdministeredDemographics VaccinesAdministeredDemographics { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsInitiatedDemographics")]
    public VaccinationsInitiatedDemographics VaccinationsInitiatedDemographics { get; set; }
}

public class Age
{
    [System.Text.Json.Serialization.JsonPropertyName("0-19")]
    public int _019 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("20-34")]
    public int _2034 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("35-44")]
    public int _3544 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("45-54")]
    public int _4554 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("55-64")]
    public int _5564 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("65-74")]
    public int _6574 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("75-84")]
    public int _7584 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("85_plus")]
    public int _85Plus { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("unknown")]
    public int Unknown { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("12-15")]
    public int _1215 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("16-17")]
    public int _1617 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("16-19")]
    public int _1619 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("18-24")]
    public int _1824 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("20-44")]
    public int _2044 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("25-29")]
    public int _2529 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("25-34")]
    public int _2534 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("25-39")]
    public int _2539 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("30-39")]
    public int _3039 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("40-49")]
    public int _4049 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("46-64")]
    public int _4664 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("5-11")]
    public int _511 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("50-64")]
    public int _5064 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("65_plus")]
    public int _65Plus { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("75+")]
    public int _75 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("12-14")]
    public int? _1214 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("15-24")]
    public int? _1524 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("10-14")]
    public int? _1014 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("100-104")]
    public int? _100104 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("105_plus")]
    public int? _105Plus { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("15-19")]
    public int? _1519 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("20-24")]
    public int? _2024 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("30-34")]
    public int? _3034 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("35-39")]
    public int? _3539 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("40-44")]
    public int? _4044 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("45-49")]
    public int? _4549 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("5-9")]
    public int? _59 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("50-54")]
    public int? _5054 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("55-59")]
    public int? _5559 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("60-64")]
    public int? _6064 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("65-69")]
    public int? _6569 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("70-74")]
    public int? _7074 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("75-79")]
    public int? _7579 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("80-84")]
    public int? _8084 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("85-89")]
    public int? _8589 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("90-94")]
    public int? _9094 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("95-99")]
    public int? _9599 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("12-17")]
    public int? _1217 { get; set; }
}

public class Annotations
{
    [System.Text.Json.Serialization.JsonPropertyName("cases")]
    public Cases Cases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("deaths")]
    public Deaths Deaths { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("positiveTests")]
    public PositiveTests PositiveTests { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("negativeTests")]
    public NegativeTests NegativeTests { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("contactTracers")]
    public ContactTracers ContactTracers { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hospitalBeds")]
    public HospitalBeds HospitalBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsaHospitalBeds")]
    public object HsaHospitalBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("icuBeds")]
    public IcuBeds IcuBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsaIcuBeds")]
    public object HsaIcuBeds { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("newCases")]
    public NewCases NewCases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("newDeaths")]
    public NewDeaths NewDeaths { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinesDistributed")]
    public VaccinesDistributed VaccinesDistributed { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsInitiated")]
    public VaccinationsInitiated VaccinationsInitiated { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsCompleted")]
    public VaccinationsCompleted VaccinationsCompleted { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsAdditionalDose")]
    public VaccinationsAdditionalDose VaccinationsAdditionalDose { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsFall2022BivalentBooster")]
    public VaccinationsFall2022BivalentBooster VaccinationsFall2022BivalentBooster { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinesAdministered")]
    public VaccinesAdministered VaccinesAdministered { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("testPositivityRatio")]
    public TestPositivityRatio TestPositivityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("caseDensity")]
    public CaseDensity CaseDensity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("weeklyNewCasesPer100k")]
    public WeeklyNewCasesPer100k WeeklyNewCasesPer100k { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("contactTracerCapacityRatio")]
    public ContactTracerCapacityRatio ContactTracerCapacityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("infectionRate")]
    public InfectionRate InfectionRate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("infectionRateCI90")]
    public InfectionRateCI90 InfectionRateCI90 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("icuCapacityRatio")]
    public IcuCapacityRatio IcuCapacityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("bedsWithCovidPatientsRatio")]
    public BedsWithCovidPatientsRatio BedsWithCovidPatientsRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("weeklyCovidAdmissionsPer100k")]
    public object WeeklyCovidAdmissionsPer100k { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsInitiatedRatio")]
    public object VaccinationsInitiatedRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsCompletedRatio")]
    public object VaccinationsCompletedRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsAdditionalDoseRatio")]
    public object VaccinationsAdditionalDoseRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsFall2022BivalentBoosterRatio")]
    public object VaccinationsFall2022BivalentBoosterRatio { get; set; }
}

public class Anomaly
{
    [System.Text.Json.Serialization.JsonPropertyName("date")]
    public string Date { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("original_observation")]
    public double OriginalObservation { get; set; }
}

public class BedsWithCovidPatientsRatio
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class CaseDensity
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class Cases
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class CommunityLevels
{
    [System.Text.Json.Serialization.JsonPropertyName("cdcCommunityLevel")]
    public object CdcCommunityLevel { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("canCommunityLevel")]
    public int? CanCommunityLevel { get; set; }
}

public class ContactTracerCapacityRatio
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class ContactTracers
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class Deaths
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class Ethnicity
{
    [System.Text.Json.Serialization.JsonPropertyName("hispanic")]
    public int Hispanic { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("non-hispanic")]
    public int NonHispanic { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("unknown")]
    public int Unknown { get; set; }
}

public class HospitalBeds
{
    [System.Text.Json.Serialization.JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageTotal")]
    public int? CurrentUsageTotal { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageCovid")]
    public int? CurrentUsageCovid { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("weeklyCovidAdmissions")]
    public int? WeeklyCovidAdmissions { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class HsaHospitalBeds
{
    [System.Text.Json.Serialization.JsonPropertyName("capacity")]
    public object Capacity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageTotal")]
    public object CurrentUsageTotal { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageCovid")]
    public object CurrentUsageCovid { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("weeklyCovidAdmissions")]
    public object WeeklyCovidAdmissions { get; set; }
}

public class HsaIcuBeds
{
    [System.Text.Json.Serialization.JsonPropertyName("capacity")]
    public object Capacity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageTotal")]
    public object CurrentUsageTotal { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageCovid")]
    public object CurrentUsageCovid { get; set; }
}

public class IcuBeds
{
    [System.Text.Json.Serialization.JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageTotal")]
    public int? CurrentUsageTotal { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("currentUsageCovid")]
    public int? CurrentUsageCovid { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class IcuCapacityRatio
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class InfectionRate
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class InfectionRateCI90
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class Metrics
{
    [System.Text.Json.Serialization.JsonPropertyName("testPositivityRatio")]
    public double? TestPositivityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("testPositivityRatioDetails")]
    public TestPositivityRatioDetails TestPositivityRatioDetails { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("caseDensity")]
    public double? CaseDensity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("weeklyNewCasesPer100k")]
    public double? WeeklyNewCasesPer100k { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("contactTracerCapacityRatio")]
    public object ContactTracerCapacityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("infectionRate")]
    public double? InfectionRate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("infectionRateCI90")]
    public double? InfectionRateCI90 { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("icuCapacityRatio")]
    public double? IcuCapacityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("bedsWithCovidPatientsRatio")]
    public double? BedsWithCovidPatientsRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("weeklyCovidAdmissionsPer100k")]
    public double? WeeklyCovidAdmissionsPer100k { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsInitiatedRatio")]
    public double? VaccinationsInitiatedRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsCompletedRatio")]
    public double? VaccinationsCompletedRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsAdditionalDoseRatio")]
    public double? VaccinationsAdditionalDoseRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("vaccinationsFall2022BivalentBoosterRatio")]
    public double? VaccinationsFall2022BivalentBoosterRatio { get; set; }
}

public class NegativeTests
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class NewCases
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<object> Sources { get; } = new List<object>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<Anomaly> Anomalies { get; } = new List<Anomaly>();
}

public class NewDeaths
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<object> Sources { get; } = new List<object>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<Anomaly> Anomalies { get; } = new List<Anomaly>();
}

public class PositiveTests
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class Race
{
    [System.Text.Json.Serialization.JsonPropertyName("ai_an")]
    public int AiAn { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("asian")]
    public int Asian { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("black")]
    public int Black { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("multiple")]
    public int Multiple { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("other")]
    public int Other { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("pacific_islander")]
    public int PacificIslander { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("unknown")]
    public int Unknown { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("white")]
    public int White { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("asian_or_pacific_islander")]
    public int AsianOrPacificIslander { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("multiple_other")]
    public int? MultipleOther { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("native_american")]
    public int? NativeAmerican { get; set; }
}

public class RiskLevels
{
    [System.Text.Json.Serialization.JsonPropertyName("overall")]
    public int Overall { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("testPositivityRatio")]
    public int TestPositivityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("caseDensity")]
    public int CaseDensity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("contactTracerCapacityRatio")]
    public int ContactTracerCapacityRatio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("infectionRate")]
    public int InfectionRate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("icuCapacityRatio")]
    public int IcuCapacityRatio { get; set; }
}

public class CovidApiContract
{
    [System.Text.Json.Serialization.JsonPropertyName("fips")]
    public string Fips { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("country")]
    public string Country { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("state")]
    public string State { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("county")]
    public object County { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsa")]
    public object Hsa { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsaName")]
    public object HsaName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("level")]
    public string Level { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("lat")]
    public object Lat { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("locationId")]
    public string LocationId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("long")]
    public object Long { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("population")]
    public int Population { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("hsaPopulation")]
    public int? HsaPopulation { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("metrics")]
    public Metrics Metrics { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("riskLevels")]
    public RiskLevels RiskLevels { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("cdcTransmissionLevel")]
    public int CdcTransmissionLevel { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("communityLevels")]
    public CommunityLevels CommunityLevels { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("actuals")]
    public Actuals Actuals { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("annotations")]
    public Annotations Annotations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("lastUpdatedDate")]
    public string LastUpdatedDate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public string Url { get; set; }
}

public class Sex
{
    [System.Text.Json.Serialization.JsonPropertyName("female")]
    public int Female { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("male")]
    public int Male { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("other")]
    public int Other { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("unknown")]
    public int Unknown { get; set; }
}

public class Source
{
    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("url")]
    public List<string> Url { get; } = new List<string>();

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }
}

public class TestPositivityRatio
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class TestPositivityRatioDetails
{
    [System.Text.Json.Serialization.JsonPropertyName("source")]
    public string Source { get; set; }
}

public class VaccinationsAdditionalDose
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class VaccinationsCompleted
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class VaccinationsFall2022BivalentBooster
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class VaccinationsInitiated
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class VaccinationsInitiatedDemographics
{
    [System.Text.Json.Serialization.JsonPropertyName("age")]
    public Age Age { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("race")]
    public Race Race { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("ethnicity")]
    public Ethnicity Ethnicity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sex")]
    public Sex Sex { get; set; }
}

public class VaccinesAdministered
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class VaccinesAdministeredDemographics
{
    [System.Text.Json.Serialization.JsonPropertyName("age")]
    public Age Age { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("race")]
    public Race Race { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("ethnicity")]
    public Ethnicity Ethnicity { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sex")]
    public Sex Sex { get; set; }
}

public class VaccinesDistributed
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

public class WeeklyNewCasesPer100k
{
    [System.Text.Json.Serialization.JsonPropertyName("sources")]
    public List<Source> Sources { get; } = new List<Source>();

    [System.Text.Json.Serialization.JsonPropertyName("anomalies")]
    public List<object> Anomalies { get; } = new List<object>();
}

