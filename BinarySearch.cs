using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BinarySearch_EdnaLynnLaxa
{
    internal class BinarySearch
    {
        // Iterative binary search function
        public static int IterativeBinarySearch(int[] array, int target)
        {
            int left = 0; // value of a variable called left to 0.
                          // The beginning index of the search space within the array will be represented by this variable.

            int right = array.Length - 1; // variable's initial value to the length of the array minus one.
                                          // This is the final index of the original search space, which includes the whole array.

            while (left <= right) // While loop to continue as long as left is less than / equal to the right. This makes certainty
                                  // that the loop go through over and over again until the search results to empty or target not found
            {
                int mid = left + (right - left) / 2; // Computes the current search part in the mid index inside the loop. This locates
                                                     //the middle element by calculatging left+(right-left)/2. 
                                                     // The reason why this is an appropriate calculation is because its a midpoint 
                                                     //formula
             //Research: The midpoint of the search space in binary search is determined using the formula left + (right – left) / 2.
             //This formula is frequently chosen over the simpler one. (left + right) / 2 to prevent any problems with integer overflow

                // Check if target is present at mid
                if (array[mid] == target) // Determines wheather the value @ the array mid point is equivilant to the target value. 
                    return mid; // If the target element is found @ mid index than the fuction ends the loop by returning mid by 
                                //calling the return statement 

                // If target greater, ignore left half
                if (array[mid] < target) //determines if the midpoint value is smaller than the desired value.
                    //If it's less, it means that because the array is sorted, the target element must be on the right half of
                    //the remaining search space. 
                    left = mid + 1; //To ensure that the left half is not included in the subsequent iteration,
                    //left is changed to mid + 1.

                // If target is smaller, ignore right half
                else
                    right = mid - 1; //Else , if the ifs are not true then this come into play. Most likely the mid is greater than 
                //said target. The lement is left half of the remaining search , therefore right is updated to mid - 1 to prohibit the 
                //right half from next go around. 
            }

            // If we reach here, then the element was not present
            return -1;
        }

        // Recursive binary search function
        public static int RecursiveBinarySearch(int[] array, int target, int left, int right) //Takes four arguments : integer array
                                                                                              //value of integer we are looking for
                                                                                              //left = starting index of the current search space 
                                                                                              //right = the end of the index 
        {
            if (left <= right) // Checks if left is less than or equal to right , base action for a recursion 
            {
                int mid = left + (right - left) / 2;// Computes the current search part in the mid index inside the loop. This locates
                                                    //the middle element by calculatging left+(right-left)/2. 
                                                    // The reason why this is an appropriate calculation is because its a midpoint 
                                                    //formula
             //Research: The midpoint of the search space in binary search is determined using the formula left + (right – left) / 2.
             //This formula is frequently chosen over the simpler one. (left + right) / 2 to prevent any problems with integer overflow

                // Check if target is present at mid
                if (array[mid] == target) // Checks mid index is matched to target 
                    return mid; //If its then mid is returned 

                // If target is smaller than mid, search left half
                //Recursion calls for subspaces 
                if (array[mid] > target) 
                    return RecursiveBinarySearch(array, target, left, mid - 1);

                // If target is greater than mid, search right half
                return RecursiveBinarySearch(array, target, mid + 1, right);
            }

            // If we reach here, then the element was not present
            return -1;
        }

    } // BinarySearch
}

