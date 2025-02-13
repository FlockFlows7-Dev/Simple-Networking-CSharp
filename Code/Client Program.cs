using System;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverAddress = "127.0.0.1"; 
            int port = 8080;

            try 
            {
                TcpClient client = new TcpClient(serverAddress, port);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
                StreamReader reader = new StreamReader(stream);

                string serverMessage = reader.ReadLine();
                Console.WriteLine("Message from server: " + serverMessage);


                Console.Write("Enter message: ");
                string clientMessage = Console.ReadLine();
                writer.Flush();
                writer.WriteLine(clientMessage);

                Console.ReadLine();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
