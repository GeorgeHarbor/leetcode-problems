namespace roman_to_integer;

public static class Solution
{

  public static int RomanToInt(string s)
  {

    if (s.Length == 0) return 0;
    var number = 0;

    for (var i = 0; i < s.Length; i++)
    {

      var p1 = romanDict[s[i]];
      var p2 = i != s.Length - 1 ? romanDict[s[i + 1]] : 0;

      if (p2 > p1)
      {
        number += p2 - p1;
        i++;
      }
      else
      {
        number += p1;
      }

    }
    return number;
  }

  private static readonly Dictionary<char, int> romanDict = new() {
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000},
  };

}

public class Program
{
  static void Main()
  {
    Console.WriteLine(Solution.RomanToInt("MCMXCIV"));
  }
}
