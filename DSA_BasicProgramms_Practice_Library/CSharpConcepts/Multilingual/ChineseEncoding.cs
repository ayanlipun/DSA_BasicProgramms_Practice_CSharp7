using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Multilingual
{
    public static class ChineseEncoding
    {
        public static void Index()
        {
            // Unicode string containing Chinese characters
            string unicodeString = "\u4F60\u597D\u4E16\u754C"; // This represents "你好世界" in Unicode

            // Convert Unicode string to Chinese characters
            string chineseString = Encoding.Unicode.GetString(Encoding.Unicode.GetBytes(unicodeString));

            // Pass the converted string to the view
            Console.WriteLine(chineseString);
        }
    }
}
