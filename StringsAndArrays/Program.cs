using System;

namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";

            // 1.1 Print the length of the string.
            Console.WriteLine("Length of the string is: "+helloWorld.Length);
            // 1.2 Print the first and the last character of the string.
            Console.WriteLine("First letter of the string: " + helloWorld[0] + " Last letter of the string is: " + helloWorld[helloWorld.Length - 1]);
            // 2. String Manipulation
            Console.Write("Please enter your name: ");
            // 2.1 Get the input from and assing it into new string variable called name
            String name = Console.ReadLine();
            // 2.2 Print a personalized welcome message including the name.
            Console.WriteLine("Tervetuloa " + name);
            // 2.3 Convert name variable to uppercase and output the result
            Console.WriteLine(name.ToUpper());
            // 2.4 Convert name variable to lowercase and output the result
            Console.WriteLine(name.ToLower());
            // 3. String Searching
            // 3.1 Create new boolean variable called containsWorld
            bool containsWorld;

            // 3.2 Check that the helloWorld variable contains the word "World".
            //     Assign the result to the created constainsWorld variable
            if (helloWorld.Contains("World"))
            {
                containsWorld = true;
            }
            else
            {
                containsWorld = false;
            }
            // 3.3 If the word is found, get the index of the word from helloWorld string
            if (containsWorld == true) { Console.WriteLine("The index of Hello in the String is: "+helloWorld.IndexOf("World")); }

            // PART 2: Arrays

            // 1. Basic Array Operations
            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11 
            int[] numbers = { 2, 3, 5, 7, 11 };
            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11
            for (int i = 0; i < 5; i++) { Console.WriteLine(numbers[i]); }
            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5
            Console.WriteLine(numbers[2]);

            // 2. Array Manipulation
            Console.WriteLine("Please enter five names:");
            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5
            string[] names=new string[5];
            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here
            //Console.WriteLine("Write 5 names here ");
            for(int i = 0; i < 5; i++) { names[i]=Console.ReadLine(); }
            // 2.3 Output the array of given names.
            Console.WriteLine("the names are:");
            for (int i = 0; i < 5; i++) { Console.WriteLine(names[i]); }
            // 2.4 Reverse the order of the items in the names array and outpu the result
            Console.WriteLine("Name in reverse order is: ");
            for (int i = 4; i >= 0; i--) { Console.WriteLine(names[i]); }

            // 3. Array Searching
            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();
            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable
            var index = Array.FindIndex(names, row => row.Contains(searchName));
            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            if (index >= 0) Console.WriteLine("the index is found");
            else Console.WriteLine("the index is not found");   //if nothing is found then it will show -1;
            // 3.2.1 If position is found output the searchName and the found position
            if(index>=0) Console.WriteLine("the position of the searchname is: " + (index + 1)+" and the searchname is: " + names[index]);
            // 3.2.2 Else output that the searchName was not found
            else { Console.WriteLine("the name is not found"); }
            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array

            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array

            // 1.3 Output the values of the words array
        }
    }
}
