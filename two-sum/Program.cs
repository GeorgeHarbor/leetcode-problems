﻿// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
//
// You can return the answer in any order.
//
//
//
// Example 1:
//
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:
//
// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:
//
// Input: nums = [3,3], target = 6
// Output: [0,1]
//

int[] nums = [3, 2, 4];
var target = 6;

static int[] TwoSums(int[] nums, int target)
{
  for (var i = 0; i < nums.Length - 1; i++)
  {
    for (var j = i + 1; j < nums.Length; j++)
    {
      if (nums[i] + nums[j] == target)
      {
        return [i, j];
      }
    }
  }
  return [];
}
var result = TwoSums(nums, target);
Console.WriteLine(string.Join(", ", result));


static int[] TwoSums2(int[] nums, int target)
{
  var previousNumbers = new Dictionary<int, int>
  {
    [nums[0]] = 0
  };

  for (var i = 1; i < nums.Length; i++)
  {
    if (previousNumbers.ContainsKey(target - nums[i]))
    {
      return [previousNumbers[target - nums[i]], i];
    }

    previousNumbers[nums[i]] = i;
  }

  return [];
}


var result2 = TwoSums2(nums, target);
Console.WriteLine(string.Join(", ", result2));
