using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTSCIgnoreErrors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }
            string tsConfigPath = args[0];
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.CreateNoWindow = true;
            info.FileName = "tsc";
            info.Arguments = $"--project \"{tsConfigPath}\"";
            var process = Process.Start(info);
            process.WaitForExit();
            Environment.Exit(0);
        }
    }
}
