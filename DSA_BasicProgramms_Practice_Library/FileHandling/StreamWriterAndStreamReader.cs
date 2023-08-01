using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.FileHandling
{
    public class StreamWriterAndStreamReader
    {
        public static void ExecStreamWriterAndStreamReader()
        {
            // Stream Writer
            //ExecStreamWriter();
            //ExecStreamWriter1();
            ExecStreamReader();
        }

        public static void ExecStreamWriter()
        {
            StreamWriter streamWriter = new StreamWriter($"E://Logs//MyFile_{DateTime.Now.Minute.ToString()}.txt");
            Console.WriteLine("Enter the Text that you want to write on File");
            string inputData = Console.ReadLine();
            streamWriter.Write(inputData);
            Console.WriteLine("Data Has Been Written to the File");
            streamWriter.Flush();
            streamWriter.Close();
        }

        public static void ExecStreamWriter1()
        {
            string filePath = $"E://Logs//MyFile_{DateTime.Now.Minute.ToString()}.txt";

            int a, b, result;
            a = 15;
            b = 20;
            result = a + b;

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.Write($"Sum of {a} + {b} = {result}");
            }
            Console.WriteLine("Variable Data is Saved into the File");
        }
        public static void ExecStreamReader()
        {
            string filePath = $"E://Logs//MyFile_19.txt";

            StreamReader streamReader = new StreamReader(filePath);
            Console.WriteLine("Content of the File");

            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strData = streamReader.ReadLine();
            while (strData != null)
            {
                //Print the String data
                Console.WriteLine(strData);
                //Then Read the next String data
                strData = streamReader.ReadLine();
            }           
            //Close the streamReader Object
            streamReader.Close();
        }
    }
}
