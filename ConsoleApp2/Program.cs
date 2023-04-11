// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace writer
{

 class Filewriter
        {

            static void Main()
            {
                
                StreamWriter sw = new StreamWriter("C://Users//anjani devika//Documents//doc1.txt");
                Console.WriteLine("Enter the Text to write on File");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
            
            }
        }
   
}
