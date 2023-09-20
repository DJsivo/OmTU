using System;
class Posledovatelnost{
  static void Main() {
      int a, k;
      a=Convert.ToInt32(Console.ReadLine());
      k=Math.Abs(a);
      for (int i=1; i<=9; i++){
        a=Convert.ToInt32(Console.ReadLine());  
        if (a > 0){
        if (a<k) k=a;
        }
      }
    Console.WriteLine(k);
  }
}
