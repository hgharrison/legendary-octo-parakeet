using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            // Substitute input file location
            FileStream f = new FileStream("in.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(f);

            var arrSize = File.ReadAllLines("in.txt").Length;
            int[] storeNum = new int[arrSize];

            for (int i = 0; i < arrSize; i++) {
                storeNum[i] = Convert.ToInt32(sr.ReadLine());
            }
            Array.Sort(storeNum);

            Console.WriteLine("Random Number Optimizer");

            /*
            foreach (var item in storeNum) {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            */

            int[] spaceStore = new int[arrSize];

            for (int i = 0; i < arrSize - 1; i++)
                spaceStore[i] = storeNum[i + 1] - storeNum[i];

            /*
            foreach (var item in spaceStore)
                Console.Write(item.ToString() + " ");
            */

            Console.WriteLine();

            int big = spaceStore.Max();
            int ind = spaceStore.ToList().IndexOf(big);

            int finalPick = storeNum[ind] + (big / 2);

            Console.WriteLine("Closest int is {0}", storeNum[ind]);
            Console.WriteLine("Int to pick is {0}", finalPick);

        }
    }
}
