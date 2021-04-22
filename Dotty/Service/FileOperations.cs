using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dotty.Service
{
    public class FileOperations
    {
        public FileOperations()
        {
            FilePath = @"C:\Work\Dotty\Dotty\input.txt";
        }

        public string FilePath { get; set; }
        public string[] ReadInputFile()
        {
            string[] fileOutput = null;
            if (File.Exists(FilePath))
            {
                fileOutput = File.ReadAllLines(FilePath);


            }
            return fileOutput;
        }
    }
}
