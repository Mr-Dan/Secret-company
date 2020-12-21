using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Collections;

namespace TestServerMain
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable();
        static NetworkStream networkStream;
        public static ICollection keys;
        public static string dataFromClient;
        public static string Name;
        static handleClinet client;

        static void Main(string[] args)
        {
             String ip;
             int port;
             bool NameCheck = false;

           /*  Console.Write("IP:");
             ip = Console.ReadLine();

             Console.Write("Port:");
             port = Convert.ToInt32(Console.ReadLine());
             TcpListener serverSocket = new TcpListener(IPAddress.Parse(ip), port);
              НУЖНО!*/
            
            TcpListener serverSocket = new TcpListener(IPAddress.Parse("192.168.0.66"), 368);
            TcpClient clientSocket = default(TcpClient); 

            serverSocket.Start();
            Console.WriteLine("Chat Server Started ....");

            try
            {
                while (true)
                {
                    NameCheck = false;
                    clientSocket = serverSocket.AcceptTcpClient();
                    byte[] bytesFrom = new byte[8000];
                    dataFromClient = null;
                    networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, 8000);
                    dataFromClient = Encoding.UTF8.GetString(bytesFrom);
                    
                    if (dataFromClient.IndexOf("$") == -1)
                    {
                        networkStream.Close();
                        clientSocket.Close();
                    }

                    else
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Name = dataFromClient + "$";
                        keys = clientsList.Keys;
                        foreach (string s in keys)
                        {
                            string y = s.Substring(0, 5);
                            string x = dataFromClient.Substring(0, 5);
                              if (y == x)
                              {   
                                
                                networkStream.Close();
                                clientSocket.Close();
                                Console.WriteLine("error");
                                NameCheck = true;
                                
                              }
                        }

                        if (NameCheck != true)
                        {
                            clientsList.Add(dataFromClient, clientSocket);
                            broadcast(dataFromClient + " Присоединился ", dataFromClient, false);
                            Console.WriteLine(dataFromClient + " Присоединился в чат ");
                            client = new handleClinet();
                            client.startClient(clientSocket, dataFromClient, clientsList);
                            clientsList = client.clientsList;
                            online();
                        }

                    }
                }
            }
            catch
            {
                networkStream.Close();
                clientSocket.Close();
            }
        }

        public static void TalkSendingMessagesToTalk(string msg, string uName, string myName)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                Object obj = new Object();
                obj = Item.Key;
                string s = obj.ToString();

                string sName = uName.Substring(0,5);
                string smyName = myName.Substring(0, 5);

                 if (s.IndexOf(sName) > -1 || s.IndexOf(smyName) > -1)
                 {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    Byte[] broadcastBytes = null;                                                
                    broadcastBytes = Encoding.UTF8.GetBytes(myName + " шепнул "+ uName+":" + msg);                                   
                    broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                    broadcastStream.Flush();
                    Array.Clear(broadcastBytes, 0, broadcastBytes.Length);
                 }
              
            }
        }

        public static void broadcast(string msg, string uName, bool flag)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(uName + " Сказал : " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(msg);

                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
                Array.Clear(broadcastBytes, 0, broadcastBytes.Length);
            }
        }

        public static void online()
        {
            string fulluName = null;

            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                foreach (string uName in keys) fulluName = fulluName + uName + "|";

                broadcastBytes = Encoding.UTF8.GetBytes("/" + fulluName);
                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
                Array.Clear(broadcastBytes, 0, broadcastBytes.Length);
                fulluName = null;
            }
        }


    }


    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        string namewhisper;

        public Hashtable clientsList;
        public static ICollection keys;

        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }



        public void doChat()
        {
            int countWords;
            byte[] bytesFrom = new byte[8000];
            string dataFromClient = null;
            NetworkStream networkStream = null;
            try
            {

                while (true)
                {
                    networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, 8000);
                    dataFromClient = Encoding.UTF8.GetString(bytesFrom);

                    int check;

                    if ((check = dataFromClient.IndexOf("$")) > 0)
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine("От клиента - " + clNo + " : " + dataFromClient);
                        Program.broadcast(dataFromClient, clNo, true);
                    }
                    

                    else if ((check = dataFromClient.IndexOf("^")) > 0)
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("^"));
                        Console.WriteLine("От клиента - " + clNo + " : " + dataFromClient);
                        Program.broadcast(dataFromClient, clNo, true);
                        networkStream.Close();
                        this.clientsList.Remove(clNo);
                        this.clientSocket.Close();
                        Program.online();
                    }

                    else if ((check = dataFromClient.IndexOf("*")) > 0)
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("*"));
                        namewhisper = dataFromClient.Substring(0, dataFromClient.IndexOf("@"));
                        countWords = dataFromClient.IndexOf("@");
                        dataFromClient= dataFromClient.Remove(0,countWords+1);
                        Console.WriteLine("От клиента - " + namewhisper + " : " + dataFromClient);
                        Program.TalkSendingMessagesToTalk(dataFromClient, namewhisper, clNo);                  
                    }
                    Array.Clear(bytesFrom, 0, bytesFrom.Length);
                }
            }
            catch
            {
                networkStream.Close();
                clientSocket.Close();
                clientsList.Remove(clNo);
                
            }
        }


    }




}
