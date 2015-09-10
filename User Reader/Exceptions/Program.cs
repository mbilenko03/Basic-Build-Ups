using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        //code from which you are trying to catch an exception
      }
      catch (Exception variable)
      {
        //code to do if the exception is present
        //throw; lets the method who called the current method to deal with the exception.
      }
      finally
      {
        //code that always runs
      }

      
    }
  }
}
