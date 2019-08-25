﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

using System.IO;namespace AKB.NET_WebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Ali Kadir BAGCIOGLU");

                                           // yeni sürümde WebDev.WebServer.exe nin yolu değişmiş 
            string str = Path.Combine("C:\\Program Files\\Common Files\\microsoft shared\\DevServer\\9.0", "WebDev.WebServer.exe");
            string str2 = string.Empty;
            Random random = new Random();
            string str3 = random.Next(1024, 9000).ToString();
            if (args.Length == 1)
            {
                string str4 = args[0];
                str2 = str2 + " /path:\"" + str4 + "\" /port:" + str3 + " /vpath: \"/" + str4.Substring(str4.LastIndexOf('\\') + 1) + "\"";
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Arguments = str2;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = str;
                startInfo.UseShellExecute = false;
                startInfo.WorkingDirectory = str.Substring(0, str.LastIndexOf('\\'));
                Process.Start(startInfo);
                using (Control control = new Control())
                {
                    Help.ShowHelp(control, "http://localhost:" + str3 + "/");
                }
            }

        }
    }
}
