using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(15);
            Names();
        }
        public static void RandomArray()
        {
            int[] randomArray = new int[10];
            Random rand = new Random();
            for(int val=0; val < 10; val ++)
            {
                int add = rand.Next(5,25);
                randomArray[val]=add;
            }
            Console.Write("Elements In Array Are: ");
            for(int val=0; val < 10; val++)
            {
                Console.Write("{0} ", randomArray[val]);
            }
            Console.WriteLine();

            Console.Write("The max value in the array is: ");
            int max = randomArray[0];
            foreach(var maxNum in randomArray)
            {
                if(maxNum > max)
                {
                    max = maxNum;
                }
            }
            Console.Write(max);
            Console.WriteLine();

            Console.Write("The min value in the array is: ");
            int min = randomArray[0];
            foreach(var minNum in randomArray)
            {
                if(minNum < min)
                {
                    min = minNum;
                }
            }
            Console.Write(min);
            Console.WriteLine();


        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            int coin = rand.Next(1,3);
            if(coin == 1)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else{
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        public static void TossMultipleCoins(int num)
        {
            int flip = 0;
            int heads = 0;
            while (flip <= num)
            {
                TossCoin();
                if(TossCoin()== "Heads")
                {
                    heads+=1;
                }
                flip+=1;
            }
            Console.WriteLine($"The Ratio of Heads Tossed to Total Tosses is {heads}:{flip}");
        }

        public static string[] Names()
        {
            string[] Names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random ();
            for(int i = 0; i < Names.Length; i++)
            {
                int j = rand.Next(Names.Length);
                string temp = Names[j];
                Names[j] = Names[i];
                Names[i]=temp;
            }

            Console.Write("Names in Rearranged List Are: ");
            for(int i = 0; i < Names.Length; i++)
            {
                Console.Write("{0} ", Names[i]);
            }
            Console.WriteLine();
            Console.Write("Names that are greater than five letters: ");
            foreach(var name in Names)
            {
                if(name.Length >=5)
                {
                    Console.Write($"{name}, ");
                }
            }
            return Names;
        }
    }
}
