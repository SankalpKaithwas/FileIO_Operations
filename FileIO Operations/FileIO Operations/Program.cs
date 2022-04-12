namespace FileIO_Operations
{
    public class Program
    {
        public void FileExistOrNot()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exist");
            }
            else Console.WriteLine("File does not exist");

            //FileInfo fileInfo = new FileInfo(path);
            //Console.WriteLine(fileInfo.Exists);
        }
        //Read all text
        public void ReadAllTextUsingMethod()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            string result = File.ReadAllText(path); // opens and reads text from file into a string
            Console.WriteLine(result);

        }
        //read all lines
        public void ReadAllLinesUsingMethod()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            string[] result = File.ReadAllLines(path);
            foreach (var item in result)
                Console.WriteLine(item);
        }

        //read all bytes
        public void ReadAllBytes()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\BinarySerialization.txt";
            byte[] result = File.ReadAllBytes(path);
            foreach (var item in result)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        public void CopyAFile()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile1.txt";
            string copyTo = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            File.Copy(path, copyTo);
            Console.WriteLine("File Copied");

        }

        public void DeleteAFile()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            File.Delete(path);
            Console.WriteLine("File deleted " + path);
            //FileInfo fileInfo = new FileInfo(path);
            //fileInfo.Delete();
        }

        private void AppendAllText()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            string text = "Wierd things hapen around the world everytime";
            File.AppendAllText(path, text);
        }
        public void AppendAllLines()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            string[] words = { "What do you mean by this", "Somethig wonderfull", "i am feeling good" };
            File.AppendAllLines(path, words);
        }

        //write all text
        public void WriteAllText()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            string contents = "I am learning C#";
            File.WriteAllText(path, contents);
        }
        //Write all lines
        public void WriteAllLines()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            string[] lines = { "One", "Two", "Three" };
            File.WriteAllLines(path, lines);
        }

        // creation time of File
        public void GetCreationTimeOfFile()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            DateTime time = File.GetCreationTime(path);
            Console.WriteLine(time);
        }

        public void FileINFO()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            FileInfo info = new FileInfo(path);
            Console.WriteLine(info);
            DateTime lastAcces = info.LastAccessTimeUtc;
            Console.WriteLine("Last accessed - " + lastAcces);
        }
        public void GetFileExtension()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            FileInfo file = new FileInfo(path);
            string fileExtension = file.Extension;
            Console.WriteLine(fileExtension);
        }

        public void DirectoryName()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            FileInfo fileInfo = new FileInfo(path);
            string? directory = fileInfo.DirectoryName;
            Console.WriteLine("Directory: " + directory);
        }
        public void FileLength()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txt";
            FileInfo fileInfo = new FileInfo(path);
            long length = fileInfo.Length;
            Console.WriteLine("File length in bytes - " + length);
        }

        public void CreateDirectory()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\CreateDirectory";
            Directory.CreateDirectory(path);
        }
        public void DeleteDirectory()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\TextFile2.txty";
            Directory.Delete(path, true);
        }
        public void DirectoryExist()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\NewDirectory";
            bool check = Directory.Exists(path);
            Console.WriteLine(check);
        }
        public void GEtDirectories()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\";
            string[] directories = Directory.GetDirectories(path);
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }
        }
        public void GetFiles()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\";
            string[] getFiles = Directory.GetFiles(path);
            foreach (var item in getFiles)
            {
                Console.WriteLine(item);
            }
        }

        public void DirectoryInfo()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\";
            DirectoryInfo info = new DirectoryInfo(path);
            Console.WriteLine(info);
        }
        public void CreateDirectoryAtPath()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\CreateDirectory";
            DirectoryInfo info = new DirectoryInfo(path);
            info.Create();
        }

        public void DeleteDirectoryUsingDirectoryInfo()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\FileIO Operations\CreateDirectory";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo.Delete();
        }

        public void GetDirectories()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }
        }

        public void GetFilesInDirectory()
        {
            string path = @"F:\FRP .net Git\FileIO_Operations\";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] info = directoryInfo.GetFiles();
            foreach (var item in info)
                Console.WriteLine(item);
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            int input;
            do
            {
                Console.WriteLine("Choose 1: Check file exist");
                Console.WriteLine("Choose 2: Read all lines");
                Console.WriteLine("Choose 3: Read all text");
                Console.WriteLine("Choose 4: Copy a file");
                Console.WriteLine("Choose 5: Delete");
                Console.WriteLine("Choose 6: Append all text");
                Console.WriteLine("Choose 7: Read all bytes");
                Console.WriteLine("Choose 8: Write all text");
                Console.WriteLine("Choose 9: Write all Lines");
                Console.WriteLine("Choose 10: Append All lines");
                Console.WriteLine("Choose 11: Get File Creation time");
                Console.WriteLine("Choose 12: File info");
                Console.WriteLine("Choose 13: Directory name");
                Console.WriteLine("Choose 14: File extension");
                Console.WriteLine("Choose 15: File Length");
                Console.WriteLine("Choose 16: Create Directory");
                Console.WriteLine("Choose 17: Delete Directory");
                Console.WriteLine("Choose 18: Check Directory exist or not");
                Console.WriteLine("Choose 19: Get Directories");
                Console.WriteLine("Choose 20: Get Files");
                Console.WriteLine("Choose 21: Get Directory Info");
                Console.WriteLine("Choose 22: Create Directory at path");
                Console.WriteLine("Choose 0: Exit");
                string? choice = Console.ReadLine();
                input = Convert.ToInt32(choice);
                switch (input)
                {
                    case 1:
                        program.FileExistOrNot();
                        break;
                    case 2:
                        program.ReadAllLinesUsingMethod();
                        break;
                    case 3:
                        program.ReadAllTextUsingMethod();
                        break;
                    case 4:
                        program.CopyAFile();
                        break;
                    case 5:
                        program.DeleteAFile();
                        break;
                    case 6:
                        program.AppendAllText();
                        break;
                    case 7:
                        program.ReadAllBytes();
                        break;
                    case 8:
                        program.WriteAllText();
                        break;
                    case 9:
                        program.WriteAllLines();
                        break;
                    case 10:
                        program.AppendAllLines();
                        break;
                    case 11:
                        program.GetCreationTimeOfFile();
                        break;
                    case 12:
                        program.FileINFO();
                        break;
                    case 13:
                        program.DirectoryName();
                        break;
                    case 14:
                        program.GetFileExtension();
                        break;
                    case 15:
                        program.FileLength();
                        break;
                    case 16:
                        program.CreateDirectory();
                        break;
                    case 17:
                        program.DeleteDirectory();
                        break;
                    case 18:
                        program.DirectoryExist();
                        break;
                    case 19:
                        program.GEtDirectories();
                        break;
                    case 20:
                        program.GetFiles();
                        break;
                    case 21:
                        program.DirectoryInfo();
                        break;
                    case 22:
                        program.CreateDirectoryAtPath();
                        break;
                }
            } while (input != 0);
        }
    }
}
