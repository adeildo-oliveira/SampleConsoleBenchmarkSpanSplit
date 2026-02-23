# 🚀 .NET Benchmark: String.Split vs. Span<T>

Sample para comparar a performance e alocação de memória entre o método tradicional de Split de strings e a utilização de `Span<T>`/`ReadOnlySpan<char>`.

## 📌 Contexto
Em um cenário de alta volumetria de requisições, pequenas ações podem ajudar a escalar a sua aplicação.

No .NET, temos a possibilidade de evitar alocações desnecessárias na **Heap** usando o recurso de `Span<T>`/`ReadOnlySpan<char>`. Enquanto o `string.Split()` cria um novo array e novas instâncias de string para cada parte, o uso de `Span` permite realizar o fatiamento (slicing) sem alocações adicionais.

## 📊 Resultados do Benchmark
Os testes foram realizados utilizando a biblioteca [BenchmarkDotNet](https://benchmarkdotnet.org).

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

## 🏃 Como rodar o teste
Para garantir a precisão dos resultados, o benchmark deve ser executado obrigatoriamente em modo **Release**:

```bash
# Navegue até a pasta do projeto
../SampleConsoleBenchmarkSpanSplit

# Execute o comando
dotnet build -c Release

# Execute o benchmark
dotnet SampleConsoleBenchmarkSpanSplit/bin/Release/net10.0/SampleConsoleBenchmarkSpanSplit.dll
