using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.softSerial = new System.Windows.Forms.Label();
            this.hardSerial = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.new0F = new System.Windows.Forms.TextBox();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.x0F = new System.Windows.Forms.Label();
            this.new0E = new System.Windows.Forms.TextBox();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.x0E = new System.Windows.Forms.Label();
            this.new0D = new System.Windows.Forms.TextBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.x0D = new System.Windows.Forms.Label();
            this.new0C = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.x0C = new System.Windows.Forms.Label();
            this.new0B = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.x0B = new System.Windows.Forms.Label();
            this.new0A = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.x0A = new System.Windows.Forms.Label();
            this.new09 = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.x09 = new System.Windows.Forms.Label();
            this.new08 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.x08 = new System.Windows.Forms.Label();
            this.new07 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.x07 = new System.Windows.Forms.Label();
            this.new06 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.x06 = new System.Windows.Forms.Label();
            this.new05 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.x05 = new System.Windows.Forms.Label();
            this.new04 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.x04 = new System.Windows.Forms.Label();
            this.new03 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.x03 = new System.Windows.Forms.Label();
            this.new02 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.x02 = new System.Windows.Forms.Label();
            this.new01 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.x01 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newAddr = new System.Windows.Forms.TextBox();
            this.alterAdrBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currentA = new System.Windows.Forms.Label();
            this.getAdBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.bq = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.output24 = new System.Windows.Forms.CheckBox();
            this.relayOutput = new System.Windows.Forms.CheckBox();
            this.isjunheng = new System.Windows.Forms.CheckBox();
            this.dianliu = new System.Windows.Forms.Label();
            this.wendu4 = new System.Windows.Forms.Label();
            this.wendu3 = new System.Windows.Forms.Label();
            this.wendu2 = new System.Windows.Forms.Label();
            this.wendu1 = new System.Windows.Forms.Label();
            this.dianya14 = new System.Windows.Forms.Label();
            this.dianya13 = new System.Windows.Forms.Label();
            this.dianya12 = new System.Windows.Forms.Label();
            this.dianya11 = new System.Windows.Forms.Label();
            this.dianya10 = new System.Windows.Forms.Label();
            this.dianya9 = new System.Windows.Forms.Label();
            this.dianya8 = new System.Windows.Forms.Label();
            this.dianya7 = new System.Windows.Forms.Label();
            this.dianya6 = new System.Windows.Forms.Label();
            this.dianya5 = new System.Windows.Forms.Label();
            this.dianya4 = new System.Windows.Forms.Label();
            this.dianya3 = new System.Windows.Forms.Label();
            this.dianya2 = new System.Windows.Forms.Label();
            this.dianya1 = new System.Windows.Forms.Label();
            this.dianya0 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.junhengshijian = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dianyajizhun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(249, 226);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(140, 25);
            this.ip.TabIndex = 0;
            this.ip.Text = "192.168.0.7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ip：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "port：";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(506, 226);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(50, 25);
            this.port.TabIndex = 3;
            this.port.Text = "20005";
            this.port.TextChanged += new System.EventHandler(this.port_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 546);
            this.tabControl1.TabIndex = 6;
       
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.ip);
            this.tab1.Controls.Add(this.button1);
            this.tab1.Controls.Add(this.port);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(982, 517);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "连接";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.hex);
            this.tab2.Controls.Add(this.label35);
            this.tab2.Controls.Add(this.label34);
            this.tab2.Controls.Add(this.softSerial);
            this.tab2.Controls.Add(this.hardSerial);
            this.tab2.Controls.Add(this.button33);
            this.tab2.Controls.Add(this.new0F);
            this.tab2.Controls.Add(this.button31);
            this.tab2.Controls.Add(this.button32);
            this.tab2.Controls.Add(this.x0F);
            this.tab2.Controls.Add(this.new0E);
            this.tab2.Controls.Add(this.button27);
            this.tab2.Controls.Add(this.button28);
            this.tab2.Controls.Add(this.x0E);
            this.tab2.Controls.Add(this.new0D);
            this.tab2.Controls.Add(this.button29);
            this.tab2.Controls.Add(this.button30);
            this.tab2.Controls.Add(this.x0D);
            this.tab2.Controls.Add(this.new0C);
            this.tab2.Controls.Add(this.button23);
            this.tab2.Controls.Add(this.button24);
            this.tab2.Controls.Add(this.x0C);
            this.tab2.Controls.Add(this.new0B);
            this.tab2.Controls.Add(this.button25);
            this.tab2.Controls.Add(this.button26);
            this.tab2.Controls.Add(this.x0B);
            this.tab2.Controls.Add(this.new0A);
            this.tab2.Controls.Add(this.button19);
            this.tab2.Controls.Add(this.button20);
            this.tab2.Controls.Add(this.x0A);
            this.tab2.Controls.Add(this.new09);
            this.tab2.Controls.Add(this.button21);
            this.tab2.Controls.Add(this.button22);
            this.tab2.Controls.Add(this.x09);
            this.tab2.Controls.Add(this.new08);
            this.tab2.Controls.Add(this.button15);
            this.tab2.Controls.Add(this.button16);
            this.tab2.Controls.Add(this.x08);
            this.tab2.Controls.Add(this.new07);
            this.tab2.Controls.Add(this.button17);
            this.tab2.Controls.Add(this.button18);
            this.tab2.Controls.Add(this.x07);
            this.tab2.Controls.Add(this.new06);
            this.tab2.Controls.Add(this.button11);
            this.tab2.Controls.Add(this.button12);
            this.tab2.Controls.Add(this.x06);
            this.tab2.Controls.Add(this.new05);
            this.tab2.Controls.Add(this.button13);
            this.tab2.Controls.Add(this.button14);
            this.tab2.Controls.Add(this.x05);
            this.tab2.Controls.Add(this.new04);
            this.tab2.Controls.Add(this.button9);
            this.tab2.Controls.Add(this.button10);
            this.tab2.Controls.Add(this.x04);
            this.tab2.Controls.Add(this.new03);
            this.tab2.Controls.Add(this.button7);
            this.tab2.Controls.Add(this.button8);
            this.tab2.Controls.Add(this.x03);
            this.tab2.Controls.Add(this.new02);
            this.tab2.Controls.Add(this.button5);
            this.tab2.Controls.Add(this.button6);
            this.tab2.Controls.Add(this.x02);
            this.tab2.Controls.Add(this.new01);
            this.tab2.Controls.Add(this.button4);
            this.tab2.Controls.Add(this.button3);
            this.tab2.Controls.Add(this.x01);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.newAddr);
            this.tab2.Controls.Add(this.alterAdrBtn);
            this.tab2.Controls.Add(this.label4);
            this.tab2.Controls.Add(this.currentA);
            this.tab2.Controls.Add(this.getAdBtn);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(982, 517);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "修改从机地址";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(574, 427);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(97, 15);
            this.label35.TabIndex = 72;
            this.label35.Text = "软件序列号：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(258, 427);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(97, 15);
            this.label34.TabIndex = 71;
            this.label34.Text = "硬件序列号：";
            // 
            // softSerial
            // 
            this.softSerial.AutoSize = true;
            this.softSerial.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softSerial.Location = new System.Drawing.Point(698, 427);
            this.softSerial.Name = "softSerial";
            this.softSerial.Size = new System.Drawing.Size(0, 17);
            this.softSerial.TabIndex = 70;
            // 
            // hardSerial
            // 
            this.hardSerial.AutoSize = true;
            this.hardSerial.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardSerial.Location = new System.Drawing.Point(376, 427);
            this.hardSerial.Name = "hardSerial";
            this.hardSerial.Size = new System.Drawing.Size(0, 17);
            this.hardSerial.TabIndex = 68;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(46, 414);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(196, 40);
            this.button33.TabIndex = 67;
            this.button33.Text = "获取硬件和软件序列号";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // new0F
            // 
            this.new0F.Location = new System.Drawing.Point(379, 374);
            this.new0F.Name = "new0F";
            this.new0F.Size = new System.Drawing.Size(100, 25);
            this.new0F.TabIndex = 66;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(289, 375);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 23);
            this.button31.TabIndex = 65;
            this.button31.Text = "改0F";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(45, 374);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 64;
            this.button32.Text = "0F";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // x0F
            // 
            this.x0F.AutoSize = true;
            this.x0F.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0F.Location = new System.Drawing.Point(140, 376);
            this.x0F.Name = "x0F";
            this.x0F.Size = new System.Drawing.Size(0, 21);
            this.x0F.TabIndex = 63;
            // 
            // new0E
            // 
            this.new0E.Location = new System.Drawing.Point(848, 343);
            this.new0E.Name = "new0E";
            this.new0E.Size = new System.Drawing.Size(100, 25);
            this.new0E.TabIndex = 62;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(758, 344);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 61;
            this.button27.Text = "改0E";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(490, 343);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 60;
            this.button28.Text = "0E";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // x0E
            // 
            this.x0E.AutoSize = true;
            this.x0E.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0E.Location = new System.Drawing.Point(601, 345);
            this.x0E.Name = "x0E";
            this.x0E.Size = new System.Drawing.Size(0, 21);
            this.x0E.TabIndex = 59;
            // 
            // new0D
            // 
            this.new0D.Location = new System.Drawing.Point(379, 342);
            this.new0D.Name = "new0D";
            this.new0D.Size = new System.Drawing.Size(100, 25);
            this.new0D.TabIndex = 58;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(289, 343);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 57;
            this.button29.Text = "改0D";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(45, 342);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 56;
            this.button30.Text = "0D";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // x0D
            // 
            this.x0D.AutoSize = true;
            this.x0D.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0D.Location = new System.Drawing.Point(140, 344);
            this.x0D.Name = "x0D";
            this.x0D.Size = new System.Drawing.Size(0, 21);
            this.x0D.TabIndex = 55;
            // 
            // new0C
            // 
            this.new0C.Location = new System.Drawing.Point(847, 313);
            this.new0C.Name = "new0C";
            this.new0C.Size = new System.Drawing.Size(100, 25);
            this.new0C.TabIndex = 54;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(757, 314);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 53;
            this.button23.Text = "改0C";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(489, 313);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 52;
            this.button24.Text = "0C";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // x0C
            // 
            this.x0C.AutoSize = true;
            this.x0C.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0C.Location = new System.Drawing.Point(600, 315);
            this.x0C.Name = "x0C";
            this.x0C.Size = new System.Drawing.Size(0, 21);
            this.x0C.TabIndex = 51;
            // 
            // new0B
            // 
            this.new0B.Location = new System.Drawing.Point(378, 312);
            this.new0B.Name = "new0B";
            this.new0B.Size = new System.Drawing.Size(100, 25);
            this.new0B.TabIndex = 50;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(288, 313);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 49;
            this.button25.Text = "改0B";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(44, 312);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 48;
            this.button26.Text = "0B";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // x0B
            // 
            this.x0B.AutoSize = true;
            this.x0B.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0B.Location = new System.Drawing.Point(139, 314);
            this.x0B.Name = "x0B";
            this.x0B.Size = new System.Drawing.Size(0, 21);
            this.x0B.TabIndex = 47;
            // 
            // new0A
            // 
            this.new0A.Location = new System.Drawing.Point(846, 281);
            this.new0A.Name = "new0A";
            this.new0A.Size = new System.Drawing.Size(100, 25);
            this.new0A.TabIndex = 46;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(756, 282);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 45;
            this.button19.Text = "改0A";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(488, 281);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 44;
            this.button20.Text = "0A";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // x0A
            // 
            this.x0A.AutoSize = true;
            this.x0A.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0A.Location = new System.Drawing.Point(599, 283);
            this.x0A.Name = "x0A";
            this.x0A.Size = new System.Drawing.Size(0, 21);
            this.x0A.TabIndex = 43;
            // 
            // new09
            // 
            this.new09.Location = new System.Drawing.Point(377, 280);
            this.new09.Name = "new09";
            this.new09.Size = new System.Drawing.Size(100, 25);
            this.new09.TabIndex = 42;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(287, 281);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 41;
            this.button21.Text = "改09";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(43, 280);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 40;
            this.button22.Text = "09";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // x09
            // 
            this.x09.AutoSize = true;
            this.x09.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x09.Location = new System.Drawing.Point(138, 282);
            this.x09.Name = "x09";
            this.x09.Size = new System.Drawing.Size(0, 21);
            this.x09.TabIndex = 39;
            // 
            // new08
            // 
            this.new08.Location = new System.Drawing.Point(846, 249);
            this.new08.Name = "new08";
            this.new08.Size = new System.Drawing.Size(100, 25);
            this.new08.TabIndex = 38;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(756, 250);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 37;
            this.button15.Text = "改08";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(488, 249);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 36;
            this.button16.Text = "08";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // x08
            // 
            this.x08.AutoSize = true;
            this.x08.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x08.Location = new System.Drawing.Point(599, 251);
            this.x08.Name = "x08";
            this.x08.Size = new System.Drawing.Size(0, 21);
            this.x08.TabIndex = 35;
            // 
            // new07
            // 
            this.new07.Location = new System.Drawing.Point(377, 248);
            this.new07.Name = "new07";
            this.new07.Size = new System.Drawing.Size(100, 25);
            this.new07.TabIndex = 34;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(287, 249);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 33;
            this.button17.Text = "改07";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(43, 248);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 32;
            this.button18.Text = "07";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // x07
            // 
            this.x07.AutoSize = true;
            this.x07.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x07.Location = new System.Drawing.Point(138, 250);
            this.x07.Name = "x07";
            this.x07.Size = new System.Drawing.Size(0, 21);
            this.x07.TabIndex = 31;
            // 
            // new06
            // 
            this.new06.Location = new System.Drawing.Point(847, 219);
            this.new06.Name = "new06";
            this.new06.Size = new System.Drawing.Size(100, 25);
            this.new06.TabIndex = 30;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(757, 220);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 29;
            this.button11.Text = "改06";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(489, 219);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 28;
            this.button12.Text = "06";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // x06
            // 
            this.x06.AutoSize = true;
            this.x06.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x06.Location = new System.Drawing.Point(600, 221);
            this.x06.Name = "x06";
            this.x06.Size = new System.Drawing.Size(0, 21);
            this.x06.TabIndex = 27;
            // 
            // new05
            // 
            this.new05.Location = new System.Drawing.Point(378, 218);
            this.new05.Name = "new05";
            this.new05.Size = new System.Drawing.Size(100, 25);
            this.new05.TabIndex = 26;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(288, 219);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 25;
            this.button13.Text = "改05";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(44, 218);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 24;
            this.button14.Text = "05";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // x05
            // 
            this.x05.AutoSize = true;
            this.x05.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x05.Location = new System.Drawing.Point(139, 220);
            this.x05.Name = "x05";
            this.x05.Size = new System.Drawing.Size(0, 21);
            this.x05.TabIndex = 23;
            // 
            // new04
            // 
            this.new04.Location = new System.Drawing.Point(846, 188);
            this.new04.Name = "new04";
            this.new04.Size = new System.Drawing.Size(100, 25);
            this.new04.TabIndex = 22;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(756, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "改04";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(488, 188);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "04";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // x04
            // 
            this.x04.AutoSize = true;
            this.x04.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x04.Location = new System.Drawing.Point(599, 190);
            this.x04.Name = "x04";
            this.x04.Size = new System.Drawing.Size(0, 21);
            this.x04.TabIndex = 19;
            // 
            // new03
            // 
            this.new03.Location = new System.Drawing.Point(377, 187);
            this.new03.Name = "new03";
            this.new03.Size = new System.Drawing.Size(100, 25);
            this.new03.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(287, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "改03";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(43, 187);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "03";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // x03
            // 
            this.x03.AutoSize = true;
            this.x03.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x03.Location = new System.Drawing.Point(138, 189);
            this.x03.Name = "x03";
            this.x03.Size = new System.Drawing.Size(0, 21);
            this.x03.TabIndex = 15;
            // 
            // new02
            // 
            this.new02.Location = new System.Drawing.Point(845, 159);
            this.new02.Name = "new02";
            this.new02.Size = new System.Drawing.Size(100, 25);
            this.new02.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(755, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "改02";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(487, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "02";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // x02
            // 
            this.x02.AutoSize = true;
            this.x02.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x02.Location = new System.Drawing.Point(598, 161);
            this.x02.Name = "x02";
            this.x02.Size = new System.Drawing.Size(0, 21);
            this.x02.TabIndex = 11;
            // 
            // new01
            // 
            this.new01.Location = new System.Drawing.Point(377, 158);
            this.new01.Name = "new01";
            this.new01.Size = new System.Drawing.Size(100, 25);
            this.new01.TabIndex = 10;
            this.new01.TextChanged += new System.EventHandler(this.new01_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "改01";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "01";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // x01
            // 
            this.x01.AutoSize = true;
            this.x01.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x01.Location = new System.Drawing.Point(138, 160);
            this.x01.Name = "x01";
            this.x01.Size = new System.Drawing.Size(0, 21);
            this.x01.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "新的从机地址：";
            // 
            // newAddr
            // 
            this.newAddr.Location = new System.Drawing.Point(770, 95);
            this.newAddr.Name = "newAddr";
            this.newAddr.Size = new System.Drawing.Size(100, 25);
            this.newAddr.TabIndex = 5;
            this.newAddr.TextChanged += new System.EventHandler(this.newAddr_TextChanged);
            // 
            // alterAdrBtn
            // 
            this.alterAdrBtn.Location = new System.Drawing.Point(492, 82);
            this.alterAdrBtn.Name = "alterAdrBtn";
            this.alterAdrBtn.Size = new System.Drawing.Size(141, 44);
            this.alterAdrBtn.TabIndex = 4;
            this.alterAdrBtn.Text = "修改从机地址";
            this.alterAdrBtn.UseVisualStyleBackColor = true;
            this.alterAdrBtn.Click += new System.EventHandler(this.alterAdrBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "当前从机地址：";
            // 
            // currentA
            // 
            this.currentA.AutoSize = true;
            this.currentA.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentA.Location = new System.Drawing.Point(421, 92);
            this.currentA.Name = "currentA";
            this.currentA.Size = new System.Drawing.Size(0, 21);
            this.currentA.TabIndex = 2;
            this.currentA.Click += new System.EventHandler(this.currentA_Click);
            // 
            // getAdBtn
            // 
            this.getAdBtn.Location = new System.Drawing.Point(34, 82);
            this.getAdBtn.Name = "getAdBtn";
            this.getAdBtn.Size = new System.Drawing.Size(133, 40);
            this.getAdBtn.TabIndex = 1;
            this.getAdBtn.Text = "获取从机原地址";
            this.getAdBtn.UseVisualStyleBackColor = true;
            this.getAdBtn.Click += new System.EventHandler(this.getAdBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "修改地址选项";
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.label33);
            this.tab3.Controls.Add(this.error);
            this.tab3.Controls.Add(this.bq);
            this.tab3.Controls.Add(this.label32);
            this.tab3.Controls.Add(this.label12);
            this.tab3.Controls.Add(this.label13);
            this.tab3.Controls.Add(this.label14);
            this.tab3.Controls.Add(this.label15);
            this.tab3.Controls.Add(this.label16);
            this.tab3.Controls.Add(this.label17);
            this.tab3.Controls.Add(this.label18);
            this.tab3.Controls.Add(this.label19);
            this.tab3.Controls.Add(this.label20);
            this.tab3.Controls.Add(this.label21);
            this.tab3.Controls.Add(this.label22);
            this.tab3.Controls.Add(this.label23);
            this.tab3.Controls.Add(this.label24);
            this.tab3.Controls.Add(this.label25);
            this.tab3.Controls.Add(this.label26);
            this.tab3.Controls.Add(this.label27);
            this.tab3.Controls.Add(this.label28);
            this.tab3.Controls.Add(this.label29);
            this.tab3.Controls.Add(this.label30);
            this.tab3.Controls.Add(this.label31);
            this.tab3.Controls.Add(this.output24);
            this.tab3.Controls.Add(this.relayOutput);
            this.tab3.Controls.Add(this.isjunheng);
            this.tab3.Controls.Add(this.dianliu);
            this.tab3.Controls.Add(this.wendu4);
            this.tab3.Controls.Add(this.wendu3);
            this.tab3.Controls.Add(this.wendu2);
            this.tab3.Controls.Add(this.wendu1);
            this.tab3.Controls.Add(this.dianya14);
            this.tab3.Controls.Add(this.dianya13);
            this.tab3.Controls.Add(this.dianya12);
            this.tab3.Controls.Add(this.dianya11);
            this.tab3.Controls.Add(this.dianya10);
            this.tab3.Controls.Add(this.dianya9);
            this.tab3.Controls.Add(this.dianya8);
            this.tab3.Controls.Add(this.dianya7);
            this.tab3.Controls.Add(this.dianya6);
            this.tab3.Controls.Add(this.dianya5);
            this.tab3.Controls.Add(this.dianya4);
            this.tab3.Controls.Add(this.dianya3);
            this.tab3.Controls.Add(this.dianya2);
            this.tab3.Controls.Add(this.dianya1);
            this.tab3.Controls.Add(this.dianya0);
            this.tab3.Controls.Add(this.label11);
            this.tab3.Controls.Add(this.button2);
            this.tab3.Controls.Add(this.label10);
            this.tab3.Controls.Add(this.junhengshijian);
            this.tab3.Controls.Add(this.label9);
            this.tab3.Controls.Add(this.label8);
            this.tab3.Controls.Add(this.dianyajizhun);
            this.tab3.Controls.Add(this.label7);
            this.tab3.Controls.Add(this.label6);
            this.tab3.Location = new System.Drawing.Point(4, 25);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(982, 517);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "均衡电压";
            this.tab3.UseVisualStyleBackColor = true;
            this.tab3.Click += new System.EventHandler(this.tab3_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(325, 425);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(80, 15);
            this.label33.TabIndex = 59;
            this.label33.Text = "错误信息:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(434, 425);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 58;
            // 
            // bq
            // 
            this.bq.AutoSize = true;
            this.bq.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bq.Location = new System.Drawing.Point(167, 425);
            this.bq.Name = "bq";
            this.bq.Size = new System.Drawing.Size(0, 17);
            this.bq.TabIndex = 57;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(31, 425);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(111, 15);
            this.label32.TabIndex = 56;
            this.label32.Text = "BQ76940状态:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(31, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "电流:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(535, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 54;
            this.label13.Text = "温度4：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(361, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 53;
            this.label14.Text = "温度3：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(187, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "温度2：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(31, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "温度1：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(363, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 50;
            this.label17.Text = "电压14：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(187, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 49;
            this.label18.Text = "电压13：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(31, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 15);
            this.label19.TabIndex = 48;
            this.label19.Text = "电压12：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(535, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 15);
            this.label20.TabIndex = 47;
            this.label20.Text = "电压11：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(361, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 15);
            this.label21.TabIndex = 46;
            this.label21.Text = "电压10：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(187, 252);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 15);
            this.label22.TabIndex = 45;
            this.label22.Text = "电压9：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(31, 252);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 15);
            this.label23.TabIndex = 44;
            this.label23.Text = "电压8：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(535, 218);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 15);
            this.label24.TabIndex = 43;
            this.label24.Text = "电压7：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(361, 218);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 15);
            this.label25.TabIndex = 42;
            this.label25.Text = "电压6：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(187, 218);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 15);
            this.label26.TabIndex = 41;
            this.label26.Text = "电压5：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(31, 218);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 15);
            this.label27.TabIndex = 40;
            this.label27.Text = "电压4：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(535, 183);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 15);
            this.label28.TabIndex = 39;
            this.label28.Text = "电压3：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(361, 183);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 15);
            this.label29.TabIndex = 38;
            this.label29.Text = "电压2：";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(187, 183);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 15);
            this.label30.TabIndex = 37;
            this.label30.Text = "电压1：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(31, 183);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 15);
            this.label31.TabIndex = 36;
            this.label31.Text = "电压0：";
            // 
            // output24
            // 
            this.output24.AutoSize = true;
            this.output24.Location = new System.Drawing.Point(188, 91);
            this.output24.Name = "output24";
            this.output24.Size = new System.Drawing.Size(109, 19);
            this.output24.TabIndex = 35;
            this.output24.Text = "24V Output";
            this.output24.UseVisualStyleBackColor = true;
            // 
            // relayOutput
            // 
            this.relayOutput.AutoSize = true;
            this.relayOutput.Location = new System.Drawing.Point(32, 91);
            this.relayOutput.Name = "relayOutput";
            this.relayOutput.Size = new System.Drawing.Size(125, 19);
            this.relayOutput.TabIndex = 34;
            this.relayOutput.Text = "Relay Output";
            this.relayOutput.UseVisualStyleBackColor = true;
            this.relayOutput.CheckedChanged += new System.EventHandler(this.relayOutput_CheckedChanged);
            // 
            // isjunheng
            // 
            this.isjunheng.AutoSize = true;
            this.isjunheng.Location = new System.Drawing.Point(216, 48);
            this.isjunheng.Name = "isjunheng";
            this.isjunheng.Size = new System.Drawing.Size(89, 19);
            this.isjunheng.TabIndex = 33;
            this.isjunheng.Text = "是否均衡";
            this.isjunheng.UseVisualStyleBackColor = true;
            // 
            // dianliu
            // 
            this.dianliu.AutoSize = true;
            this.dianliu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianliu.Location = new System.Drawing.Point(102, 387);
            this.dianliu.Name = "dianliu";
            this.dianliu.Size = new System.Drawing.Size(0, 17);
            this.dianliu.TabIndex = 32;
            // 
            // wendu4
            // 
            this.wendu4.AutoSize = true;
            this.wendu4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wendu4.Location = new System.Drawing.Point(624, 337);
            this.wendu4.Name = "wendu4";
            this.wendu4.Size = new System.Drawing.Size(0, 17);
            this.wendu4.TabIndex = 31;
            // 
            // wendu3
            // 
            this.wendu3.AutoSize = true;
            this.wendu3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wendu3.Location = new System.Drawing.Point(436, 337);
            this.wendu3.Name = "wendu3";
            this.wendu3.Size = new System.Drawing.Size(0, 17);
            this.wendu3.TabIndex = 30;
            // 
            // wendu2
            // 
            this.wendu2.AutoSize = true;
            this.wendu2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wendu2.Location = new System.Drawing.Point(264, 337);
            this.wendu2.Name = "wendu2";
            this.wendu2.Size = new System.Drawing.Size(0, 17);
            this.wendu2.TabIndex = 29;
            // 
            // wendu1
            // 
            this.wendu1.AutoSize = true;
            this.wendu1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wendu1.Location = new System.Drawing.Point(102, 337);
            this.wendu1.Name = "wendu1";
            this.wendu1.Size = new System.Drawing.Size(0, 17);
            this.wendu1.TabIndex = 28;
            // 
            // dianya14
            // 
            this.dianya14.AutoSize = true;
            this.dianya14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya14.Location = new System.Drawing.Point(436, 284);
            this.dianya14.Name = "dianya14";
            this.dianya14.Size = new System.Drawing.Size(0, 17);
            this.dianya14.TabIndex = 27;
            // 
            // dianya13
            // 
            this.dianya13.AutoSize = true;
            this.dianya13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya13.Location = new System.Drawing.Point(264, 284);
            this.dianya13.Name = "dianya13";
            this.dianya13.Size = new System.Drawing.Size(0, 17);
            this.dianya13.TabIndex = 26;
            // 
            // dianya12
            // 
            this.dianya12.AutoSize = true;
            this.dianya12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya12.Location = new System.Drawing.Point(102, 284);
            this.dianya12.Name = "dianya12";
            this.dianya12.Size = new System.Drawing.Size(0, 17);
            this.dianya12.TabIndex = 25;
            // 
            // dianya11
            // 
            this.dianya11.AutoSize = true;
            this.dianya11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya11.Location = new System.Drawing.Point(624, 252);
            this.dianya11.Name = "dianya11";
            this.dianya11.Size = new System.Drawing.Size(0, 17);
            this.dianya11.TabIndex = 24;
            // 
            // dianya10
            // 
            this.dianya10.AutoSize = true;
            this.dianya10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya10.Location = new System.Drawing.Point(436, 252);
            this.dianya10.Name = "dianya10";
            this.dianya10.Size = new System.Drawing.Size(0, 17);
            this.dianya10.TabIndex = 23;
            // 
            // dianya9
            // 
            this.dianya9.AutoSize = true;
            this.dianya9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya9.Location = new System.Drawing.Point(264, 252);
            this.dianya9.Name = "dianya9";
            this.dianya9.Size = new System.Drawing.Size(0, 17);
            this.dianya9.TabIndex = 22;
            // 
            // dianya8
            // 
            this.dianya8.AutoSize = true;
            this.dianya8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya8.Location = new System.Drawing.Point(102, 252);
            this.dianya8.Name = "dianya8";
            this.dianya8.Size = new System.Drawing.Size(0, 17);
            this.dianya8.TabIndex = 21;
            // 
            // dianya7
            // 
            this.dianya7.AutoSize = true;
            this.dianya7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya7.Location = new System.Drawing.Point(624, 218);
            this.dianya7.Name = "dianya7";
            this.dianya7.Size = new System.Drawing.Size(0, 17);
            this.dianya7.TabIndex = 20;
            // 
            // dianya6
            // 
            this.dianya6.AutoSize = true;
            this.dianya6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya6.Location = new System.Drawing.Point(436, 218);
            this.dianya6.Name = "dianya6";
            this.dianya6.Size = new System.Drawing.Size(0, 17);
            this.dianya6.TabIndex = 19;
            // 
            // dianya5
            // 
            this.dianya5.AutoSize = true;
            this.dianya5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya5.Location = new System.Drawing.Point(264, 218);
            this.dianya5.Name = "dianya5";
            this.dianya5.Size = new System.Drawing.Size(0, 17);
            this.dianya5.TabIndex = 18;
            // 
            // dianya4
            // 
            this.dianya4.AutoSize = true;
            this.dianya4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya4.Location = new System.Drawing.Point(102, 218);
            this.dianya4.Name = "dianya4";
            this.dianya4.Size = new System.Drawing.Size(0, 17);
            this.dianya4.TabIndex = 17;
            // 
            // dianya3
            // 
            this.dianya3.AutoSize = true;
            this.dianya3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya3.Location = new System.Drawing.Point(624, 183);
            this.dianya3.Name = "dianya3";
            this.dianya3.Size = new System.Drawing.Size(0, 17);
            this.dianya3.TabIndex = 16;
            // 
            // dianya2
            // 
            this.dianya2.AutoSize = true;
            this.dianya2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya2.Location = new System.Drawing.Point(436, 183);
            this.dianya2.Name = "dianya2";
            this.dianya2.Size = new System.Drawing.Size(0, 17);
            this.dianya2.TabIndex = 15;
            // 
            // dianya1
            // 
            this.dianya1.AutoSize = true;
            this.dianya1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya1.Location = new System.Drawing.Point(264, 183);
            this.dianya1.Name = "dianya1";
            this.dianya1.Size = new System.Drawing.Size(0, 17);
            this.dianya1.TabIndex = 14;
            // 
            // dianya0
            // 
            this.dianya0.AutoSize = true;
            this.dianya0.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dianya0.Location = new System.Drawing.Point(102, 183);
            this.dianya0.Name = "dianya0";
            this.dianya0.Size = new System.Drawing.Size(0, 17);
            this.dianya0.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(11, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "返回信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "发送均衡指令";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "x0.25  s";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // junhengshijian
            // 
            this.junhengshijian.Location = new System.Drawing.Point(411, 45);
            this.junhengshijian.Name = "junhengshijian";
            this.junhengshijian.Size = new System.Drawing.Size(72, 25);
            this.junhengshijian.TabIndex = 7;
            this.junhengshijian.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "均衡时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "V";
            // 
            // dianyajizhun
            // 
            this.dianyajizhun.Location = new System.Drawing.Point(112, 45);
            this.dianyajizhun.Name = "dianyajizhun";
            this.dianyajizhun.Size = new System.Drawing.Size(67, 25);
            this.dianyajizhun.TabIndex = 2;
            this.dianyajizhun.Text = "2.5";
            this.dianyajizhun.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "电压基准：";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "均衡电压选项";
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(49, 128);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(119, 19);
            this.hex.TabIndex = 73;
            this.hex.Text = "十六进制显示";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.Checked = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上位机小程序";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button button1;
        private Socket socket;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label currentA;
        private System.Windows.Forms.Button getAdBtn;
        private System.Windows.Forms.Label label3;

        private byte[] getAdCmd = { 0x88,0x1C ,0xFC, 0x30, 0x01,0x00 ,0x00,0x00,0x00,0x00, 0x00,0x00,0x00,0x00 };
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newAddr;
        private System.Windows.Forms.Button alterAdrBtn;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wendu4;
        private System.Windows.Forms.Label wendu3;
        private System.Windows.Forms.Label wendu2;
        private System.Windows.Forms.Label wendu1;
        private System.Windows.Forms.Label dianya14;
        private System.Windows.Forms.Label dianya13;
        private System.Windows.Forms.Label dianya12;
        private System.Windows.Forms.Label dianya11;
        private System.Windows.Forms.Label dianya10;
        private System.Windows.Forms.Label dianya9;
        private System.Windows.Forms.Label dianya8;
        private System.Windows.Forms.Label dianya7;
        private System.Windows.Forms.Label dianya6;
        private System.Windows.Forms.Label dianya5;
        private System.Windows.Forms.Label dianya4;
        private System.Windows.Forms.Label dianya3;
        private System.Windows.Forms.Label dianya2;
        private System.Windows.Forms.Label dianya1;
        private System.Windows.Forms.Label dianya0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox junhengshijian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dianyajizhun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dianliu;
        private System.Windows.Forms.CheckBox isjunheng;
        private System.Windows.Forms.CheckBox relayOutput;
        private System.Windows.Forms.CheckBox output24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label bq;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox new01;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label x01;
        private System.Windows.Forms.TextBox new02;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label x02;
        private System.Windows.Forms.TextBox new03;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label x03;
        private System.Windows.Forms.TextBox new04;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label x04;
        private System.Windows.Forms.TextBox new0C;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label x0C;
        private System.Windows.Forms.TextBox new0B;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label x0B;
        private System.Windows.Forms.TextBox new0A;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label x0A;
        private System.Windows.Forms.TextBox new09;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label x09;
        private System.Windows.Forms.TextBox new08;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label x08;
        private System.Windows.Forms.TextBox new07;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label x07;
        private System.Windows.Forms.TextBox new06;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label x06;
        private System.Windows.Forms.TextBox new05;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label x05;
        private System.Windows.Forms.TextBox new0E;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Label x0E;
        private System.Windows.Forms.TextBox new0D;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label x0D;
        private System.Windows.Forms.TextBox new0F;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Label x0F;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label softSerial;
        private System.Windows.Forms.Label hardSerial;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox hex;
    }
}

