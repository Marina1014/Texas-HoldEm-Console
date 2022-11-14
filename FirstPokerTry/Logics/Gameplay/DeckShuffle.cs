using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPokerTry.Logics.Gameplay
{
    public class DeckShuffle
    {
        static void CardList(string args)
        {
            string[] arr = { "one", "two", "three" };
            Shuffle(arr);

            for(int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.ReadLine();
       }
        
       
            public static void Shuffle(string[] a)
        {
            int n = a.Length;
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                swap(a, i, i + rand.Next(n - i));
            }
        }
        public static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b]; arr[b] = temp;
        }
        
    }
}

    
