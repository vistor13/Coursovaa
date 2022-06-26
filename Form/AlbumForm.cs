using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coursovaa
{
    public partial class Form2 : Form
    {
        public string TXT
        {
            get { return AddLabel1.Text; }
            set { AddLabel1.Text = value; }
        }
        public string TXT1
        {
            get { return label1.Text; }
            set { label1.Text = value; }

        }
        public string TXT2
        {
            get { return label3.Text; }
            set { label3.Text = value; }

        }

        public string NMR
        {
            get { return label7.Text; }
            set { label7.Text = value;}
        }
        public string DOP
        {
            get { return labelAdd.Text; }
            set { labelAdd.Text = value; }
        }

        string str1="";
        string str2="";
        string path1 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info1.txt";
        string path2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\info2.txt";
        string ph1 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\1.jpg";
        string ph2 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\2.jpg";
        string ph3 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\3.jpg";
        string ph4 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\4.jpg";
        string ph5 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\5.jpg";
        string ph6 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\6.jpg";
        string ph7 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\7.jpg";
        string ph8 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\8.jpg";
        string ph9 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\9.jpg";
        string ph10 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\10.jpg";
        string ph11 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\Сім'я\11.jpg";
        string ph12 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\1.jpg";
        string ph13 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\2.jpg";
        string ph14= @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\3.jpg";
        string ph15 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\4.jpg";
        string ph16= @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\5.jpg";
        string ph17 = @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\6.jpg";
        string ph18= @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\7.jpg";
        string ph19= @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\8.jpg";
        string ph20= @"C:\кпи\кпи 1 курс 2 семестр\курсова\Coursovaa1\школа\9.jpg";
        internal void AddPictureForBackGround(Image img)
        {
            Image iOld = this.pictureBoxAdd1.Image;
            this.pictureBoxAdd1.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();
        }
        internal void AddPictureForInform(Image img)
        {
            Image iOld = this.pictureBox3.Image;
            this.pictureBox3.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();
        }

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int p = 1;
            if(p==1)
            {
                FormAddALBUM FormAddal = new FormAddALBUM();
                FormAddal.Show();
                this.Close();
            }
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            Album a1 = new Album() { Name = "Сім'я", valuesofphoto = "11", Data = "13.10.2017" };
            Album.InformOfAlbum(label1, label8, label2, a1);
            Photo photo1 = new Photo() { Geo = " Коростень ", Data = "2019", albums = a1 , photopath = ph1,Name="Подорожі"};
            Photo photo2 = new Photo() { Geo = " Київ ", Data = "2022", albums = a1, photopath = ph2, Name = "Новий Рік" };
            Photo photo3 = new Photo() { Geo = " Одеса ", Data = "2019", albums = a1, photopath = ph3, Name = "Новий Рік" };
            Photo photo4 = new Photo() { Geo = " Маріуполь ", Data = "2019", albums = a1, photopath = ph4, Name = "Новий Рік" };
            Photo photo5 = new Photo() { Geo = " Коростень ", Data = "2022", albums = a1, photopath = ph5, Name = "Новий Рік" };
            Photo photo6 = new Photo() { Geo = " Київ  ", Data = "2022", albums = a1, photopath = ph6, Name = "Подорожі" };
            Photo photo7 = new Photo() { Geo = " Київ  ", Data = "2022", albums = a1, photopath = ph7, Name = "Подорожі" };
            Photo photo8 = new Photo() { Geo = " Коростень ", Data = "2020", albums = a1, photopath = ph8, Name = "Подорожі" };
            Photo photo9 = new Photo() { Geo = " Київ  ", Data = "2021", albums = a1, photopath = ph9, Name = "Подорожі" };
            Photo photo10 = new Photo() { Geo = " Коростень ", Data = "2020", albums = a1, photopath = ph10, Name = "Новий Рік" };
            Photo photo11 = new Photo() { Geo = " Київ  ", Data = "2019", albums = a1, photopath = ph11, Name = "Подорожі" };
            Album a2 = new Album() { Name = "Школа", valuesofphoto = "9", Data = "27.01.2019" };
            Album.InformOfAlbum(label3, label9, label4, a2);
            Photo photo12 = new Photo() { Geo = " Коростень ", Data = "2020", albums = a2, photopath = ph12, Name = "Перший звоник" };
            Photo photo13 = new Photo() { Geo = " Київ ", Data = "2021", albums = a2, photopath = ph13 , Name = "Перший звоник" };
            Photo photo14 = new Photo() { Geo = " Одеса ", Data = "2017", albums = a2, photopath = ph14, Name = "Хімія" };
            Photo photo15 = new Photo() { Geo = " Маріуполь ", Data = "2018", albums = a2, photopath = ph15, Name = "Хімія" };
            Photo photo16 = new Photo() { Geo = " Коростень ", Data = "2017", albums = a2, photopath = ph16, Name = "Перший звоник" };
            Photo photo17 = new Photo() { Geo = " Київ  ", Data = "2019", albums = a2, photopath = ph17, Name = "Перший звоник" };
            Photo photo18 = new Photo() { Geo = " Київ  ", Data = "2019", albums = a2, photopath = ph18, Name = "Перший звоник" };
            Photo photo19 = new Photo() { Geo = " Коростень ", Data = "2019", albums = a2, photopath = ph19, Name = "Хімія" };
            Photo photo20 = new Photo() { Geo = " Київ  ", Data = "2019", albums = a2, photopath = ph20, Name = "Хімія" };
            Photo.SaveFile(path1, photo1);
            Photo.SaveFile(path1, photo2);
            Photo.SaveFile(path1, photo3);
            Photo.SaveFile(path1, photo4);
            Photo.SaveFile(path1, photo5);
            Photo.SaveFile(path1, photo6);
            Photo.SaveFile(path1, photo7);
            Photo.SaveFile(path1, photo8);
            Photo.SaveFile(path1, photo9);
            Photo.SaveFile(path1, photo10);
            Photo.SaveFile(path1, photo11);
            Photo.SaveFile(path2, photo12);
            Photo.SaveFile(path2, photo13);
            Photo.SaveFile(path2, photo14);
            Photo.SaveFile(path2, photo15);
            Photo.SaveFile(path2, photo16);
            Photo.SaveFile(path2, photo17);
            Photo.SaveFile(path2, photo18);
            Photo.SaveFile(path2, photo19);
            Photo.SaveFile(path2, photo20);
           
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            photo1 p = new photo1();
            Album.OpenAlbum(p);

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            photo1_2cs p = new photo1_2cs();
         Album.OpenAlbum(p);
        }
        private void pictureBoxAdd1_Click(object sender, EventArgs e)
        {
            photo2 ph = new photo2();
            Album.OpenAlbum(ph);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            FormInformAlbum FI = new FormInformAlbum();
            FI.TN = this.label1.Text;
            FI.TV = this.label2.Text;
            FI.DT = this.label8.Text;
            FI.ShowDialog();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            FormInformAlbum FI2 = new FormInformAlbum();
            FI2.TN = this.label3.Text;
            FI2.TV = this.label4.Text;
            FI2.DT = this.label9.Text;
            FI2.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormInformAlbum FI2 = new FormInformAlbum();
            FI2.TN = this.AddLabel1.Text;
            FI2.TV = this.label7.Text;
            FI2.DT = this.labelAdd.Text;
            FI2.ShowDialog();
        }
    }
}
