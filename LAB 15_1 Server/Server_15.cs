using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LAB_15_1_Server
{
    internal class Server_15
    {
        private const int Port = 5000;
        private const int BufferSize = 4096;

        static void Main()
        {
            Socket serverSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, Port);

            try
            {
                serverSocket.Bind(endPoint);
                serverSocket.Listen(10);

                Console.WriteLine($"Сервер запущен на порту {Port}");
                Console.WriteLine("Ожидание подключения клиента...");

                Socket clientSocket = serverSocket.Accept();
                Console.WriteLine("Клиент подключился.");

                string fileName = ReceiveString(clientSocket);
                long fileSize = ReceiveLong(clientSocket);

                string saveDirectory = "ReceivedFiles";

                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                string savePath = Path.Combine(saveDirectory, fileName);

                ReceiveFile(clientSocket, savePath, fileSize);

                Console.WriteLine($"Файл успешно получен: {savePath}");
                Console.WriteLine($"Размер файла: {fileSize} байт");

                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка сервера:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                serverSocket.Close();
            }
        }

        static string ReceiveString(Socket socket)
        {
            byte[] lengthBuffer = new byte[4];
            ReceiveAll(socket, lengthBuffer, 4);

            int length = BitConverter.ToInt32(lengthBuffer, 0);

            byte[] stringBuffer = new byte[length];
            ReceiveAll(socket, stringBuffer, length);

            return Encoding.UTF8.GetString(stringBuffer);
        }

        static long ReceiveLong(Socket socket)
        {
            byte[] buffer = new byte[8];
            ReceiveAll(socket, buffer, 8);

            return BitConverter.ToInt64(buffer, 0);
        }

        static void ReceiveFile(Socket socket, string filePath, long fileSize)
        {
            byte[] buffer = new byte[BufferSize];
            long totalReceived = 0;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                while (totalReceived < fileSize)
                {
                    int bytesToReceive = (int)Math.Min(BufferSize, fileSize - totalReceived);
                    int received = socket.Receive(buffer, 0, bytesToReceive, SocketFlags.None);

                    if (received == 0)
                    {
                        throw new Exception("Соединение было закрыто до завершения передачи файла.");
                    }

                    fileStream.Write(buffer, 0, received);
                    totalReceived += received;
                }
            }
        }

        static void ReceiveAll(Socket socket, byte[] buffer, int size)
        {
            int receivedTotal = 0;

            while (receivedTotal < size)
            {
                int received = socket.Receive(buffer, receivedTotal, size - receivedTotal, SocketFlags.None);

                if (received == 0)
                {
                    throw new Exception("Соединение закрыто.");
                }

                receivedTotal += received;
            }
        }
    }
}
