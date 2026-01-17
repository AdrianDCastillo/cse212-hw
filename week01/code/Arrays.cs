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
        double[] multiples = new double[length]; // Step 1: Create an array of doubles with the specified length

        for (int i = 0; i < length; i++) // Step 2: Loop through the array indices from 0 to length - 1
        {
            multiples[i] = number * (i + 1); // Step 3: Calculate the multiple and assign it to the current index
        }

        return multiples; // Step 4: Return the array of multiples

        // Notations Big O
        // The time complexity of this function is O(n), where n is the length of the array.
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

        int elements = data.Count; // Step 1: Get the number of elements in the list
        int indexRotate = elements - amount; // Step 2: Calculate the starting index for rotation

        List<int> results = new List<int>(); // Step 3: Create a new list to store the rotated elements

        for (int i = indexRotate; i < elements; i++) // Step 4: Loop from the rotation index to the end of the list
        {
            results.Add(data[i]); // Step 5: Add the elements from the rotation index to the end to the results list
        }

        for (int i = 0; i < indexRotate; i++) // Step 6: Loop from the beginning of the list to the rotation index
        {
            results.Add(data[i]); // Step 7: Add the elements from the beginning to the rotation index to the results list
        }

        data.Clear(); // Step 8: Clear the original list
        data.AddRange(results); // Step 9: Add the rotated elements back to the original list

        //Notations Big O
        // The time complexity of this function is O(n), where n is the number of elements in the list.
        // This is because we are looping through the list a constant number of times (twice in this case).
    }
}
