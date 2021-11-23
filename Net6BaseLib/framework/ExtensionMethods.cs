using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseLib.framework;

public static class ExtensionMethods
{
    public static int WordCount(this string str)
    {
        return str.Length;
    }
}

