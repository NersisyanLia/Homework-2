//Write a function To find the middle element(s) of a list

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //This line creates a new list of integers (List<int>) 
        //named numbers and initializes it with a collection of values { 1, 2, 3, 4, 5, 6, 7 }.
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //This line calls the "FindMiddleElements" function
        List<int> middleElements = FindMiddleElements(numbers);
        //This line prints the string "Middle Element(s):" to the console.
        Console.WriteLine("Middle Element(s):");
        //This is a foreach loop that iterates over each element in the middleElements list
        foreach (var element in middleElements)
        {
            Console.WriteLine(element);
        }
    }

    //This line declares a static function named FindMiddleElements
    static List<L> FindMiddleElements<L>(List<L> list)
    {
        //This line creates a new list (middleElements) that will store the middle elements.
        List<L> middleElements = new List<L>();

        //If the input list is empty, the function returns an empty list. 
        //There are no middle elements to find in an empty list.
        if (list.Count == 0)
        {
            return middleElements;
        }

        //This gives the index of the middle element 
        int middleIndex = list.Count / 2;

        //If the list has an even number of elements, it means there are two middle elements.
        if (list.Count % 2 == 0)
        {
            //The middle element is added to the middleElements list.
            middleElements.Add(list[middleIndex - 1]);
        }
        //The function returns the middleElements list containing the middle elements
        //of the input list.
        middleElements.Add(list[middleIndex]);
        return middleElements;
    }
}

//Write a function that takes in a list of integers and returns the largest integer in the list.
using System;
using System.Collections.Generic; // Import the necessary namespace for List
using System.Linq; // Import the necessary namespace for LINQ

class Program
{
    static void Main()
    {
        // Example usage
        List<int> numbers = new List<int> { 5, 2, 8, 1, 7 };
        int result = GetLargestNumber(numbers);
        Console.WriteLine("The largest number is: " + result);
    }

    // Function to get the largest number in a list of integers
    static int GetLargestNumber(List<int> numbers)
    {
        // Using LINQ's Max function to find the maximum value in the list
        return numbers.Max();
    }
}