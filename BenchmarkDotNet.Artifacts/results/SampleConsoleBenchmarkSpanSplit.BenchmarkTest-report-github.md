```

BenchmarkDotNet v0.15.8, Linux Linux Mint 22.3 (Zena)
Intel Core i5 CPU 2.70GHz (Max: 3,100.02GHz) (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3


```
| Method         | Mean     | Error    | StdDev   | Gen0   | Allocated |
|--------------- |---------:|---------:|---------:|-------:|----------:|
| SplitComSpan   | 31.43 ns | 0.114 ns | 0.101 ns | 0.0102 |      32 B |
| SplitComString | 66.76 ns | 0.304 ns | 0.284 ns | 0.0356 |     112 B |
