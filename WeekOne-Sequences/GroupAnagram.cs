using System;
using System.Linq;
using System.Collections.Generic;

public class GroupAnagram
{
    /*
    Given an array of strings strs, group the anagrams together. 
    You can return the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters 
    of a different word or phrase, typically using all the original letters 
    exactly once.
        
    Example 1:
    
    Input: strs = ["eat","tea","tan","ate","nat","bat"]
    Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    Example 2:
    
    Input: strs = [""]
    Output: [[""]]
    Example 3:
    
    Input: strs = ["a"]
    Output: [["a"]]
    
    */
    public static void GroupAnagrams(string[] strs) 
    {
        int indexVal = 0;
        Dictionary<int, string> sortedWordsDict = new Dictionary<int, string>();
        // sort all the words to find matching pairs for anagrams and save the index to return the word. 
        foreach(var x in strs)
        {
            sortedWordsDict.Add(indexVal, string.Concat(x.OrderBy(x => x)));
            indexVal++;
        }
        //  foreach(KeyValuePair<int, string> ele1 in sortedWordsDict)
        //   {
        //       Console.WriteLine("{0} and {1}",
        //                 ele1.Key, ele1.Value);
        //   }

        for (var i = 0; i < strs.Length; i++)
        {
            for (var j = i + 1; j < strs.Length - 1; j++)
            {
                
            }
        }

    }

    // public static void Main(string[] args)
    // {
    //     string[] inputArray = {"eat","tea","tan","ate","nat","bat"};
    //     GroupAnagrams(inputArray);
        
    // }
}
