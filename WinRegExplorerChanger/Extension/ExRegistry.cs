using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRegExplorerChanger.Extension
{
    public static class ExRegistry
    {
        public static string GetStringKey(this RegistryKey reg ,string? name )
        {
            if(reg.GetValue(name) is string str)
                return str;
            return "<error>";
        }
    }
}
