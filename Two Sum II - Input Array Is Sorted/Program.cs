using System;
using System.Collections.Generic;

namespace Two_Sum_II___Input_Array_Is_Sorted
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // [2,7,11,15], target = 9
    }
  }

  public class Solution
  {
    public int[] TwoSum(int[] numbers, int target)
    {
      // as the array is already sorted and we need to find the pair which sum equal to target
      // we can use the approach of binary search here
      // take two pointer l and r, and calculat sum, if sum < target, we need to increase l++ as its sorted in asc
      // if sum > target, we need to decrement from right r--, as the array is sorted and we need lesser no to reach near or equal to target , so l++.
      // at any time we found the sum == target, we add the indexes in result and return.
      int l = 0, r = numbers.Length - 1;
      List<int> result = new List<int>();
      while (l < r)
      {
        int sum = numbers[l] + numbers[r];
        if (sum == target)
        {
          result.Add(l + 1);
          result.Add(r + 1);
          l++;
          r--;
          return result.ToArray();// as the question said there will be only one answer
        }
        else if (sum < target)
        {
          l++;
        }
        else
        {
          r--;
        }
      }

      return result.ToArray();
    }
  }
}
