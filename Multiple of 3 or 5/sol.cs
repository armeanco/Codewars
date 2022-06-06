using System;

public static class Kata
{
  public static int Solution(int value)
  {
    int th = 0, fi = 0, un = 0;
    for(int i = 0; i < value; ++i) {
      if(i % 3 == 0 && i % 5 != 0) {
        th+=i;
      }
      if(i % 5 == 0 && i % 3 != 0) {
        fi+=i;
      }
      if(i % 5 == 0 && i % 3 == 0) {
        un+=i;
      }
    }
    if(value <= 3) return 0;
    return th+fi+un;
  }
}
