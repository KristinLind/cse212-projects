public class FeatureCollection
{
    public List<Feature> Features { get; set; } = new();
}

public class Feature
{
    public Properties Properties { get; set; } = new();
}

public class Properties
{
    public double? Mag { get; set; }
    public string Place { get; set; } = "";
}
/// <summary>
/// These classes were created to match the structure of the earthquake JSON data.
/// This allows JsonSerializer to convert the data into objects so I can easily
/// access each earthquake’s place and magnitude.
/// </summary>