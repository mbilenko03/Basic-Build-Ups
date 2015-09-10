using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Reader
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter what term you want: ");
      string readTerm = Console.ReadLine();
      int useTerm = int.Parse(readTerm);
    }
  }
}
