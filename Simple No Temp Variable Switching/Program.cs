using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_No_Temp_Variable_Switching {
  class Program {
    static void Main(string[] args) {
      int x = 0, y = 0, choice = 0;
      char cont = ' ';
      do {
        Console.Clear();
        Console.WriteLine("Choose which operation to use: \n1) Addition and Subtraction\n2) Multiplication and Division\n3) XOR");
        choice = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter a value for x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for y: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("X = {0}, Y = {1}",x,y);


        if(choice == 1) {
          x = x + y;
          y = x - y;
          x = x - y;
          Console.WriteLine("Using Addition and Subtraction");
          Console.WriteLine("Now X = {0} and Y = {1}",x,y);
        } else if(choice == 2) {
          x = x * y;
          y = x / y;
          x = x / y;
          Console.WriteLine("Using Multiplication and Division");
          Console.WriteLine("Now X = {0} and Y = {1}",x,y);
        } else if(choice == 3) {
          x = x ^ y;
          y = x ^ y;
          x = x ^ y;
          Console.WriteLine("Using XOR");
          Console.WriteLine("Now X = {0} and Y = {1}",x,y);
        }
        Console.WriteLine("Want to do another? (y/n)");
        cont = char.Parse(Console.ReadLine());
      } while(cont != 'n');
    }
  }
}
