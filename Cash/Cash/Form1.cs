using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Principal;
using Microsoft.Win32;

namespace Cash
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            if(!isAdmin())
            {
                katılButton.Visible = false;
                girisButton.Visible = false;
                MessageBox.Show("Programı kapatıp Administrator olarak başlatmalısın şeker..");
                                
            }
            if (!IsApplicationInstalled("Google Chrome"))
            {
                katılButton.Visible = false;
                girisButton.Visible = false;
                MessageBox.Show("Programın sağlıklı çalışması için chrome yüklü olmalıdır. Yani bi zahmet chrome kurarsan hem sen hem ben mutlu olucaz balım, bide onu varsayılan tarayıcı yaparsan tadından yenmez :)");
            }
        }

        private void katılButton_Click(object sender, EventArgs e)
        {
            String isim = katılIsimText.Text.ToString();
            String pass = katılSifreText.Text.ToString();
            String url = katılUrlText.Text.ToString();

            if(isim.Length>10 || isim.Length<3 || pass.Length>10 || pass.Length<3 || url.Length<2 || url.Length>6)
            {
                MessageBox.Show("İsim, şifre veya url özellikleri istenilen özelliklere uymuyor, okuma yazman olduğuna ve okuyunuz kısmını okuduğuna eminmisin??");
                
            }
            else
            {
                try
                {
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    String post = "isim=" + isim + "&sifre=" + pass + "&url=" + url;
                    byte[] data = encoding.GetBytes(post);

                    WebRequest request = WebRequest.Create("http://213.14.139.117:80/cashKatil.php");
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

                    if (cevap == "tamamdir")
                    {
                        MessageBox.Show("Kaydın tamamlandı canım, unutmaki 3 gün üst üste linklere tıklamazsan silinirsin ve tekrar kayıt yaptığında en alt sıradan giriş yaparsın şimdi olduğu gibi ;)");
                    }

                    else if (cevap == "url")
                    {
                        MessageBox.Show("Bu url ile kayıt yapılmış tatlım, başka bi url kullanmalısın, ananın en güzel kızı sensin sanırım ;)");
                    }
                    else if (cevap == "mevcut")
                    {
                        MessageBox.Show("Bu isim daha önce alınmış tatlım, başka bi isim bulmalısın..");
                    }

                    else if (cevap == "sorun")
                    {
                        MessageBox.Show("Sunucularda ufak bir problem var, birazdan düzelecektir, sen otur bi çay kahve falan iç sonra tekrar dene..");
                    }
                    else
                    {
                        MessageBox.Show(cevap);
                    }

                    sr.Close();
                    stream.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            String isim = girisIsimText.Text.ToString();
            String sifre = girisSifreText.Text.ToString();

            if(isim.Length>0 && sifre.Length>0)
            {
                try
                {
                    ASCIIEncoding encode = new ASCIIEncoding();
                    String post = "isim=" + isim + "&sifre=" + sifre;
                    byte[] data = encode.GetBytes(post);

                    WebRequest request = WebRequest.Create("http://213.14.139.117:80/cashGiris.php");
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

                    if(cevap=="gir")
                    {
                        Basla.kullanici = girisIsimText.Text.ToString();
                        Basla bsl = new Basla();
                        bsl.Show();
                        this.Hide();
                    }
                    else if(cevap=="olmadi")
                    {
                        MessageBox.Show("Girdiğin bilgiler yanlış canım, bidaha dene hadi..");
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }


            }
            else
            {
                MessageBox.Show("İsmini ve şifreni girmezsen kim olduğunu nerden bileceğim gerizekalı???");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool isAdmin()
        {
            bool admin;
            WindowsIdentity user = null;

            try
            {
                user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                admin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch(UnauthorizedAccessException ex)
            {
                admin = false;
            }
            catch(Exception ex)
            {
                admin = false;
            }
            finally
            {
                if (user != null) user.Dispose();
            }

            return admin;
        }

        public static bool IsApplicationInstalled(string p_name)
        {
            string displayName;
            RegistryKey key;
            
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return true;
                }
            }

            // search in: LocalMachine_32
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return true;
                }
            }

            // search in: LocalMachine_64
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return true;
                }
            }

            // NOT FOUND
            return false;
        }

    }
}
