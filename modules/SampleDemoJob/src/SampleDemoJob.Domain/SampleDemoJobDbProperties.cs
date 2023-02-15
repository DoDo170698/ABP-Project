namespace SampleDemoJob;

public static class SampleDemoJobDbProperties
{
    public static string DbTablePrefix { get; set; } = "SampleDemoJob";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "SampleDemoJob";
}
