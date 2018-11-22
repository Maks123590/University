namespace HaffmanCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using PriorityQueueDemo;

    class Program
    {
        static void Main(string[] args)
        {
            var chars = new Dictionary<char, int>
                            {
                                ['a'] = 5,
                                ['b'] = 2,
                                ['r'] = 2,
                                ['c'] = 1,
                                ['d'] = 1,
                            };

            var charAndCode = chars.ToDictionary(pair => pair.Key, pair => new StringBuilder());

            var priorityQueue = new PriorityQueue<int, List<char>>();

            foreach (var ch in chars)
            {
                priorityQueue.Enqueue(ch.Value, new List<char> { ch.Key });
            }

            while (priorityQueue.Count > 1)
            {
                var elem1 = priorityQueue.Dequeue();
                var elem2 = priorityQueue.Dequeue();

                foreach (var ch in elem1.Value)
                {
                    charAndCode[ch].Append('1');
                }

                foreach (var ch in elem2.Value)
                {
                    charAndCode[ch].Append('0');
                }

                var letters = new List<char>();

                letters.AddRange(elem1.Value);
                letters.AddRange(elem2.Value);

                priorityQueue.Enqueue(elem1.Key + elem2.Key, letters);
            }

            var result = charAndCode.ToDictionary(c => c.Key, c => c.Value.ToString().Reverse());

            foreach (var kv in result)
            {
                Console.WriteLine($"{kv.Key} : {new string(kv.Value.ToArray())}");
            }

            Console.ReadLine();

        }

        private class Node
        {
            public List<char> Letters { get; set; }

            public int TotalWeight { get; set; }
        }
    }
}
