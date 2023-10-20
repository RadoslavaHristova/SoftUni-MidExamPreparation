using System.Runtime.Serialization.Formatters;
/*
10
5
5.2
1

1
1.5
3
1.5

9
5
5.2
1

 */

namespace Problem_GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food =double.Parse(Console.ReadLine())*1000;//we need grams
            double hay = double.Parse(Console.ReadLine())*1000;
            double cover = double.Parse(Console.ReadLine())*1000;
            double pigWeight= double.Parse(Console.ReadLine()) * 1000;

            for (int day = 1; day <= 30; day++) 
            {
                food -= 300;
                if (day%2==0) 
                {
                    hay -= food * 0.05;
                }
                if (day%3==0)
                {
                    cover -= pigWeight / 3;
                }
                if (food<=0||hay<=0||cover<=0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food/1000):F2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
        }
    }
}