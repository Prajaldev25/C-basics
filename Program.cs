using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create a list of groceries
            List<string> groceryList = new List<string>(){
                "Apple",
                "Mango",
                "Banana",
                "Milk",
                "Bread"
            };

            //how to add item to the list?
            groceryList.Add("Carrot");

            //how do I print the Banana out?
            // Console.WriteLine(groceryList[5]);

            /*Create a IEnumerable of groceries, we cannot create we have 
            to assign an array or a list to an IEnumerable, and also isn't 
            indexable*/
            IEnumerable<string> groceryList2 = groceryList;
            // Console.WriteLine(groceryList2.First());

            //Two Dimensional array
            string[,] twoDimensionalGroceryList3 = new string[,]{
                {
                    "Apple",
                    "Mango"
                },
                {
                    "Milk",
                    "Bread"
                }
            };

            Console.WriteLine(twoDimensionalGroceryList3[0, 1]); //should give Mango

            //Create a dictionary "Key value pair"
            Dictionary<string, string> groceryDictionary = new Dictionary<string, string>(){
                {"dairy", "Milk"},
                {"fruit", "Mango"},
                {"Vegetable", "Spinach"},
            };
        }
    }
}
