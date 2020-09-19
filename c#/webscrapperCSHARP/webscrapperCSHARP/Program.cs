using System;
using System.Net;
using System.Net.Http;  // in LINQPad, also add a reference to System.Net.Http.dll

namespace webscrapperCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Char[] html = new System.Net.WebClient().DownloadString("view-source:https://www.google.com/search?q=ftse+100&rlz=1C1GCEA_enGB820GB820&oq=ftse&aqs=chrome.1.69i57j0l7.2453j0j8&sourceid=chrome&ie=UTF-8").ToCharArray();
            for(int i= 0; i<html.Length; i++)
            {
                Console.Write(html[i]);
               
            }
            Console.ReadLine();
            //string targetValue = "5,965.77";
            //char one = 5;


            //for(int i=0; i < html.Length; i++)
            //{
            //    if(i== "5")
            //}



        }
    }
}
