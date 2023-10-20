/*
Tomatoes!Potatoes!Bread
Unnecessary Milk
Urgent Tomatoes
Go Shopping!

Milk!Pepper!Salt!Water!Banana
Urgent Salt
Unnecessary Grapes 
Correct Pepper Onion
Rearrange Grapes
Correct Tomatoes Potatoes
Go Shopping!
 */

namespace Problem_ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList =Console.ReadLine().Split('!').ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] arguments = command.Split();
                string item = arguments[1];
                switch (arguments[0]) 
                {
                    case "Urgent":
                        if (!shoppingList.Contains(item))
                        { shoppingList.Insert(0, item); }
                        break;
                    case "Unnecessary":
                        if(shoppingList.Contains(item))
                        { shoppingList.Remove(item); }
                        break;
                    case "Correct":
                        string newItem = arguments[2];
                        if (shoppingList.Contains(item))
                        {
                            int index = shoppingList.IndexOf(item);
                            if (index != -1)
                            {
                                shoppingList[index] = newItem;
                            }
                            }
                            break;
                    case "Rearrange":
                        if (shoppingList.Contains(item))
                        {   
                            shoppingList.Remove(item);
                            shoppingList.Add(item);
                        }
                            break;
                }

            }
            //•	Print the list with all the groceries, joined by ", ":
            Console.WriteLine(string.Join(", ", shoppingList));

        }
    }
}