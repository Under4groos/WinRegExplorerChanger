using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinRegExplorerChanger.Extension;

namespace WinRegExplorerChanger
{
    public class WinRegistry : IDisposable
    {
        // Компьютер\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons
        RegistryKey CurOpenRegKey;
        RegistryKey LocalMachine = Registry.LocalMachine;

        public string RegPath
        {
            get;set;
        }
        public WinRegistry(string _RegPath = null)
        {
            if (_RegPath == null)
            {
                RegPath = string.Empty;
                return;
            }
               
            RegPath = _RegPath;

            try
            {
                CurOpenRegKey = LocalMachine.OpenSubKey(RegPath);



            }
            catch
            {

            }
        }

        public string GetValue( string name )
        {
            if(string.IsNullOrEmpty(RegPath))
                return string.Empty;
            return this.CurOpenRegKey.GetStringKey(name);
        }


        public void SetValue(string? name, string value)
        {
            if (string.IsNullOrEmpty(RegPath))
                return;
            this.CurOpenRegKey.SetValue(name , value);
        }

        



        public void Dispose()
        {
            if(CurOpenRegKey != null)
                CurOpenRegKey.Dispose();
        }



        
    }
}
