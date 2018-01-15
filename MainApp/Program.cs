﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter directoy you want to listen to, (absolute path)");
            string directory = Console.ReadLine();
            if (Directory.Exists(directory))
            {
                Console.WriteLine("It is a directory!");
                string LogPath = Console.ReadLine();
                DirectoryLogger directoryInfo = new DirectoryLogger(directory,LogPath);
                Console.WriteLine("You have chosen : "+directoryInfo.Path+" We are now listening to it!");
                
            }
            else
                Console.WriteLine("Invalid Path, exiting");
            
            Console.ReadLine();
        }

        
    }
}
