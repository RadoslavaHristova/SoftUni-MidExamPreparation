/*
52 74 23 44 96 110
Shoot 5 10
Shoot 1 80
Strike 2 1
Add 22 3
End

1 2 3 4 5
Strike 0 1
End

 */

namespace Problem_MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>targets=Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";

            while ((input = Console.ReadLine())!="End")
            {
                string[] inputTokens = input.Split().ToArray();

                int index = int.Parse(inputTokens[1]);

                bool foundIndex = false; ;

                if (index < targets.Count&&index>=0) 
                {  foundIndex = true; }

                switch (inputTokens[0]) 
                {
                    case "Shoot":
                       
                       if (foundIndex)
                        {
                            targets[index] -= int.Parse(inputTokens[2]);

                            if (targets[index]<=0)
                            { targets.RemoveAt(index); }
                        }
                            break;

                    case "Add":

                        if (foundIndex)
                            { targets.Insert(index, int.Parse(inputTokens[2])); }

                        else 
                        { Console.WriteLine("Invalid placement!");}

                        break;

                    case "Strike":

                        int radius = int.Parse(inputTokens[2]);
                        
                            if (index - radius < 0 
                            || index - radius >= targets.Count
                            || index + radius < 0 
                            || index + radius >= targets.Count)

                            { Console.WriteLine("Strike missed!"); }

                            else

                            {
                            for (int i=index+radius;i>index;i--)
                                { targets.RemoveAt(i); }
                            for(int i = index;i >= index - radius;i--)
                                { targets.RemoveAt(i); }
                            }

                            break;
                    }
                 }
            Console.WriteLine(string.Join('|',targets));
        }
    }
}