using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int po = 0;
            IPAddress addr;
            try
            {
                po = int.Parse(port.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的端口号！");
                return;
            }
            try
            {
                addr = IPAddress.Parse(ip.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的ip地址！");
                return;
            }
            IPEndPoint point = new IPEndPoint(addr, po);

            try
            {
                socket.BeginConnect(point, ar =>
                {
                    AccessAciton();
                }, null);
            }
            catch
            {
                MessageBox.Show("连接失败！");
                return;
            }

          
        }

        private void ReceiveAction(string obj)
        {
            MessageBox.Show(obj);
        }

        private void AccessAciton()
        {
            MessageBox.Show("连接成功！");
        }

      
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void getAdBtn_Click(object sender, EventArgs e)
        {
            if (this.flag) {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];
            
            this.socket.Send(this.getAdCmd);

            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
            }


            int addr = recec[9];
            currentA.Text = (addr+"");

        }
       
        private void currentA_Click(object sender, EventArgs e)
        {

        }

        private void port_TextChanged(object sender, EventArgs e)
        {

        }

        private void alterAdrBtn_Click(object sender, EventArgs e)
        {

            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            int newA = 0;
            if (newAddr.Text.Trim().Equals("")) {
                MessageBox.Show("请输入新的地址！");
                return;
            }

            try {
                newA =int.Parse(newAddr.Text.Trim()); }
            catch (Exception) {
                MessageBox.Show("请输入数字！");
                return;
            }

            if (!(newA >= 0 && newA <= 127)) {
                MessageBox.Show("地址范围在0-127！");
                return;
            }

            byte[] rec = new byte[1024];


            try{
                socket.Send(getAdCmd);
            }
            catch (Exception) {
                MessageBox.Show("连接未建立，请先建立连接！");
                return;
            }
            try {
                socket.Receive(rec);
            }
            catch (Exception) {
                MessageBox.Show("无数据返回！");
            }
            //有延时，等有数据返回再发！
            Thread.Sleep(500);
            
            byte add = (byte)(newA & 0xff);
            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc ,0x20,0x01, 0x00, 0x00, 0x00, 0x00, add, rec[10], rec[11], rec[12] };
            socket.Send(writeAdCmd);
            int len = socket.Receive(rec);
            if (len != 0) {
                MessageBox.Show("修改地址成功！");
            }

        }


        private byte[] junCmd;

        //发送均衡指定的方法
        public void Send()
        {
            if (socket.Connected == false)
            {
                MessageBox.Show("连接未建立，请先建立连接！");
                return;
            }

            socket.BeginSend(junCmd, 0, junCmd.Length, SocketFlags.None, new AsyncCallback(SendMessage), socket);












        }


        private byte[] msg = new byte[143];

        //接受消息的回调函数
        public  void ReceiveMessage(IAsyncResult ar)
        {
            if (!this.flag)
            {
              
                return;
            }




            try
            {
                var socket = ar.AsyncState as Socket;
                var length = socket.EndReceive(ar);

              



                BinaryReader br = new BinaryReader(new MemoryStream(msg));


                int bq = 258;
                int error = 258;
                int dianya0 = 0;
                int dianya1 = 0;
                int dianya2 = 0;
                int dianya3  =0;
                int dianya4 = 0;
                int dianya5 = 0;
                int dianya6 = 0;
                int dianya7 = 0;
                int dianya8 =0;
                int dianya9=0; int dianya10=0; int dianya11=0;

                int dianya12 = 0;
                int dianya13 = 0;
                int dianya14 = 0;

                int wendu1 = 0, wendu2=0, wendu3=0, wendu4=0;

                int dianliu=0;


                int l = msg.Length;

                int zu = l / 13;

                for (int i = 0; i < zu; i++)
                {

                    br.ReadBytes(5);
                    UInt32 addr = br.ReadUInt32();


                    switch (addr)
                    {

                        case 0x14:
                            bq = br.ReadByte();

                            error = br.ReadByte();

                            dianya0 = br.ReadUInt16();
                            break;


                        case 0x15:
                            dianya1 = br.ReadUInt16();
                            dianya2 = br.ReadUInt16();
                            break;
                        case 0x16:
                            dianya3 = br.ReadUInt16();
                            dianya4 = br.ReadUInt16();
                            break;
                        case 0x17:
                            dianya5 = br.ReadUInt16();
                            dianya6 = br.ReadUInt16();
                            break;

                        case 0x18:
                            dianya7 = br.ReadUInt16();
                            dianya8 = br.ReadUInt16();
                            break;

                        case 0x19:
                            dianya9 = br.ReadUInt16();
                            dianya10 = br.ReadUInt16();
                            break;

                        case 0x1A:
                            dianya11 = br.ReadUInt16();
                            dianya12 = br.ReadUInt16();
                            break;

                        case 0x1b:
                            dianya13 = br.ReadUInt16();
                            dianya14 = br.ReadUInt16();
                            break;

                        case 0x1c:
                            wendu1 = br.ReadInt16();
                            wendu2 = br.ReadInt16();
                            break;

                        case 0x1D:
                            wendu3 = br.ReadInt16();
                            wendu4 = br.ReadInt16();
                            break;

                        case 0x1e:
                            dianliu = br.ReadInt32();
                            break;

                    }


                    
                }



                if(bq !=  258){
                    this.bq.Text = bq+"";

                }

                if (error != 258) {
                    this.error.Text = error + "";

                }



                if (dianya0 != 0)
                {
                    this.dianya0.Text =  dianya0 / 1000f + "V";
                }
                this.dianya1.Text =  dianya1 / 1000f + "V";
                this.dianya2.Text =  dianya2 / 1000f + "V";
                this.dianya3.Text =  dianya3 / 1000f + "V";
                this.dianya4.Text =  dianya4 / 1000f + "V";
                this.dianya5.Text =  dianya5 / 1000f + "V";
                this.dianya6.Text =  dianya6 / 1000f + "V";
                this.dianya7.Text =  dianya7 / 1000f + "V";
                this.dianya8.Text =  dianya8 / 1000f + "V";
                this.dianya9.Text =  dianya9 / 1000f + "V";
                this.dianya10.Text =  dianya10 / 1000f + "V";
                this.dianya11.Text =  dianya11 / 1000f + "V";
                this.dianya12.Text =  dianya12 / 1000f + "V";
                this.dianya13.Text =  dianya13 / 1000f + "V";
                this.dianya14.Text =  dianya14 / 1000f + "V";
                this.wendu1.Text =  wendu1 / 100f + " ℃";
                this.wendu2.Text =  wendu2 / 100f + " ℃";
                this.wendu3.Text =  wendu3 / 100f + " ℃";
                this.wendu4.Text =  wendu4 / 100f + " ℃";

                if (dianliu != 0)
                {
                    this.dianliu.Text =  dianliu * 10 / 1000000f + " A";
                }

                //接收下一个消息(因为这是一个递归的调用，所以这样就可以一直接收消息了）  
                socket.BeginReceive(msg, 0, msg.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
            }
            catch (Exception )
            {
                MessageBox.Show("连接已经断开！");
            }
        }






      









        //发送消息的回调函数
        public void SendMessage(IAsyncResult ar)
        {
            if (!this.flag) {

                return;
            }



            try
            {
                var socket = ar.AsyncState as Socket;
                //发送间隔暂时定为1秒。



                Thread.Sleep(1000);


                  
                socket.BeginSend(junCmd, 0, junCmd.Length, SocketFlags.None, new AsyncCallback(SendMessage), socket);
            }
            catch (Exception)
            {
                MessageBox.Show("连接已经断开！");
            }
        }






















        public void ReceiveJun()
        {
            //如果消息超过1024个字节, 收到的消息会分为(总字节长度/1024 +1)条显示

            //异步的接受消息
            
            socket.BeginReceive(msg, 0, msg.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);




        

        }
















        private void newAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e){

        }
        


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!this.flag)
            {

                send();
            }
            else {
                this.flag = false;

                this.button2.Text = "发送均衡指令";


            }

            
        }


     



        private void send() {
            decimal dianyaj = 0;

            try{
                dianyaj = decimal.Parse(this.dianyajizhun.Text.Trim()); }
            catch (Exception)
            {
                MessageBox.Show("电压基准为数字！");
                return;
            }
            int dianyajint = (int)(dianyaj * 1000);

            decimal dianyajiintCheck = dianyaj * 1000;
            if (!((dianyajint - dianyajiintCheck).Equals(0)))
            {

                MessageBox.Show("电压基准的范围为0-65.536!");
                return;
            }

            if (dianyajint > 65536 || dianyajint < 0)
            {

                MessageBox.Show("电压基准的范围为0-65.536!");
                return;
            }

            //是否均衡
            Boolean jun = isjunheng.Checked;
            int junHengTime = 0;
            try
            {
                 junHengTime = int.Parse(this.junhengshijian.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("均衡时间必须为数字！");
                return;
            }

            Boolean reout = relayOutput.Checked;
            Boolean reout24 = this.output24.Checked;
            byte dianyajLow = (byte)(dianyajint & 0xff);

            byte dianyajHigh = (byte)(dianyajint >> 8 & 0xff);

            byte timeByte = (byte)(junHengTime & 0xff);
            byte junByte;

            byte output;

            if (reout)
            {

                if (reout24)
                {

                    output = 0x03;

                }
                else
                {

                    output = 0x01;
                }

            }
            else
            {


                if (reout24)
                {

                    output = 0x02;

                }
                else
                {

                    output = 0x00;
                }


            }





            if (jun)
            {
                junByte = 0x01;

            }
            else
            {
                junByte = 0x00;
            }

            byte[] junhengCmd = { 0x88, 0x1c, 0xfc, 0x00, 0x01, dianyajLow, dianyajHigh, junByte, timeByte, output, 0x00, 0x00, 0x00 };


            this.junCmd = junhengCmd;
            this.flag = true;


            Send();

           
           ReceiveJun();


           this.button2.Text = "停止发送";

          
        }





        private bool flag = false;











    public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "

        {
            string hexString = string.Empty;

            if (bytes != null)

            {

                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)

                {

                    strB.Append(bytes[i].ToString("X2"));

                }

                hexString = strB.ToString();

            }
            return hexString;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void relayOutput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void output24_CheckedChanged(object sender, EventArgs e)
        {

        }





        //发送线程所用的方法


      






      


        //
        public static byte[] Object2Bytes(object obj)
        {
            byte[] buff;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter iFormatter = new BinaryFormatter();
                iFormatter.Serialize(ms, obj);
                buff = ms.GetBuffer();
            }
            return buff;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {



          

            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            this.x01.Text = r + "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            UInt32 newT = 0;
            if (new01.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入新值");
                return;
            }

            try
            {
                newT = UInt32.Parse(new01.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！");
                return;
            }
            

          

         
          

            byte byte1 = (byte)(newT & 0xff);

            byte byte2 = (byte)((newT>>8) & 0xff);

            byte byte3 = (byte)((newT >> 16) & 0xff);
            byte byte4 = (byte)((newT >> 24) & 0xff);



            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc, 0x20, 0x01, 0x01, 0x00, 0x00, 0x00, byte1, byte2, byte3, byte4 };
            socket.Send(writeAdCmd);

            byte[] rec = new byte[1024];
            int len = socket.Receive(rec);
            if (len != 0)
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void new01_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            this.x02.Text = r + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            UInt32 newT = 0;
            if (new02.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入新值");
                return;
            }

            try
            {
                newT = UInt32.Parse(new02.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！");
                return;
            }







            byte byte1 = (byte)(newT & 0xff);

            byte byte2 = (byte)((newT >> 8) & 0xff);

            byte byte3 = (byte)((newT >> 16) & 0xff);
            byte byte4 = (byte)((newT >> 24) & 0xff);



            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc, 0x20, 0x01, 0x02, 0x00, 0x00, 0x00, byte1, byte2, byte3, byte4 };
            socket.Send(writeAdCmd);

            byte[] rec = new byte[1024];
            int len = socket.Receive(rec);
            if (len != 0)
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            this.x03.Text = r + "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            UInt32 newT = 0;
            if (new03.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入新值");
                return;
            }

            try
            {
                newT = UInt32.Parse(new03.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！");
                return;
            }







            byte byte1 = (byte)(newT & 0xff);

            byte byte2 = (byte)((newT >> 8) & 0xff);

            byte byte3 = (byte)((newT >> 16) & 0xff);
            byte byte4 = (byte)((newT >> 24) & 0xff);



            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc, 0x20, 0x01, 0x03, 0x00, 0x00, 0x00, byte1, byte2, byte3, byte4 };
            socket.Send(writeAdCmd);

            byte[] rec = new byte[1024];
            int len = socket.Receive(rec);
            if (len != 0)
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            this.x04.Text = r + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            UInt32 newT = 0;
            if (new04.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入新值");
                return;
            }

            try
            {
                newT = UInt32.Parse(new04.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！");
                return;
            }







            byte byte1 = (byte)(newT & 0xff);

            byte byte2 = (byte)((newT >> 8) & 0xff);

            byte byte3 = (byte)((newT >> 16) & 0xff);
            byte byte4 = (byte)((newT >> 24) & 0xff);



            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc, 0x20, 0x01, 0x04, 0x00, 0x00, 0x00, byte1, byte2, byte3, byte4 };
            socket.Send(writeAdCmd);

            byte[] rec = new byte[1024];
            int len = socket.Receive(rec);
            if (len != 0)
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            this.x05.Text = r + "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            UInt32 newT = 0;
            if (new05.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入新值");
                return;
            }

            try
            {
                newT = UInt32.Parse(new05.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！");
                return;
            }







            byte byte1 = (byte)(newT & 0xff);

            byte byte2 = (byte)((newT >> 8) & 0xff);

            byte byte3 = (byte)((newT >> 16) & 0xff);
            byte byte4 = (byte)((newT >> 24) & 0xff);



            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc, 0x20, 0x01, 0x05, 0x00, 0x00, 0x00, byte1, byte2, byte3, byte4 };
            socket.Send(writeAdCmd);

            byte[] rec = new byte[1024];
            int len = socket.Receive(rec);
            if (len != 0)
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }

            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            this.x06.Text = r + "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X07, this.x07);
        }


        private void getAndDisplay(byte addr,Label la) {


            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }

            byte[] recec = new byte[1024];

            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x01, addr, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {

                socket.Send(cmd);

            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;

            }



            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
                return;
            }

            byte[] res = { recec[9], recec[10], recec[11], recec[12] };

            UInt32 r = System.BitConverter.ToUInt32(res, 0);

            la.Text = r + "";





        }







        private void modifyAdd(TextBox text,byte addr) {


            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }


            UInt32 newT = 0;
            if (text.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入新值");
                return;
            }

            try
            {
                newT = UInt32.Parse(text.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！");
                return;
            }







            byte byte1 = (byte)(newT & 0xff);

            byte byte2 = (byte)((newT >> 8) & 0xff);

            byte byte3 = (byte)((newT >> 16) & 0xff);
            byte byte4 = (byte)((newT >> 24) & 0xff);



            byte[] writeAdCmd = { 0x88, 0x1C, 0xfc, 0x20, 0x01, addr, 0x00, 0x00, 0x00, byte1, byte2, byte3, byte4 };
            socket.Send(writeAdCmd);

            byte[] rec = new byte[1024];
            int len = socket.Receive(rec);
            if (len != 0)
            {
                MessageBox.Show("修改成功！");
            }



        }



















        private void button11_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new06, 0x06);
        }

        private void tab2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new07, 0x07);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X08, this.x08);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            modifyAdd(new08, 0x08);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            getAndDisplay(0x09, this.x09);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new09, 0x09);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X0A, this.x0A);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new0A, 0X0A);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X0B, this.x0B);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            modifyAdd(new0B, 0X0B);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X0C, this.x0C);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new0C, 0x0c);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X0D, this.x0D);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new0D, 0X0D);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            getAndDisplay(0x0e, this.x0E);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            getAndDisplay(0X0F, this.x0F);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new0F, 0x0f);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            modifyAdd(this.new0E, 0x0e);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                MessageBox.Show("请先停止发送均衡！");
                return;

            }




            byte[] recec = new byte[1024];


            byte[] cmd = { 0x88, 0x1C, 0xFC, 0x30, 0x03, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            this.socket.Send(cmd);


            


            try
            {
                socket.Receive(recec);
            }
            catch (Exception)
            {
                MessageBox.Show("无数据返回！");
            }


            if (recec[3] != 0x21) {

                this.socket.Send(cmd);





                try
                {
                    socket.Receive(recec);
                }
                catch (Exception)
                {
                    MessageBox.Show("无数据返回！");
                }



            }

            byte[] resHard = { recec[9], recec[10], recec[11], recec[12], recec[22], recec[23], recec[24], recec[25], recec[35], recec[36] };

            byte[] resSoft = { recec[37], recec[38] };




            string hardSerial = System.Text.Encoding.ASCII.GetString(resHard);
            string sofrSerial  = System.Text.Encoding.ASCII.GetString(resSoft);

            this.hardSerial.Text = hardSerial;

            this.softSerial.Text = sofrSerial;


        }
    }
}
