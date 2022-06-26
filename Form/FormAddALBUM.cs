using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public partial class FormAddALBUM : Form
    {
      
        public FormAddALBUM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
            
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 F = new Form2();
            if (F.TXT1 == this.textBox1.Text|| F.TXT2 == this.textBox1.Text)
            {
                
                WrongName w = new WrongName();
                w.TN = "Така назва альбому вже існює,будь ласка,виберіть іншу)";
                w.ShowDialog();
            }
            else
            {
                F.Show();
                DateTime thisDay = DateTime.Today;
                F.TXT = this.textBox1.Text;
                F.NMR = "0";
                F.DOP = thisDay.ToString("d");
                F.AddPictureForBackGround(this.pictureBox1.Image);
                pictureBox2.Image = Image.FromFile(@"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\INFORM.png");
                F.AddPictureForInform(this.pictureBox2.Image);
                this.Close();
                
            }
        }

        private void FormAddALBUM_Load(object sender, EventArgs e)
        {

        }
    }
}
