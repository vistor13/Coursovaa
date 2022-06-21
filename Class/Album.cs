using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursovaa
{
    public class Album
    {
     public string Name { get; set; }
     public string valuesofphoto { get; set; }
     public string Data { get; set; }
        public static void OpenAlbum(Form f)
        {
            f.ShowDialog();
            f.Hide();
        }
        
        public static void ShowProperties()
        {
            FirstAlbumForm f = new FirstAlbumForm();
            f.ShowDialog();
        }
        


    }
}
