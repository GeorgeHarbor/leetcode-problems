bool IsPalindrome(int num)
{
  int y = 0;
  int x = num;

  if (x < 0)
    return false;


  while (x > 0)
  {
    y *= 10;
    y += x % 10;
    x /= 10;
  }

  if (num == y)
    return true;

  return false;
}

System.Console.WriteLine(IsPalindrome(-121));
