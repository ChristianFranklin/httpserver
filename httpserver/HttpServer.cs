using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    public class HttpServer
    {
        public static readonly int DefaultPort = 8888;
        private TcpClient _connectionSocket;


        public HttpServer(TcpClient connectionSocket)
        {

            const string rn = "\r\n";

            //Socket connectionSocket = serverSocket.AcceptSocket();
            Console.WriteLine("Connected: {0}");

            Stream ns = connectionSocket.GetStream();
            // Stream ns = new NetworkStream(connectionSocket);

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing


            



            string message = sr.ReadLine();
            message.Split(' ');




            //request
            Console.WriteLine("Client: " + message);
            message = sr.ReadLine();
            Console.WriteLine(message);
            //response
            string answer = "HTTP/1.0 200 OK\r\n\r\nHello Payam!" + rn + "Hello Christian!";
            sw.WriteLine(answer);
            Console.WriteLine(answer);

            ns.Close();
            connectionSocket.Close();

        }

        

    }
    }