/*
 
 This solution is required to read multi languages like Chinese, Korean , Rissian , so On ....
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.Requirements_Logic
{
    public class MultiLanguageRead
    {
        public static void GetLanguageConverted()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string str = "ç²¾é¸ç å¯¶ä½?å?/é»?ké??";

            Encoding utf8 = new UTF8Encoding();
            Encoding windows1252 = Encoding.GetEncoding("Windows-1252");


            byte[] postBytes = windows1252.GetBytes(str);
            string actulaText = WebUtility.HtmlDecode(utf8.GetString(postBytes));

            Console.WriteLine(actulaText);
        }
    }
}
