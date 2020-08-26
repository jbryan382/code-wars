using System;
using System.Collections.Generic;
using System.Linq;
  
public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
          return arr.Where((element, index) => index % 2 == 0).ToArray();
        }
    }
