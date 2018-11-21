using System;
using System.Collections.Generic;
using System.Linq;

namespace Fano_Shanon_Algorithm
{
    using System.Text;

    class Program
	{
		static void Main(string[] args)
		{
			var getCharsfrequency = new Func<string, Dictionary<char, int>>(text => text.Distinct().ToDictionary(@char => @char, @char => text.Count(c => c == @char)));

			

			// var chars = getCharsfrequency(Console.ReadLine());

            var chars = new Dictionary<char, int>
                            {
                                ['A'] = 50,
                                ['D'] = 49,
                                ['B'] = 39,
                                ['E'] = 35,
                                ['F'] = 24,
                                ['C'] = 18,
                            };

		    var fanoCodes = GetFanoCodes(chars);


		    foreach (var fanoCodePair in fanoCodes)
		    {
		        Console.WriteLine($"{fanoCodePair.Key} : {fanoCodePair.Value}");
		    }

			Console.ReadLine();
		}

	    private static Dictionary<char, string> GetFanoCodes(Dictionary<char, int> dictionary)
	    {
            var codesDictionary = new Dictionary<char, string>();

	        var rootNode = new Node
	        {
	            Code = "",
                Symbhols = dictionary,
                TotalFrequency = dictionary.Sum(kv => kv.Value)
	        };

            var stack = new Stack<Node>();

            stack.Push(rootNode);

	        while (stack.Count > 0)
	        {
	            var node = stack.Pop();

	            var childs = SplitNode(node).ToArray();

	            if (childs.Length == 1)
	            {
	                codesDictionary.Add(childs.First().Symbhols.First().Key, childs.First().Code);
	            }
	            else
	            {
	                foreach (var child in childs)
	                {
	                    stack.Push(child);
	                }
	            }
	        }

	        return codesDictionary;
	    }

	    private static IEnumerable<Node> SplitNode(Node node)
	    {
	        if (node.Symbhols.Count <= 1)
	        {
	            return new List<Node> { node };
	        }
            
	        var outputNodes = new[] { new Node(), new Node() };

	        foreach (var kv in node.Symbhols)
	        {
	            if (outputNodes[0].TotalFrequency < outputNodes[1].TotalFrequency)
	            {
	                outputNodes[0].Symbhols.Add(kv.Key, kv.Value);
	                outputNodes[0].TotalFrequency += kv.Value;
	            }
	            else
	            {
	                outputNodes[1].Symbhols.Add(kv.Key, kv.Value);
	                outputNodes[1].TotalFrequency += kv.Value;
                }
	        }

	        outputNodes[0].Code = node.Code + "0";
	        outputNodes[1].Code = node.Code + "1";

	        return outputNodes;
	    }

	    private class Node
	    {
	        public Dictionary<char, int> Symbhols { get; set; } = new Dictionary<char, int>();

            public string Code { get; set; }

	        public int TotalFrequency { get; set; }
	    }
	}
}
