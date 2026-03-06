using System.Collections.Generic;
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Initialize a new double array of the specified 'length'.
        double[] results = new double[length];
        // Step 2: Loop from 1 up to 'length' (inclusive).
        for (int i = 1; i <= length; i++)
        {
            // Step 3: In each iteration, calculate the multiple (number * current index).
            results[i - 1] = number * i;
        }
        // Step 4: Store the result in the array (at index i - 1).
        // Step 5: Return the completed array.
        return results; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine the split point by subtracting 'amount' from the total count.
        // Calculate the starting index of the section we are moving
        int splitIndex = data.Count - amount;
        // Step 2: Extract the last 'amount' elements into a temporary list (the part to be moved).
        // Get the range of numbers to move
        List<int> movedPart = data.GetRange(splitIndex, amount);
        // Step 3: Remove those same elements from the end of the original 'data' list.
        // Remove them from the back
        data.RemoveRange(splitIndex, amount);
        // Step 4: Insert the temporary list at the very beginning (index 0) of the 'data' list.
        // Put them at the front
        data.InsertRange(0, movedPart);
    }
}
