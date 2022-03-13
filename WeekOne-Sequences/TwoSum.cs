using System;
using System.Collections.Generic;
using System.Linq;
public class TwoSum
{
    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order.

    Example 1:

    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    Example 2:

    Input: nums = [3,2,4], target = 6
    Output: [1,2]
    */

    public static int[] TwoSumQ(int[] nums, int target)
    {
        //create a hashset to implement search 
        Dictionary<int, int> indexAndNum = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            // Grab the value diff val.
            // if you found the value return they key index and current index.
            int diff = target - (int)nums[i];
            if (indexAndNum.ContainsValue(diff))
            {
                
                int[] returnIndices = { indexAndNum.FirstOrDefault(x => x.Value == diff).Key, i };
                return returnIndices;
            }
            else
            {
                indexAndNum.Add(i, nums[i]);

            }
        }
        return new int[] { 0, 0 };
    }
    public static void Main(string[] args)
    {
        int[] testArr = new int[] { 2, 7, 11, 15 };
        TwoSumQ(testArr, 9);
    }
}