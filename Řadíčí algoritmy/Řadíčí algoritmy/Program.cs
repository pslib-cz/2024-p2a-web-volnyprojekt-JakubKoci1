
using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using Řadíčí_algoritmy;
List<int> numbers = Enumerable.Range(1, 10000).ToList();
Random rnd = new Random();
numbers = numbers.OrderBy(x => rnd.Next()).ToList();
Algoritmy algritmy = new Algoritmy();
var summary = BenchmarkRunner.Run<Algoritmy>();