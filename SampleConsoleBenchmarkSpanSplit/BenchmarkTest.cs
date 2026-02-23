using BenchmarkDotNet.Attributes;

namespace SampleConsoleBenchmarkSpanSplit;

[MemoryDiagnoser]
public class BenchmarkTest
{
    [Benchmark]
    public string SplitComSpan() => DataExtract.SplitSpan("987_idTeste");
    
    [Benchmark]
    public string SplitComString() => DataExtract.SplistString("987_idTest");
}