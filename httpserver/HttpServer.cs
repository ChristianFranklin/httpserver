using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    public class HttpServer
    {
        public static readonly int DefaultPort = 8888;
        public TcpClient _connectionSocket;
        private static readonly string RootCatalog = "C:/Users/Christian Eriksen/Desktop/open.html";
        private FileStream fs;


        const string rn = "\r\n";

            
        public HttpServer(TcpClient _konnectionSocket)
        {
            _connectionSocket = _konnectionSocket;
        }
        public void connection()
            {
            NetworkStream ns = _connectionSocket.GetStream();

        public HttpServer(TcpClient connectionSocket)
        {

            const string rn = "\r\n";

            Console.WriteLine("Connected: {0}");

            NetworkStream ns = connectionSocket.GetStream();
            

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; 

            string[] sArray = new string[3];

            string message = sr.ReadLine();
            sArray = message.Split(' ');
            Console.WriteLine(sArray.GetValue(1));
            findfil(sArray.GetValue(1).ToString(), ns);

            Console.WriteLine("Client: " + message);
            message = sr.ReadLine();
            Console.WriteLine(message);

        
            using (fs = File.OpenRead(RootCatalog))
            {

            string answer = "HTTP/1.0 200 OK\r\n\r\nHello Payam!" + rn + "Hello Christian!";
                sw.WriteLine(answer);
                Console.WriteLine(answer);

                fs.CopyTo(sw.BaseStream);
                sw.BaseStream.Flush();
                sw.Flush();
            }

                ns.Close();
                _connectionSocket.Close();
            }
        


            ns.Close();
            connectionSocket.Close();
        }


        public void findfil(string filnavn, NetworkStream network)
    {
        if (File.Exists(RootCatalog + filnavn))

        {

            if (File.Exists(RootCatalog + filnavn))
            {
                FileStream fs = File.OpenRead(RootCatalog + filnavn);
                fs.CopyTo(network);
            }
                
        }

            FileStream fs = File.OpenRead(RootCatalog + filnavn);
            fs.CopyTo(network);
        }
           

    }
   }
 }
