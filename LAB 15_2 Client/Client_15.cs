using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LAB_15_2_Client
{
    internal class Client_15
    {
        private const string ServerIp = "127.0.0.1";
        private const int Port = 5000;
        private const int BufferSize = 4096;

        static void Main()
        {
            Console.Write("Введите путь к текстовому файлу: ");
            string filePath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            Socket clientSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            try
            {
                IPEndPoint serverEndPoint = new IPEndPoint(
                    IPAddress.Parse(ServerIp),
                    Port
                );

                clientSocket.Connect(serverEndPoint);
                Console.WriteLine("Подключение к серверу выполнено.");

                string fileName = Path.GetFileName(filePath);
                long fileSize = new FileInfo(filePath).Length;

                SendString(clientSocket, fileName);
                SendLong(clientSocket, fileSize);
                SendFile(clientSocket, filePath);

                Console.WriteLine("Файл успешно отправлен.");
                Console.WriteLine($"Имя файла: {fileName}");
                Console.WriteLine($"Размер файла: {fileSize} байт");

                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка клиента:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clientSocket.Close();
            }
        }

        static void SendString(Socket socket, string text)
        {
            byte[] stringBuffer = Encoding.UTF8.GetBytes(text);
            byte[] lengthBuffer = BitConverter.GetBytes(stringBuffer.Length);

            socket.Send(lengthBuffer);
            socket.Send(stringBuffer);
        }

        static void SendLong(Socket socket, long value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            socket.Send(buffer);
        }

        static void SendFile(Socket socket, string filePath)
        {
            byte[] buffer = new byte[BufferSize];

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int bytesRead;

                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    socket.Send(buffer, 0, bytesRead, SocketFlags.None);
                }
            }
        }
    }
}
