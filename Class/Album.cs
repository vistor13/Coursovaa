using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public class Album:Base<Album>
    {
     public string Name { get; set; }
     public string valuesofphoto { get; set; }
     public string Data { get; set; }  
        public List<Photo> Photos
        {
            get
            {
                List<Photo> result = new List<Photo>();
                foreach(var i in Photo.It.Values)
                {
                    if (i.albums == this)
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
        }

        public Album() {}
        public static void InformOfAlbum(Label Lb1,Label LB2,Label LB3,Album A)
        {
          
            Lb1.Text = A.Name;
            LB2.Text = A.Data;
            LB3.Text = A.valuesofphoto;
        }
       public static void OpenAlbum(Form f)
        {
           f.ShowDialog();
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
