
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8080;
            IPAddress iPAddress = IPAddress.Any;

            TcpListener server = new TcpListener(iPAddress, port);
            server.Start();

            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client Connected");

            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
            StreamReader reader = new StreamReader(stream);

            string serverMessage = "Hello, Client";
            writer.WriteLine(serverMessage);
            writer.Flush();
            Console.WriteLine("Message was sent to client: " + serverMessage);

            string clientMessage;
            clientMessage = reader.ReadLine();
            Console.WriteLine("Client's message: " + clientMessage);
            writer.WriteLine("Message received: " + clientMessage);



            Console.ReadLine();
            client.Close();
            server.Stop();
        }
    }
}
