namespace Problem_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople=int.Parse(Console.ReadLine());
            List<int>lift=Console.ReadLine().Split().Select(int.Parse).ToList();

            for(int i = 0; i < lift.Count; i++)
            {
                int emptySpaces = 4 - lift[i];
                if (emptySpaces>0)
                {
                    if(waitingPeople>=emptySpaces) 
                    { lift[i] += emptySpaces; }
                    else 
                    { lift[i] += waitingPeople;
                        waitingPeople = 0;
                        Console.WriteLine("The lift has empty spots!");
                        break;
                    }
                 }
                waitingPeople -= emptySpaces;
            }
            
            if(waitingPeople>0)
            { Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!"); }

            Console.WriteLine(string.Join(" ",lift));
        }
    }
}