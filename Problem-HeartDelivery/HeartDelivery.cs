/*
10@10@10@2
Jump 1
Jump 2
Love!

2@4@2
Jump 2
Jump 2
Jump 8
Jump 3
Jump 1
Love!

 */
namespace Problem_HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] neighborhood=Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            int index = 0;
            string inputToken = "";

            while ((inputToken = Console.ReadLine()) != "Love!")
            {
                string[] command = inputToken.Split();
                //"Jump {length}".
                int length = int.Parse(command[1]);

                index += length;

                if (index > neighborhood.Length - 1)
                { index = 0; }

                if (neighborhood[index]==0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                   continue;
                }

                neighborhood[index] -= 2;

                if (neighborhood[index]==0)
                { Console.WriteLine($"Place {index} has Valentine's day.");}
 
            }
            Console.WriteLine($"Cupid's last position was {index}.");

            int fails = 0;
            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] != 0) { fails++; }
            }

            if (fails == 0)
            { Console.WriteLine("Mission was successful."); }
            else if (fails!=0)
            { Console.WriteLine($"Cupid has failed {fails} places."); }
        }
    }
}