using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrageAndDrop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_mouseDown(object sender, MouseEventArgs e)
        {
          //  pictureBox2.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           // pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image,DragDropEffects.Copy);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
          //  pictureBox3.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            pictureBox4.AllowDrop = true;
            label3.Visible = false;

        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            label3.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox4_DragLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            label3.Visible = false;
            Image getPicture =(Bitmap) e.Data.GetData(DataFormats.Bitmap);
            pictureBox4.Image = getPicture;
        }
    }
}
