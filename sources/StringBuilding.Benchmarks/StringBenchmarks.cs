// C# Pills 15mg
// Copyright (C) 2022-2023 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Text;
using BenchmarkDotNet.Attributes;

namespace DustInTheWind.StringBuilding.Benchmarks;

[SimpleJob(iterationCount: 200)]
public class StringBenchmarks
{
    private const char C = '*';

    [Params(100, 1000)]
    public int StringLength { get; set; }
    
    public string Result;

    [Benchmark(Description = "Concatenation")]
    public void StringConcatenationBenchmark()
    {
        int i = 0;
        string s = string.Empty;

        while (i < StringLength)
        {
            s += C;
            i++;
        }

        Result = s;
    }

    [Benchmark(Description = "StringBuilder")]
    public void StringBuilderBenchmark()
    {
        int i = 0;
        StringBuilder stringBuilder = new(StringLength);
        
        while (i < StringLength)
        {
            stringBuilder.Append(C);
            i++;
        }
        
        Result = stringBuilder.ToString();
    }

    [Benchmark(Description = "String ctor")]
    public void StringConstructorBenchmark()
    {
        Result = new string(C, StringLength);
    }
}