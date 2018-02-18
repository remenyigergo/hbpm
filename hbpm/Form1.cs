using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hbpm
{
    public partial class Form1 : Form
    {
        [DllImport("USER32.DLL", SetLastError = true)]
        static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("USER32.DLL", SetLastError = true)]
        static extern bool BringWindowToTop(HandleRef hWnd);

        [DllImport("USER32.DLL", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        int mov;
        int movX;
        int movY;

        bool textbox1_ok = false;
        bool textbox2_ok = false;
        bool textbox3_ok = false;
        enum CheckTime
        {
            MORNING = 10,
            NIGHT = 20
        }

        Thread myThread;

        public Form1()
        {
            InitializeComponent();

            CustomInit();

            panel_main.BackColor = this.BackColor = Color.FromArgb(230, 224, 219);

            //Beállítjuk az adott képernyőre az ablakot
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

            //Új szál a folyamatos figyeléshez
            myThread = new System.Threading.Thread(new System.Threading.ThreadStart(LoopCheckTime));
            myThread.Start();
        }

        public void CustomInit()
        {
            this.textBox1.MaxLength = 3;
            this.textBox2.MaxLength = 3;
            this.textBox3.MaxLength = 3;
            button1_register.Enabled = false;
            button1_register.BackColor = Color.DimGray;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool checkedMorning = false;
        bool checkedNight = false;
        DateTime time;
        public void LoopCheckTime()
        {
            while (true)
            {
                time = DateTime.Now;
                var hm = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second);
                if ((hm.Minute == 36 && hm.Second == 55 && !checkedMorning) || (CheckTime.NIGHT.Equals(hm.Hour) && !checkedNight))
                {
                    Activate();
                    if (CheckTime.NIGHT.Equals(hm.Hour))
                    {
                        MessageBox.Show("Don't forget to check your HBPM!", "HBPM Check NIGHT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (CheckTime.MORNING.Equals(hm.Hour))
                    {
                        MessageBox.Show("Don't forget to check your HBPM!", "HBPM Check MORNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //MethodInvoker mi = delegate () { DoWindowTop(); };
                    //this.Invoke(mi);
                }

                Thread.Sleep(100);
            }

        }

        //public void DoWindowTop()
        //{
        //    string title = "Discord";
        //    IntPtr hWnd = FindWindow(null, title);
        //    int num = hWnd.ToInt32();
        //    if (num != 0)
        //    {
        //        Activate();
        //        //BringWindowToTop(hWnd);
        //    }
        //    checkedMorning = true;
        //}





        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            //Ablak mozgatása
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            //Ablak mozgatása
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel_title_MouseUp(object sender, MouseEventArgs e)
        {
            //Ablak mozgatása
            mov = 0;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //Ablak mozgatása
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //Ablak mozgatása
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //Ablak mozgatása
            mov = 0;
        }

        private void label1_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_ModifiedChanged(object sender, EventArgs e)
        {
            //if (textBox1.TextLength < 3)
            //{
            //    textBox1.ForeColor = Color.Red;
            //} else
            //if (Int32.Parse(textBox1.Text) < 110 && Int32.Parse(textBox1.Text) <= 130)
            //{
            //    textBox1.ForeColor = Color.Green;
            //} else if (Int32.Parse(textBox1.Text) > 130)
            //    textBox1.ForeColor = Color.Orange;


        }


        #region Első textbox
        bool focus = false;
        private void textBox1_Enter(object sender, EventArgs e)
        {
            focus = true;
            this.Refresh();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            focus = false;
            this.Refresh();
        }


        public void EnableRegisterButton()
        {
            if (textbox1_ok && textbox2_ok && textbox3_ok)
            {
                button1_register.Enabled = true;
                button1_register.BackColor = Color.LightSeaGreen;
            }
        }

        public void DisableRegisterButton()
        {
            button1_register.Enabled = false;
            button1_register.BackColor = Color.DimGray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result;
            bool value = Int32.TryParse(textBox1.Text, out result);

            if (value)
            {
                if (textBox1.TextLength < 2)
                {
                    textBox1.ForeColor = Color.Red;
                    textbox1_ok = false;
                }
                else
                if (Int32.Parse(textBox1.Text) < 110 && Int32.Parse(textBox1.Text) > 90)
                {
                    textBox1.ForeColor = Color.Orange;
                    textbox1_ok = true;
                }
                else

             if (Int32.Parse(textBox1.Text) > 110 && Int32.Parse(textBox1.Text) <= 130)
                {
                    textBox1.ForeColor = Color.Green;
                    textbox1_ok = true;
                }
                else if (Int32.Parse(textBox1.Text) > 130 && Int32.Parse(textBox1.Text) <= 150)
                {
                    textBox1.ForeColor = Color.Orange;
                    textbox1_ok = true;
                }
                else if (Int32.Parse(textBox1.Text) > 150)
                {
                    textBox1.ForeColor = Color.Red;
                    textbox1_ok = true;
                }
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                textbox1_ok = false;
            }

            EnableRegisterButton();
        }
        #endregion

        #region Második textbox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int result;
            bool value = Int32.TryParse(textBox2.Text, out result);

            if (value)
            {
                if (textBox2.TextLength < 2)
                {
                    textBox2.ForeColor = Color.Red;
                    textbox2_ok = false;
                }
                else
                if (Int32.Parse(textBox2.Text) < 70 && Int32.Parse(textBox2.Text) > 50)
                {
                    textBox2.ForeColor = Color.Orange;
                    textbox2_ok = true;
                }
                else

             if (Int32.Parse(textBox2.Text) >= 70 && Int32.Parse(textBox2.Text) <= 90)
                {
                    textBox2.ForeColor = Color.Green;
                    textbox2_ok = true;
                }
                else if (Int32.Parse(textBox2.Text) > 90 && Int32.Parse(textBox2.Text) <= 100)
                {
                    textBox2.ForeColor = Color.Orange;
                    textbox2_ok = true;
                }
                else if (Int32.Parse(textBox2.Text) > 100)
                {
                    textBox2.ForeColor = Color.Red;
                    textbox2_ok = true;
                }
            }
            else
            {
                textBox2.ForeColor = Color.Red;
                textbox2_ok = false;
            }

            EnableRegisterButton();
        }
        #endregion

        #region Harmadik textbox

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int result;
            bool value = Int32.TryParse(textBox3.Text, out result);

            if (value)
            {
                if (textBox3.TextLength < 2)
                {
                    textBox3.ForeColor = Color.Red;
                    textbox3_ok = false;
                }
                else
            if (Int32.Parse(textBox3.Text) < 60 && Int32.Parse(textBox3.Text) > 50)
                {
                    textBox3.ForeColor = Color.Orange;
                    textbox3_ok = true;
                }
                else

         if (Int32.Parse(textBox3.Text) >= 60 && Int32.Parse(textBox3.Text) <= 90)
                {
                    textBox3.ForeColor = Color.Green;
                    textbox3_ok = true;
                }
                else if (Int32.Parse(textBox3.Text) > 90 && Int32.Parse(textBox3.Text) <= 100)
                {
                    textBox3.ForeColor = Color.Orange;
                    textbox3_ok = true;
                }
                else if (Int32.Parse(textBox3.Text) > 100)
                {
                    textBox3.ForeColor = Color.Red;
                    textbox3_ok = true;
                }
            }
            else
            {
                textBox3.ForeColor = Color.Red;
                textbox3_ok = false;
            }

            EnableRegisterButton();
        }
        #endregion


        private void button1_register_Click(object sender, EventArgs e)
        {
            string path = @"F:\\Dokumentumok\\HBPM\\Results\\log.txt";
            var fileName = path;
            FileInfo fi = new FileInfo(fileName);
            if (fi.Exists != false)
            {
                var size = fi.Length;
                using (StreamWriter sw = File.AppendText(path))
                {
                    //KIEGÉSZÍTÉSRE VÁR
                    if (CheckTime.NIGHT.Equals(DateTime.Now.Hour))
                    {
                    }

                    if (CheckTime.MORNING.Equals(DateTime.Now.Hour))
                    {
                    }

                    sw.WriteLine(DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day + "." + "\t" + textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text);
                    MessageBox.Show("Heart Rate BPM has been registered", "HBPM REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    System.Diagnostics.Process.Start(path);
                    clearTextBoxes();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Dátum" + "\t\t" + "Sys" + "\t" + "Dia" + "\t" + "Pulzus");
                    sw.WriteLine(DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day + "." + "\t" + textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text);
                    MessageBox.Show("Heart Rate BPM has been registered" + "\n");
                    System.Diagnostics.Process.Start(path);
                }
                clearTextBoxes();
            }
            DisableRegisterButton();
        }

        public void clearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ha jó a három textbox
            if (textbox1_ok && textbox2_ok && textbox3_ok)
            {
                //enter ütés esetén
                if (e.KeyChar == (char)13)
                {
                    button1_register_Click(null, null);
                }
            }

        }
    }
}
