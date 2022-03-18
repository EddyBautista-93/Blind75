using System.Collections.Generic;
using System;
using System.Linq;
public class IsAnagram
{
    /*
    Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    Example 1:

    Input: s = "anagram", t = "nagaram"
    Output: true
    Example 2:

    Input: s = "rat", t = "car"
    Output: false

    */
    public static bool isAnagram(string s, string t)
    {
        string firstSTR = String.Concat(s.OrderBy(c => c));
        string secondSTR = String.Concat(t.OrderBy(c => c));
        if (firstSTR == secondSTR)
            return true;

        return false;
    }

    // public static void Main(string[] args)
    // {
    //     string testString0 = "rat";
    //     string testString1 = "car";
    //     isAnagram(testString0, testString1);

    // }

}