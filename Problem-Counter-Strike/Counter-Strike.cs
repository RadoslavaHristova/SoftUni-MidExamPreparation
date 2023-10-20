/*
100
10
10
10
1
2
3
73
10

200
54
14
28
13
End of battle

 */

namespace Problem_Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy=int.Parse(Console.ReadLine());

            int count = 0;
            string input = "";

            while((input=Console.ReadLine())!= "End of battle")
            {
                int distance = int.Parse(input);

                if(energy-distance<0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    break;
                }

                else
                {
                    count++;
                    energy-=distance;

                    if(count%3==0)
                    { energy += count; }
                }

            }
            if (input=="End of battle")
            { Console.WriteLine($"Won battles: {count}. Energy left: {energy}"); }
        }
    }
}