```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-JQZMBE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2

IterationCount=200  

```
| Method        | StringLength | Mean          | Error      | StdDev       | Median        |
|-------------- |------------- |--------------:|-----------:|-------------:|--------------:|
| **Concatenation** | **100**          |   **2,856.07 ns** |  **65.799 ns** |   **274.257 ns** |   **2,803.80 ns** |
| StringBuilder | 100          |     348.44 ns |   6.434 ns |    26.887 ns |     347.03 ns |
| &#39;String ctor&#39; | 100          |      41.93 ns |   1.001 ns |     4.118 ns |      40.33 ns |
| **Concatenation** | **1000**         | **104,271.34 ns** | **929.487 ns** | **3,811.934 ns** | **103,092.47 ns** |
| StringBuilder | 1000         |   2,955.03 ns |  50.705 ns |   211.907 ns |   2,937.97 ns |
| &#39;String ctor&#39; | 1000         |     312.96 ns |   6.465 ns |    26.073 ns |     303.51 ns |
