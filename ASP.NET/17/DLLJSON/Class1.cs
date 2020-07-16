using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DLLJSON
{
   
    public interface Interface1
    {
        int sub(int x, int y);
        int add(int x, int y);

    }
  
    public class Class1 : Interface1
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }

    }

}
