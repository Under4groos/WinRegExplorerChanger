
using WinRegExplorerChanger;

using (WinRegistry reg  = new WinRegistry("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Icons"))
{
    string var_3 = reg.GetValue("3");
    Console.WriteLine(var_3);
}

Console.ReadLine();