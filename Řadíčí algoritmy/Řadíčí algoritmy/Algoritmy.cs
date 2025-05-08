using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Řadíčí_algoritmy
{
    
    public class Algoritmy
    {






        [Benchmark]
        public List<T> BubbleSort<T>(List<T> list) where T : IComparable<T>
        {
            
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    }
                }
            }
            return list;
        }
        
        public List<T> QuickSort<T>( List<T> list) where T : IComparable<T>
        {
            if (list.Count <= 1) return list;
            T pivot = list[list.Count / 2];
            List<T> left = list.FindAll(x => x.CompareTo(pivot) < 0);
            List<T> middle = list.FindAll(x => x.CompareTo(pivot) == 0);
            List<T> right = list.FindAll(x => x.CompareTo(pivot) > 0);

            List<T> sortedList = new List<T>();
            sortedList.AddRange(QuickSort(left));
            sortedList.AddRange(middle);
            sortedList.AddRange(QuickSort(right));

            return sortedList;
        }
        
        public List<T> StalinSort<T>( List<T> list) where T : IComparable<T>
        {
            if (list.Count == 0) return list;
            List<T> result = new List<T> { list[0] };
            foreach (var item in list)
            {
                if (item.CompareTo(result[^1]) >= 0)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
