using System;
class Posledovatelnost {
  static void Main() {
      int a, k=0;
      for (int i=1; i<=9; i++){
        a=Convert.ToInt32(Console.ReadLine());  
        if (a < 0) k=k+1;
      }
    Console.WriteLine(k);
  }
}
