using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string[] fileName = filePath.Split('\\');

            FileHandler fileHandler = new FileHandler(fileName[fileName.Length - 1], filePath, FileAccessEnum.Read | FileAccessEnum.Write);

            fileHandler.Read(filePath);
            fileHandler.Write(filePath);
            fileHandler.ReadWrite(filePath);
        }

    }
}
