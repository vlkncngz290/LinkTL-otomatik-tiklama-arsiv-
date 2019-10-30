using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash
{
    public partial class Basla : Form
    {
        public static String kullanici;
        int zaman;
        String[] linkler;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public Basla()
        {
            InitializeComponent();
            label6.Text = kullanici+" isimli hesap ile giriş yapıldı";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hazirlan_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding encode = new ASCIIEncoding();
                String post = "isim=" + kullanici;
                byte[] data = encode.GetBytes(post);

                WebRequest request = WebRequest.Create("http://213.14.139.117:80/cashHazirlan.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                String cevap = sr.ReadToEnd();
                linkler = cevap.Split(' ');
                zaman = (linkler.Length-1)*17;
                label7.Text =zaman.ToString()+" saniye";
                var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                var width = screen.Width;
                var height = screen.Height;
                if(width==1024 && height==768)
                {
                    baslaBut.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ekran çözünürlüğünü 1024 x 768 yapmalısın canım..");
                }
                

                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void baslaBut_Click(object sender, EventArgs e)
        {
            int dur = zaman * 1000;
            int sayac = 0;
            InputBlocker.Block(dur);
            for(int i=linkler.Length-1;i>=0;i--)
            {
                String link = "http://link.tl/" + linkler[i];
                System.Diagnostics.Process.Start("chrome.exe",link);
                MoveCursor();
                SendKeys.Send("{ENTER}");
                Thread.Sleep(14000);
                DoMouseClick();
                Thread.Sleep(1000);
                SendKeys.Send("{ENTER}");
                SendKeys.Send("^w");
                Thread.Sleep(1000);
                SendKeys.Send("{ENTER}");
                SendKeys.Send("{ENTER}");
                SendKeys.Send("^w");
                Thread.Sleep(1000);
                
                sayac++;
                if(sayac==20)
                {
                    SendKeys.Send("^w");
                    SendKeys.Send("^w");
                    SendKeys.Send("^w");
                    SendKeys.Send("^w");
                    SendKeys.Send("^w");
                    SendKeys.Send("^w");
                    SendKeys.Send("^w");
                }
                
            }


            try
            {
                ASCIIEncoding encode = new ASCIIEncoding();
                String post = "isim=" + kullanici;
                byte[] data = encode.GetBytes(post);

                WebRequest request = WebRequest.Create("http://213.14.139.117:80/cashGorevTamam.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                String cevap = sr.ReadToEnd();
                if(cevap=="tamam")
                {
                    MessageBox.Show("Bu günlük tıklaman tamamlandı, fazla tıklama ne sana nede başkasına fayda sağlamayacak ama yinede sen bilirsin canım, görüşmek üzere.");
                    this.Hide();
                    Form1 giris = new Form1();
                    giris.Show();

                }
                else if(cevap=="puan sorun")
                {
                    MessageBox.Show("puan hatası");
                }
                else
                {
                    MessageBox.Show(cevap);
                }



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void MoveCursor()
        {
            

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(950,100);

        }
        public void DoMouseClick()
        {
            
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
