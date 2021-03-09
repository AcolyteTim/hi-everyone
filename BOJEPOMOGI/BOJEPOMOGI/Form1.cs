using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BOJEPOMOGI
{
    public partial class Form1 : Form
    {
        RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"Software\ProgWF");

        public Form1()
        {
            InitializeComponent();
           
            int Openning = Properties.Settings.Default.OpenNum;

            if (Openning == 0)
            {
                Key.SetValue("Параметр текста", "");
                Key.SetValue("Параметр цвета", "");
                Key.SetValue("Параметр ширины", 500);
                Key.SetValue("Параметр высоты", 500);
            }

            using (Key.OpenSubKey(@"Software\ProgWF"))
            {
                textBox1.Text = Key.GetValue("Параметр Текста").ToString();
                string ColorBG = (string)Key.GetValue("Параметр Цвета");
                this.BackColor = ColorTranslator.FromHtml(ColorBG);
                this.Height = (int)Key.GetValue("Параметр высоты");
                this.Width = (int)Key.GetValue("Параметр ширины");

            }

            Openning++;
            Properties.Settings.Default.OpenNum = Openning;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        ///////////////////////////////////////
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            using (Key.OpenSubKey(@"Software\ProgWF"))
            {
                string TextParameter = textBox1.Text;
                Key.SetValue("Параметр текста", TextParameter);
            }
        }

        private void label1_Click(object sender, EventArgs e){ }
        ///////////////////////////////////////
        private void label3_Click(object sender, EventArgs e){ } 
                                                                    
        private void button1_Click(object sender, EventArgs e)
        {                                                           
            this.BackColor = Color.Black;                           
            String Colors = "#FF000000";                            
            Key.SetValue("Параметр Цвета", Colors);                 
        }                                                           
                                                                    
        private void button2_Click(object sender, EventArgs e)
        {                                                           
            this.BackColor = Color.White;                           
            String Colors = "#FFFFFFFF";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            String Colors = "#FF0000FF";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            String Colors = "#FFFF0000";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            String Colors = "#FFFFFF00";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            String Colors = "#FF008000";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            String Colors = "#FF800080";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            String Colors = "#FFFFC0CB";
            Key.SetValue("Параметр Цвета", Colors);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var random = new Random();
            Color c;
            unchecked
            {
                c = Color.FromArgb((int)0xFF000000 + (random.Next(0xFFFFFF) & 0x7F7F7F));
            }
            this.BackColor = c;
        }
        private void label2_Click(object sender, EventArgs e){ }
        ///////////////////////////////////////

        private void label4_Click(object sender, EventArgs e){ }

        private void button10_Click(object sender, EventArgs e)
        {
            int Width = 590;
            int Height = 330;

            this.Width = Width;
            this.Height = Height;
            Key.SetValue("Параметр ширины", Width);
            Key.SetValue("Параметр высоты", Height);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int Width = 619;
            int Height = 410;

            this.Width = Width;
            this.Height = Height;
            Key.SetValue("Параметр ширины", Width);
            Key.SetValue("Параметр высоты", Height);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Width = 775;
            int Height = 515;

            this.Width = Width;
            this.Height = Height;
            Key.SetValue("Параметр ширины", Width);
            Key.SetValue("Параметр высоты", Height);
        }
    }
}