/*
5
25
30
12
19
24
16
20

10
30
14
8
23
27
28
15
17
25
26
5
18

 */

namespace Problem_BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int studentsQty=int.Parse(Console.ReadLine());
            int lecturesQty=int.Parse(Console.ReadLine());
            int additionalBonus=int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttended = 0;
            for(int i=0; i<studentsQty; i++) 
            {
            int attendancePerStudent=int.Parse(Console.ReadLine());
                double totalBonus= 1.0*attendancePerStudent / lecturesQty * (5 + additionalBonus);
                
                if(totalBonus>maxBonus) 
                {
                    maxBonus= totalBonus;
                    maxAttended= attendancePerStudent;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttended} lectures.");

        }
    }
}