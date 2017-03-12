using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.BusinessLayer
{
    public interface ITestClass
    {
        string GetName();
    }
   public class TestClass : ITestClass
   {
       public string GetName()
       {
           return "Kumar";
       }
   }
}
