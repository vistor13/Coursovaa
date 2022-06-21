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
    public partial class openphoto : Form
    {
        public openphoto()
        {
            InitializeComponent();
        }
        internal void OpenPicture(Image img)
        {
            Image iOld = this.pictureBox1.Image;
            this.pictureBox1.Image = (Image)img.Clone();
            if (iOld != null)
                iOld.Dispose();

        }

      
    }
}
