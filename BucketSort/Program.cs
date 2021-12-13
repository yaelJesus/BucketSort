using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            int[] vector;
            vector = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = r.Next(-100, 100);
            }
            bucketSort(vector);
            Console.WriteLine("Vector ordenado en forma ascendente");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadKey();
        }

		private static void bucketSort(int[] data)
		{
			int minValue = data[0];
			int maxValue = data[0];

			for (int i = 1; i < data.Length; i++)
			{
				if (data[i] > maxValue)
					maxValue = data[i];
				if (data[i] < minValue)
					minValue = data[i];
			}

			List<int>[] bucket = new List<int>[maxValue - minValue + 1];

			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<int>();
			}

			for (int i = 0; i < data.Length; i++)
			{
				bucket[data[i] - minValue].Add(data[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						data[k] = bucket[i][j];
						k++;
					}
				}
			}
		}

	}
}
