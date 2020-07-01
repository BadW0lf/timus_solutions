using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class DSUExample
    {
        private List<int> _master;
        private List<int> _size;
        
        public int GetMainParent(int startVertex)
        {
            if (_master[startVertex] == startVertex)
                return startVertex;
            return _master[startVertex] =
                GetMainParent(_master[startVertex]);
        }

        public void Initialize(int n)
        {
            _master =new List<int>();
            _size =new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                _master.Add(i);
                _size.Add(1);
            }
        }
        
        public void Union(int a, int b)
        {
            a = GetMainParent(a);
            b = GetMainParent(b);

            if (a != b)
            {
                if (_size[a] < _size[b])
                {
                    var tmp = a;
                    a = b;
                    b = tmp;
                }
                _master[b] = a;
                _size[a] += _size[b];
            }   
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var dsu = new DSUExample();
            
            var set = new HashSet<int>();
            
            dsu.Initialize(line[0]);
            for (int i = 0; i < line[1]; i++)
            {
                var t = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                dsu.Union(t[0] - 1, t[1] - 1);
                
            }

            for (int i = 0; i < line[0]; i++)
            {
                set.Add(dsu.GetMainParent(i));
            }

            Console.Out.WriteLine("{0}", set.Count - 1);
        }
    }
}
