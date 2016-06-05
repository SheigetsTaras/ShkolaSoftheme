using System;
using System.IO;


namespace Task1
{


    [Flags]
    enum FileAccessEnum : short
    {
        Read = 1,
        Write = 2
    }
    struct FileHandler
    {
        int FileSize;
        string FileName;
        string FilePath;
        FileAccessEnum Access;

        public FileHandler(string FileName, string FilePath, FileAccessEnum Access)
        {
            this.FilePath = FilePath;
            this.FileName = FileName;
            this.FileSize = 0;
            this.Access = Access;
        }

        public void Read(string filePuth)
        {
            using (FileStream fileStream = new FileStream(filePuth, FileMode.OpenOrCreate, (FileAccess)FileAccessEnum.Read))
            {
                Console.WriteLine("File open for read");
            }

        }

        public void Write(string filePuth)
        {
            using (FileStream fileStream = new FileStream(filePuth, FileMode.OpenOrCreate, (FileAccess)FileAccessEnum.Write))
            {
                Console.WriteLine("File open for write");
            }

        }

        public void ReadWrite(string filePuth)
        {
            using (FileStream fileStream = new FileStream(filePuth, FileMode.OpenOrCreate, (FileAccess)FileAccessEnum.Read | (FileAccess)FileAccessEnum.Write))
            {
                Console.WriteLine("File open for read or write");
            }

        }


    }
}
