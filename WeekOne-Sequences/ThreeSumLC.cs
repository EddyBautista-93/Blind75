using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
public class ThreeSumLC
{
    /*
    Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

    Notice that the solution set must not contain duplicate triplets.

    

    Example 1:

    Input: nums = [-1,0,1,2,-1,-4]
    Output: [[-1,-1,2],[-1,0,1]]
    Example 2:

    Input: nums = []
    Output: []
    Example 3:

    Input: nums = [0]
    Output: []
    */


    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        // Sort the Array for ease
        Array.Sort(nums);
        // Create return Item
        IList<IList<int>> outputList = new List<IList<int>>();
        if(nums == null || nums.Length < 3)
            return outputList;

        for (var i = 0; i < nums.Length -2; i++)
        {
            if(nums[i] == 0 || (i > 0 && nums[i] == nums[i - 1]))
                continue;

            int low = i + 1;
            int high = nums.Length - 1;
            while(low < high)
            {
                if(nums[i] + nums[low] + nums[high] == 0)
                {
                    outputList.Add(new List<int>(){nums[i], nums[low], nums[high]});
                    low++;
                    high--;
                    while(low < high && nums[low] == nums[low - 1])
                        low++;
                    while(low < high && nums[high] == nums[high - 1])
                        high--;
                }
                else if(nums[i] + nums[low] + nums[high] > 0)
                    high--;
                else
                    low++;
            }
            
        }

        return outputList;
    }



}