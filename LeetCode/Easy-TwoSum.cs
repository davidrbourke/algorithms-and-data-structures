// https://leetcode.com/problems/two-sum/submissions/1520963863/

using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
    static void Main() {
        Console.WriteLine("Hello World!");
        
        //var result = TwoSum(new int[] {2, 7, 11, 15}, 9);
        //var result = TwoSum(new int[] {3, 2, 4}, 6);
        var result = TwoSum(new int[] {3, 3 }, 6);
        foreach(var s in result)
        {
            Console.WriteLine(s);
        }
    }
    
    public static int[] TwoSum(int[] nums, int target)
    {
        // Build search for hashset
        var lookup = new Dictionary<int, int>();
        for(var i = nums.Length -1; i >= 0; i--)
        {
            lookup.TryAdd(nums[i], i);
        }
        
        for(var i = 0; i < nums.Length; i++)
        {
            
            if (lookup.ContainsKey(diff))
            {
                var j = lookup[diff];
                if (j != i)
                {
                    return new int[] { i, j };
                }
            }
        }
        
        return new int[0];
        
    }
}