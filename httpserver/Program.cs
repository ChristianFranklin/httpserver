using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using httpserver;

namespace httpserver
{
    class Program
    {
        public static TcpClient TcpClient;
        private static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(8080);
            serverSocket.Start();

            while (true)
            {
                TcpClient tcpConnection = serverSocket.AcceptTcpClient();

                Console.WriteLine("Server STARTED");
                
                Task.Factory.StartNew(() =>
                {
                        HttpServer httpServer = new HttpServer(tcpConnection);
                    httpServer._connectionSocket.GetStream();
                        tcpConnection.Close();
                });
            }

        }
        }

        
    }

