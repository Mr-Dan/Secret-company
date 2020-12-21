using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Collections;

namespace ServerTest
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        static string readData;
        int player;
        public Form1()
        {
            InitializeComponent();
            ChatBoxAll.ReadOnly = true;
            whisper.ReadOnly = true;
            ID.Text = IDCode();
            online_box.Visible = false;
            Connect_box.Visible = false;
            lk_Box.Visible = false;
        }

        private void Connect_Click(object sender, EventArgs e)
        {


            try
            {
                readData = "Conected to Chat Server ...";
                msg();
                clientSocket.Connect(IPAddress.Parse(IP.Text), Int32.Parse(Port.Text));
                serverStream = clientSocket.GetStream();

                string Message = "ID"+ID.Text + " " + name.Text + "$";
                int Messagesize = Message.Length;
                byte[] outStream = new byte[Messagesize];

                outStream = Encoding.UTF8.GetBytes(Message);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
  
                Thread ctThread = new Thread(getMessage);
                ctThread.Start();


                label1.Text = ID.Text + name.Text;
                Connect.Enabled = false;
                IP.ReadOnly = true;
                Port.ReadOnly = true;
                name.ReadOnly = true;
                ID.ReadOnly = true;

              /*  IDRoom.ReadOnly = true;
                buttonIDRoom.Enabled = false;*/

            }
            catch (Exception ex)
            {
                if (clientSocket == null)
                    clientSocket.Close();

                if (clientSocket.Connected == false)  
                    MessageBox.Show("Сервер не работает ", "Ошибка", MessageBoxButtons.OK);
                Connect.Enabled = true;
                //if (serverStream == null) serverStream.Close();
                label1.Text = name.Text;
                Connect.Enabled = true;
                IP.ReadOnly = false;
                Port.ReadOnly = false;
                name.ReadOnly = false;
                ID.ReadOnly = false;
              /*  IDRoom.ReadOnly = false;
                buttonIDRoom.Enabled = true;*/

            }

        }

        private void getMessage()
        {
            try
            {
                while (true)
                {
                    serverStream = clientSocket.GetStream();
                    int buffSize = 0;
                    byte[] inStream = new byte[8001];
                    //  buffSize = clientSocket.ReceiveBufferSize;
                    buffSize = 8000;                   
                    serverStream.Read(inStream, 0, buffSize);
                    string returndata = Encoding.UTF8.GetString(inStream);
                    readData = "" + returndata;
                    msg();

                }
            }
            catch
            {
                
                clientSocket.Close();
                serverStream.Close();
                
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(msg));

            }
            else if (readData.IndexOf("/") == -1)
            {
                ChatBoxAll.Text = ChatBoxAll.Text + Environment.NewLine + readData;
                

            }

            else if(readData.IndexOf("/") > -1)
            {

                onlinelook(); ;
            }

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string whispertext = whisper.Text.ToString() ;


           if (whispertext.Length >0)
            {
                string Message =  whispertext + "@" + SendBoxAll.Text + "*";
                int Messagesize = Message.Length;
                byte[] outStream = new byte[Messagesize];
                outStream = Encoding.UTF8.GetBytes(Message);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                SendBoxAll.Clear();
            }
            if (whispertext.Length == 0)
           {

            string Message = SendBoxAll.Text + "$";
            int Messagesize = Message.Length;
            byte[] outStream = new byte[Messagesize];
            outStream = Encoding.UTF8.GetBytes(Message);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            SendBoxAll.Clear();
            }

        }

       
        private string IDCode()
        {
            string Code = null;
         
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                int rndNumber = rnd.Next(0, 9);
                Code = Code + rndNumber;
            }

            return Code;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverStream != null && clientSocket.Connected == true)
            {
                byte[] outStream = Encoding.UTF8.GetBytes("Вышел из чата " + "^");
                serverStream.Write(outStream, 0, outStream.Length);
            }

            if (clientSocket.Connected == false) clientSocket.Close();
            if (serverStream != null) serverStream.Close();
        }

      

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ChatBoxAll.SelectionStart = ChatBoxAll.Text.Length;
            ChatBoxAll.ScrollToCaret();
            ChatBoxAll.Refresh();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
             
             if ( e.KeyCode == Keys.Enter )
            {
                string Message = SendBoxAll.Text + "$";
                int Messagesize = Message.Length;
                byte[] outStream = new byte[Messagesize];
                outStream = Encoding.UTF8.GetBytes(Message);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                SendBoxAll.Clear();
            }

        }

     
        private void lk_Click(object sender, EventArgs e)
        {
            #region lk
                /*if (lk_Box.Visible == false)
               {


                  if (Connect_box.Visible == true)
                   {
                       if (online_box.Visible == true)
                       {
                           ChatBoxAll.Size = new Size(200, 342);
                           lk_Box.Visible = true;
                           lk_Box.Location = new Point(214, 37);

                           ChatBoxAll.Size = new Size(200, 342);
                           Connect_box.Visible = true;
                           Connect_box.Location = new Point(218, 124);
                       }
                       else
                       {

                           ChatBoxAll.Size = new Size(336, 342);
                           lk_Box.Location = new Point(356, 149);
                           lk_Box.Visible = true;
                       }

                   }
                   else
                   {
                       if (online_box.Visible == true)
                       {
                           ChatBoxAll.Size = new Size(200, 342);
                           lk_Box.Visible = true;
                           lk_Box.Location = new Point(214, 37);

                       }
                       else
                       {

                           ChatBoxAll.Size = new Size(336, 342);
                           lk_Box.Location = new Point(356, 149);
                           lk_Box.Visible = true;
                       }

                   }

               }
               else
               {
                   lk_Box.Visible = false;
                   ChatBoxAll.Size = new Size(486, 342);
               }*/
                #endregion
            if (lk_Box.Visible == false)
                {
                online_box.Visible = false;
                Connect_box.Visible = false;

                ChatBoxAll.Size = new Size(336, 342);
                lk_Box.Location = new Point(356, 149);
                lk_Box.Visible = true;
            }

            else
            {
                lk_Box.Visible = false;
                ChatBoxAll.Size = new Size(486, 342);
            }
            
        }

        private void DataConnect_Click(object sender, EventArgs e)
        {

            #region kaskad
            //  218; 124 кон
            //  357; 275  нач
            /*  if (Connect_box.Visible == false)
              {

                  if (lk_Box.Visible== true)
                  {
                      if (online_box.Visible == true)
                      {
                          ChatBoxAll.Size = new Size(200, 342);
                          Connect_box.Visible = true;
                          Connect_box.Location = new Point(218, 124);
                      }
                      else
                      {

                          ChatBoxAll.Size = new Size(336, 342);
                          Connect_box.Location = new Point(357, 275);
                          Connect_box.Visible = true;
                      }

                  }
                  else
                  {
                      if (online_box.Visible == true)
                      {
                      ChatBoxAll.Size = new Size(200, 342);
                      Connect_box.Visible = true;
                      Connect_box.Location = new Point(214, 37);

                       }
                        else
                      {

                      ChatBoxAll.Size = new Size(336, 342);
                      Connect_box.Location = new Point(357, 275);
                      Connect_box.Visible = true;
                        }

                  }


              }
              else
              {
                  Connect_box.Visible = false;
                  ChatBoxAll.Size = new Size(486, 342);
              }*/
            #endregion
            if (Connect_box.Visible == false)
                {

                online_box.Visible = false;
                lk_Box.Visible = false;

                ChatBoxAll.Size = new Size(336, 342);
                Connect_box.Location = new Point(357, 275);
                Connect_box.Visible = true;
            }
            else
            {
                Connect_box.Visible = false;
                ChatBoxAll.Size = new Size(486, 342);
            }
        }

        private void online_Click(object sender, EventArgs e)
        {

            if (online_box.Visible == false)
            {
                Connect_box.Visible = false;
                lk_Box.Visible = false;

                ChatBoxAll.Size = new Size(336, 342);
                online_box.Visible = true;            
            }
            else
            {
                online_box.Visible = false;
                ChatBoxAll.Size = new Size(486, 342);
            }
        }

        private void onlinelook()
        {
             player = 0;

            char[] textchar;
            string name;
            string[] AllName = new string[10];
            textchar = readData.ToCharArray();

            if (textchar[0] == '/')
            {
                string Newname = new string(textchar);
                Newname = Newname.Remove(0, 1);
                name = Newname;
                for (int j = 0; j < 10; j++)
                {
                    int LastIndex = name.IndexOf("|");

                    if (LastIndex > 0)
                    {
                        AllName[player] = name.Substring(0, LastIndex);


                        name = name.Remove(0, LastIndex + 1);

                        player++;
                    }

                }

              
                    AddOnlineInBox(player, AllName);

                  Array.Clear(AllName, 0, AllName.Length);
            }
              
        }


        private void AddOnlineInBox(int countOnline, string[] name)
        {
            
            int h = 0;
         

            int c = online_box.Controls.Count;

            for (int i = c - 1; i >= 0; i--)  online_box.Controls.Remove(online_box.Controls[i]);

            for (int i = 0; i < countOnline; i++)
                {
                    Button button = new Button(); 
                    button.Width = 117; 
                    button.Height = 23;          
                    button.Left = 19 ;
                    button.Top = 26 + h;
                    button.Name = name[i];
                    button.Text = name[i];
                    button.BackColor = Color.White;
                    button.Click += ButtonOnClick;
                    online_box.Controls.Add(button);
                    h += 30;
                }
          
            Array.Clear(name, 0, name.Length);
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;

            if (button != null)
            {
                whisper.Text = button.Name;
              // MessageBox.Show("тут чат " + button.Name);
              // button.Dispose(); удаление


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            whisper.Clear();
        }
    }
}
