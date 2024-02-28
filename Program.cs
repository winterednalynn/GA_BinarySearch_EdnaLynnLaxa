using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GA_BinarySearch_EdnaLynnLaxa
{//EDNA LYNN LAXA
 //COMPUTER PROGRAMMING V 
 //ASSIGNMENT: GA Binary Search 
 //February 27, 2024 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test iterative binary search
            TestIterativeBinarySearch(); 

            // Test recursive binary search
            TestRecursiveBinarySearch();

        }
        public static void TestIterativeBinarySearch()
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };// Array is organized in good order 
            int target = 11; // Aiming to locate 11 


            //PERFORMING THE SEARCH: 
            Stopwatch stopwatch = Stopwatch.StartNew(); // Starts a timer when 11 is located 
            int result = BinarySearch.IterativeBinarySearch(array, target);  // We call the function for IterativeBS. This passes through
                                                                             //The array until the target is hit. 
            stopwatch.Stop(); // Time stop when object is located. 

            if (result != -1) //Checks if result is not equal to -1 which indicate the target is not found 
                Console.WriteLine($"Iterative Binary Search: Element {target} found at index {result} in {stopwatch.ElapsedMilliseconds} ms");
            else //Search unsuccessful. 
                Console.WriteLine($"Iterative Binary Search: Element {target} not found");

            //^^ For Readable Purposes . 
        }

        public static void TestRecursiveBinarySearch()
        {
            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }; // Sorted array 
            int target = 14; // Aiming to locate 14 in the array 

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = BinarySearch.RecursiveBinarySearch(array, target, 0, array.Length - 1); // 4 applied arguments 
                                                            // Search through the array
                                                            // Find target 
                                                            // Left Index = 0 
                                                            // Right Index defined as the length of the array -1 
            stopwatch.Stop();

            if (result != -1) // if the result is not equal to -1 , search is successful 
                Console.WriteLine($"Recursive Binary Search: Element {target} found at index {result} in {stopwatch.ElapsedMilliseconds} ms");
            else //Search unsuccessful. 
                Console.WriteLine($"Recursive Binary Search: Element {target} not found");
        }
    }
 }

        //What is binary search and how does it work?
        //** An effective method for locating an item in a sorted list of elements is binary search.This process entails
        //until the target is located or it is established that the target is not present in the array, the search space
        //is continually divided in half.


        //What is the time complexity of binary search?
        //**Binary search has an O(log n) time complexity, where n is the number of entries in the sorted array  This indicates that,
        //in comparison to linear search, which has an O(n) time complexity, the search time grows logarithmically with the size
        //of the array.When the required value is directly matched by the central index, the best-case time complexity is O(1).
        //A running time of an algorithm that is bounded by a constant 'c' and is independent of the size of the input is expressed as
        //O(1).On the other hand, O(log n) indicates that our running time will increase linearly as input size 'n' grows exponentially.


        //When is binary search preferred over linear search?
        //**In many aspects, binary search is more effective and efficient than linear search, particularly when the items
        //are arranged in a certain sequence.
        //Binary Search Compatible : Sorted Arrays, Large Collection of Date, & Continual Searches (must sort the collection first) 
        //Linear Search : Small Collection & Unsorted Arrays


        //What are the key requirements for binary search to work correctly?
        //** The collection must be sorted: The dataset has to be sorted either ascending or descending in order to
        //use the binary search. Sorting enables the algorithm to detect whether the target value lies to the left or right
        //by allowing for a systematic comparison with the middle element.

        //Can binary search be applied to unsorted arrays? Why or why not?
        //** Nope; binary search cannot be used or implemented on unsorted arrays or
        //lists since the data structure's sorted order determines
        //how the mid element of one half is repeatedly targeted.
    

