/*
24 50 36 70
0
4
3
1
End

30 30 12 60 54 66
5
2
4
0
End

 */

namespace Problem_ShootfortheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets=Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";
            int shotCounter = 0;
            while((input=Console.ReadLine())!="End")
            {
            int index = int.Parse(input);

            if(DoesTheIndexExist(targets,index))
                {
                    if (targets[index]>-1)  
                    {
                        int currentValue = targets[index];

                        targets[index] = -1;
                        shotCounter++;

                        for (int i=0; i<targets.Count; i++) 
                        {
                            if (targets[i] > -1)
                            {
                                if (targets[i] > currentValue)
                                {
                                    targets[i] -= currentValue;
                                }
                                else if (targets[i] <= currentValue)
                                {
                                    targets[i] += currentValue;
                                }
                            }
                        }
                    
                    }
                }

            }
            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ",targets)}");
        }

        private static bool DoesTheIndexExist(List<int> targets, int index)
        {
            return index>=0&&index<targets.Count;
        }
    }
}