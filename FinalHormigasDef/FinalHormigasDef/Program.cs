using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using System.Reflection;

BenchmarkSwitcher
    .FromAssembly(Assembly.GetExecutingAssembly())
    .Run(args);

[ShortRunJob]
public class Benchmarks
{
    [Benchmark]

    public void Benchmark()
    {
        Ants();
    }

    public int Ants()
    {
        string ants = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

        if (ants == null) { return 0; }

        ants = ants.Replace("ant", "");
        int a = 0; int n = 0; int t = 0;

        for (int i = 0; i < ants.Length; i++)
        {
            if (ants[i] == 'a') { a++; }
            if (ants[i] == 'n') { n++; }
            if (ants[i] == 't') { t++; }
        }

        int corpse = a;

        if (corpse < n) { corpse = n; }
        if (corpse < t) { corpse = t; }

        return corpse;
    }
}
