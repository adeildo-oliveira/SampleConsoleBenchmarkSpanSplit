using BenchmarkDotNet.Running;
using SampleConsoleBenchmarkSpanSplit;

// var beforeGen0 = GC.CollectionCount(0);
// var beforeGen1 = GC.CollectionCount(1);
// var beforeGen2 = GC.CollectionCount(2);
// var tempo = new Stopwatch();
// tempo.Start();
//
// //var extarctData = DataExtract.SplitSpan("987_idTeste");
// var extarctData = DataExtract.SplistString("987_idTeste");
//
// tempo.Stop();
//
// Console.WriteLine($"TEMPO: {tempo.ElapsedMilliseconds} ms");
// Console.WriteLine($"GEN 0: {GC.CollectionCount(0) - beforeGen0}");
// Console.WriteLine($"GEN 1: {GC.CollectionCount(1) - beforeGen1}");
// Console.WriteLine($"GEN 2: {GC.CollectionCount(2) - beforeGen2}");
// Console.WriteLine($"ID EXTRAÍDO: {extarctData}");

_ = BenchmarkRunner.Run<BenchmarkTest>();