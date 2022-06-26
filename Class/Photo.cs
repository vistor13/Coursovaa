using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public class Photo:Base<Photo>
    {
        public string photopath { get; set; }
        public string Data { get; set; }
        public string Geo { get; set; }
        public string Name { get; set; }
        private Guid _AlbumId;
        public Album albums
        {
            get { return Album.It[_AlbumId]; }
            set { _AlbumId = value.Id; }
        }
       public Photo() { }
       
        public static void AddPicture(PictureBox pb,Label LB1,Label LB2, Photo p1)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Image = new Bitmap(ofd.FileName);
                LB2.Text = p1.Data;
                LB1.Text = p1.Geo;
            }
        }
      
        public static void Inform(Label LB1,Label LB2,PictureBox p ,Photo P1)
        {
            p.Image = Image.FromFile(P1.photopath);
            LB1.Text = P1.Data;
            LB2.Text = P1.Geo;

        }
        public static void SaveFile(string path,Photo p1)
        {
            string text1 = Photo.TextOfPhoto(p1);
            using (StreamWriter s = File.AppendText(path))
            {
                s.WriteLine(text1);
            }
        }
        public static void ReWriteTextFile(string path)
        {
            string g = " ";
            File.WriteAllText(path, g);
        }
        public static string TextOfPhoto(Photo p)
        {
           return $"Місце : " + p.Geo + " " + " Дата: " + p.Data;
        }
        public static void AddPicturesOfInform(Label LB,PictureBox PB,string file)
        {
            if (!string.IsNullOrEmpty(LB.Text))
            {
                PB.Image = Image.FromFile(file);
            } 
        }
       
    }
}
