/*
1 1 2 2 3 3 4 4 5 5
1 0
-1 0
1 0
1 0
1 0
end

a 2 4 a 2 4
0 3
0 2
0 1
0 1
end

a 2 4 a 2 4
4 0
0 2
0 1
0 1
end

 */

using System.Xml.Linq;

namespace Problem_MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = "";
            int moviesCounter = 0;
            while((input = Console.ReadLine()) != "end")
            {
                int[]inputTokens=input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstIndex = inputTokens[0], secondIndex = inputTokens[1];
                moviesCounter++;


                if (firstIndex == secondIndex
                   || firstIndex >= list.Count
                   || firstIndex < 0
                   || secondIndex >= list.Count
                   || secondIndex < 0)
                {
                    int middleIndex = list.Count / 2;
                    list.Insert(middleIndex, ($"-{moviesCounter}a"));
                    list.Insert(middleIndex, ($"-{moviesCounter}a"));
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                else if (list[firstIndex] == list[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[firstIndex]}!");
                    if (secondIndex < firstIndex)
                    {
                        list.RemoveAt(firstIndex);
                        list.RemoveAt(secondIndex);

                    }
                    else
                    {
                        list.RemoveAt(secondIndex);
                        list.RemoveAt(firstIndex);

                    }
                }
                else if (list[firstIndex] != list[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }


               if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {moviesCounter} turns!");
                    break;
                }
                  
            }
            if (list.Count> 0) 
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}