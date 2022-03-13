using System.Collections.Generic;
using System;
    public class ContainsDuplicates
    {
        /* 
        Given an integer array nums, return true if any value appears at least twice in the array,
        and return false if every element is distinct.
        Example 1:

        Input: nums = [1,2,3,1]
        Output: true
        Example 2:

        Input: nums = [1,2,3,4]
        Output: false
        Example 3:

        Input: nums = [1,1,1,3,3,4,3,2,4,2]
        Output: true
        
        
        */
        public static bool ContainsDuplicatesQ(int[] nums)
        {
            var list = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if(list.Contains(nums[i]))
                {
                    return true;
                    
                } else{
                        list.Add(nums[i]);
                } 
                                 
            }

            return false;
        }

        // A faster way with hashsets
        public static bool CSHashSet(int[] nums)
        {
            var seen = new HashSet<int>();
            foreach (var x in nums)
            {
                if(seen.Contains(x))
                {
                    return true;
                }
                seen.Add(x);
            }
            return false;
        }
    }