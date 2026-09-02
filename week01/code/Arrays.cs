public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    ///
    /// ***STEPS MultiplesOf FUNCTION:***
    /// 1. Create an array of doubles called multiples with a size equal to the length parameter.
    /// 2. Create a for loop that goes from index 0 to length - 1.
    /// 3. Inside the loop, "multiples" store number * (i + 1) at position i. The "+ 1" is needed because the index starts at 0, but the multiples start at 1.
    /// 4. Returns "multiples" array.
    public static double[] MultiplesOf(double number, int length)
    {
        var multiples = new double[length]; // Determines the length of the array according to the input.
        for (var i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    ///
    /// ***STEPS RotateListRight FUNCTION:***
    /// 1. Use GetRange to copy the last "amount" items into a new list called "sublist". The block starts at index
    ///     data.Count - amount.
    /// 2. Use RemoveRange with the same index and count to delete those items from the original list.
    /// 3. Use InsertRange to insert the sublist at index 0, the front of the list.
    public static void RotateListRight(List<int> data, int amount)
    {   
        List<int> sublist = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, sublist);
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
