using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\Samples\truhvel";
            //string[] dirs = Directory.GetDirectories(rootpath,"*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //var files = Directory.GetFiles(rootpath, ".", SearchOption.TopDirectoryOnly);

            //foreach (string file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);

            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            //}
            //string newpath = @"C:\Users\opilane\Samples\truhvel\juss";
            //Directory.CreateDirectory(newpath);
            //bool  Directoryexists = Directory.Exists(newpath);

            //if (Directoryexists)
            //{
            //    Console.WriteLine("The directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory doesnt exist");
            //    Directory.CreateDirectory(newpath);
            //}

            //string[] files = Directory.GetFiles(rootpath);
            //string destinationfolder = @"C:\Users\opilane\Samples\truhvel\SubfolderA";
            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationfolder}{Path.GetFileName(file)}", true);            
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationfolder}{ i }.txt", false);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationfolder}{Path.GetFileName(file)}");
            //}
            var files = Directory.GetFiles(rootpath, "*folder*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
                //var info = new FileInfo(file);

                //Console.WriteLine($"{Path.GetFileName(file) }: {info.Length} bytes");
            }

            Console.ReadLine();
        }
    }
}
