using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    class Program
    {
         public static void Main(string[] args)
     {  
        HttpListener serverSocket = new HttpListener(80);
        serverSocket.Start();

        Stream ns = connectionSocket.GetStream();
        // Stream ns = new NetworkStream(connectionSocket);

    
        StreamReader sr = new StreamReader(ns);
        StreamWriter sw = new StreamWriter(ns);
        
 
                   





        Console.WriteLine("Hello http server");
     }
        
           
        

         
    }

}
