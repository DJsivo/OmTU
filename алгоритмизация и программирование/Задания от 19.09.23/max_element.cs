using System;
class Posledovatelnost {
  static void Main() {
      int a,b;
      a=Convert.ToInt32(Console.ReadLine());
      for (int i=1; i<=9; i++){
          b=Convert.ToInt32(Console.ReadLine());
          if (a<b) a=b;
      }
    Console.WriteLine(a);
  }
}
