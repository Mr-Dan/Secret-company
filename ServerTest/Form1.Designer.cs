namespace ServerTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.SendBoxAll = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChatBoxAll = new System.Windows.Forms.RichTextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.online_box = new System.Windows.Forms.GroupBox();
            this.online = new System.Windows.Forms.Button();
            this.Connect_box = new System.Windows.Forms.GroupBox();
            this.lk = new System.Windows.Forms.Button();
            this.lk_Box = new System.Windows.Forms.GroupBox();
            this.DataConnect = new System.Windows.Forms.Button();
            this.whisper = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Connect_box.SuspendLayout();
            this.lk_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(6, 19);
            this.IP.MaxLength = 14;
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 20);
            this.IP.TabIndex = 0;
            this.IP.Text = "188.233.77.154";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(6, 52);
            this.Port.MaxLength = 4;
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 1;
            this.Port.Text = "368";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(6, 78);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(117, 20);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Подключиться";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send
            // 
            this.Send.Image = global::ServerTest.Properties.Resources.Send;
            this.Send.Location = new System.Drawing.Point(504, 425);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(37, 30);
            this.Send.TabIndex = 4;
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // SendBoxAll
            // 
            this.SendBoxAll.Location = new System.Drawing.Point(12, 412);
            this.SendBoxAll.MaxLength = 8000;
            this.SendBoxAll.Multiline = true;
            this.SendBoxAll.Name = "SendBoxAll";
            this.SendBoxAll.Size = new System.Drawing.Size(486, 47);
            this.SendBoxAll.TabIndex = 5;
            this.SendBoxAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 7;
            this.name.Text = "Dan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "имя";
            // 
            // ChatBoxAll
            // 
            this.ChatBoxAll.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChatBoxAll.Location = new System.Drawing.Point(12, 41);
            this.ChatBoxAll.Name = "ChatBoxAll";
            this.ChatBoxAll.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatBoxAll.Size = new System.Drawing.Size(486, 343);
            this.ChatBoxAll.TabIndex = 15;
            this.ChatBoxAll.Text = "";
            this.ChatBoxAll.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(6, 48);
            this.ID.MaxLength = 3;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID ";
            // 
            // online_box
            // 
            this.online_box.BackColor = System.Drawing.SystemColors.Info;
            this.online_box.Location = new System.Drawing.Point(356, 37);
            this.online_box.Name = "online_box";
            this.online_box.Size = new System.Drawing.Size(142, 244);
            this.online_box.TabIndex = 20;
            this.online_box.TabStop = false;
            // 
            // online
            // 
            this.online.Location = new System.Drawing.Point(504, 41);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(57, 39);
            this.online.TabIndex = 21;
            this.online.Text = "Онлайн";
            this.online.UseVisualStyleBackColor = true;
            this.online.Click += new System.EventHandler(this.online_Click);
            // 
            // Connect_box
            // 
            this.Connect_box.BackColor = System.Drawing.SystemColors.Info;
            this.Connect_box.Controls.Add(this.IP);
            this.Connect_box.Controls.Add(this.label2);
            this.Connect_box.Controls.Add(this.Port);
            this.Connect_box.Controls.Add(this.label3);
            this.Connect_box.Controls.Add(this.Connect);
            this.Connect_box.Location = new System.Drawing.Point(357, 275);
            this.Connect_box.Name = "Connect_box";
            this.Connect_box.Size = new System.Drawing.Size(141, 115);
            this.Connect_box.TabIndex = 21;
            this.Connect_box.TabStop = false;
            this.Connect_box.Text = "Сервер";
            // 
            // lk
            // 
            this.lk.Location = new System.Drawing.Point(501, 149);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(57, 42);
            this.lk.TabIndex = 22;
            this.lk.Text = "Кабинет";
            this.lk.UseVisualStyleBackColor = true;
            this.lk.Click += new System.EventHandler(this.lk_Click);
            // 
            // lk_Box
            // 
            this.lk_Box.BackColor = System.Drawing.SystemColors.Info;
            this.lk_Box.Controls.Add(this.name);
            this.lk_Box.Controls.Add(this.label5);
            this.lk_Box.Controls.Add(this.ID);
            this.lk_Box.Controls.Add(this.label6);
            this.lk_Box.Location = new System.Drawing.Point(356, 149);
            this.lk_Box.Name = "lk_Box";
            this.lk_Box.Size = new System.Drawing.Size(142, 87);
            this.lk_Box.TabIndex = 22;
            this.lk_Box.TabStop = false;
            this.lk_Box.Text = "Кабинет";
            // 
            // DataConnect
            // 
            this.DataConnect.Location = new System.Drawing.Point(504, 275);
            this.DataConnect.Name = "DataConnect";
            this.DataConnect.Size = new System.Drawing.Size(57, 42);
            this.DataConnect.TabIndex = 11;
            this.DataConnect.Text = "О сервере";
            this.DataConnect.UseVisualStyleBackColor = true;
            this.DataConnect.Click += new System.EventHandler(this.DataConnect_Click);
            // 
            // whisper
            // 
            this.whisper.Location = new System.Drawing.Point(113, 389);
            this.whisper.Name = "whisper";
            this.whisper.Size = new System.Drawing.Size(88, 20);
            this.whisper.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Личное письмо-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.whisper);
            this.Controls.Add(this.lk_Box);
            this.Controls.Add(this.Connect_box);
            this.Controls.Add(this.DataConnect);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.online_box);
            this.Controls.Add(this.online);
            this.Controls.Add(this.ChatBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBoxAll);
            this.Controls.Add(this.Send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Connect_box.ResumeLayout(false);
            this.Connect_box.PerformLayout();
            this.lk_Box.ResumeLayout(false);
            this.lk_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox SendBoxAll;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ChatBoxAll;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox online_box;
        private System.Windows.Forms.Button online;
        private System.Windows.Forms.GroupBox Connect_box;
        private System.Windows.Forms.Button lk;
        private System.Windows.Forms.GroupBox lk_Box;
        private System.Windows.Forms.Button DataConnect;
        private System.Windows.Forms.TextBox whisper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

