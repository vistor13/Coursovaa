using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public partial class photo1_2cs : Form
    {
        public photo1_2cs()
        {
            InitializeComponent();
        }
        int p = 1;
        int p1 = 1;
        string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info2.txt";

        string file1 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\свойства.jpg";
        Album ALBUM = new Album();
        private void button1_Click(object sender, EventArgs e)
        {
            Photo photo10 = new Photo() { Data = "2020", Geo = "Київ" ,albums=ALBUM};
            Photo photo11 = new Photo() { Data = "2020", Geo = "Київ", albums = ALBUM };
            Photo photo12 = new Photo() { Data = "2021", Geo = "Київ", albums = ALBUM };
            Photo photo13 = new Photo() { Data = "2019", Geo = "Київ", albums = ALBUM };
            Photo photo14 = new Photo() { Data = "2022", Geo = "Київ", albums = ALBUM };
            Photo photo15 = new Photo() { Data = "2021", Geo = "Київ", albums = ALBUM };
            Photo photo16 = new Photo() { Data = "2022", Geo = "Київ", albums = ALBUM };




            if (p == 1)
            {
                Photo.AddPicture(pictureBox10, label21, label20, photo10);
                Photo.AddPicturesOfInform(label21, pictureBox31, file1);
                Photo.SaveFile(path2, photo10);
             
                p++;
               
            }
            else if (p == 2)
            {
              
                Photo.AddPicture(pictureBox11, label23, label22, photo11);
                Photo.AddPicturesOfInform(label23, pictureBox32, file1);
                Photo.SaveFile(path2, photo11);
          
                p++;
               
            }
            else if (p == 3)
            {
               
                Photo.AddPicture(pictureBox12, label25, label24, photo12);
                Photo.AddPicturesOfInform(label25, pictureBox17, file1);
                Photo.SaveFile(path2, photo12);
               
                p++;
                
            }
            else if (p == 4)
            {
                
                Photo.AddPicture(pictureBox13, label27, label26, photo13);
                Photo.AddPicturesOfInform(label27, pictureBox18, file1);
                Photo.SaveFile(path2, photo13);
                

                p++;
                
            }
            else if (p == 5)
            {
                
                Photo.AddPicture(pictureBox14, label29, label28, photo14);
                Photo.AddPicturesOfInform(label29, pictureBox19, file1);
                Photo.SaveFile(path2, photo14);
              

                p++;
                
            }
            else if (p == 6)
            {
                
                Photo.AddPicture(pictureBox14, label31, label30, photo15);

                Photo.AddPicturesOfInform(label31, pictureBox20, file1);
                Photo.SaveFile(path2, photo15);
                
                p++;
                
            }
            else if (p == 7)
            {
                
                Photo.AddPicture(pictureBox14, label33, label32, photo16);
                Photo.AddPicturesOfInform(label33, pictureBox21, file1);
                Photo.SaveFile(path2, photo16);
              
                p++;
                
            }
            else if (p == 8)
            {
                Wrong w = new Wrong();
                w.ShowDialog();

            }
        }
        private void photo1_2cs_Load(object sender, EventArgs e)
        {
           
            foreach (var i1 in Photo.It.Values.Where(l1 => l1.albums.Name == "Школа"))
            {
                if (p1 == 1) { Photo.Inform(label3, label2, pictureBox1,i1); p1++; }
                else if (p1 == 2) { Photo.Inform(label4, label5, pictureBox1, i1); p1++; }
                else if (p1 == 3) { Photo.Inform(label6, label7, pictureBox1, i1); p1++; }
                else if (p1 == 4) { Photo.Inform(label8, label9, pictureBox1,  i1); p1++; }
                else if (p1 == 5) { Photo.Inform(label10, label11, pictureBox1, i1); p1++; }
                else if (p1 == 6) { Photo.Inform(label12, label13, pictureBox1, i1); p1++; }
                else if (p1 == 7) { Photo.Inform(label14, label15, pictureBox1, i1); p1++; }
                else if (p1 == 8) { Photo.Inform(label16, label17, pictureBox1, i1); p1++; }
                else if (p1 == 9) { Photo.Inform(label18, label19, pictureBox1,  i1); p1++; }
            

            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label2.Text + " " + " Дата: " + label3.Text;
            fsip.ShowDialog();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label5.Text + " " + " Дата: " + label4.Text;
            fsip.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label7.Text + " " + " Дата: " + label6.Text;
            fsip.ShowDialog();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label9.Text + " " + " Дата: " + label8.Text;
            fsip.ShowDialog();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label11.Text + " " + " Дата: " + label10.Text;
            fsip.ShowDialog();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label13.Text + " " + " Дата: " + label12.Text;
            fsip.ShowDialog();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label15.Text + " " + " Дата: " + label14.Text;
            fsip.ShowDialog();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label17.Text + " " + " Дата: " + label16.Text;
            fsip.ShowDialog();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label19.Text + " " + " Дата: " + label18.Text;
            fsip.ShowDialog();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label21.Text + " " + " Дата: " + label20.Text;
            fsip.ShowDialog();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label23.Text + " " + " Дата: " + label22.Text;
            fsip.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label25.Text + " " + " Дата: " + label24.Text;
            fsip.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label27.Text + " " + " Дата: " + label26.Text;
            fsip.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label29.Text + " " + " Дата: " + label28.Text;
            fsip.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label31.Text + " " + " Дата: " + label30.Text;
            fsip.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            FormShowInfoPhoto fsip = new FormShowInfoPhoto();
            fsip.TN = "Місце : " + label33.Text + " " + " Дата: " + label32.Text;
            fsip.ShowDialog();
        }
        private void bProperties1_Click(object sender, EventArgs e)
        {
            
            SecondAlbumForm saf = new SecondAlbumForm();
            saf.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox1.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox3.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox4.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox5.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox6.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox7.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox8.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox9.Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox10.Image);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox11.Image);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox12.Image);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox13.Image);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox14.Image);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox15.Image);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            openphoto F = new openphoto();
            F.Show();
            F.OpenPicture(this.pictureBox16.Image);
        }
    }
}
