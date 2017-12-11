using System;
using System.Collections.Generic; 
using System.Drawing;
using System.IO; 
using System.Windows.Forms;

namespace Infinity
{
    public partial class InfinityBox : Form
    {
        List<String> allImages = new List<String>();
        int k = 0;
        String filepath = null;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }

        }

        public InfinityBox(String[] file)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            if (file.Length != 0)
                filepath = file[0];
        }

        private void InfinityBox_Load(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                String pathDirectory = Path.GetDirectoryName(filepath);
                allImages = GetImagesPath(pathDirectory);
                k = allImages.IndexOf(filepath);
                fitImage(filepath);
            }
        }
         
        public List<String> GetImagesPath(String folderName)
        {
            List<String> imagesList = new List<String>();
            var extensionList = new List<string> { "*.jpg", "*.gif", "*.png", "*.bmp", "*.jpeg" };
            foreach (String fileExtension in extensionList)
            {
                foreach (String file in Directory.GetFiles(folderName, fileExtension))  /* to get all files  from sub directories:   foreach (String file in Directory.GetFiles(folderName, fileExtension, SearchOption.AllDirectories)) */

                {
                    imagesList.Add(file);
                }
            }

            return imagesList;
        }

        private void fitImage(String path)
        {
            pictureBox.Image = Image.FromFile(path);
            int imgWidth = pictureBox.Image.Size.Width;
            int imgHeight = pictureBox.Image.Size.Height;
            int pBoxWidth = pictureBox.Size.Width;
            int pBoxHeight = pictureBox.Size.Height;

            if (imgWidth > pBoxWidth || imgHeight > pBoxHeight)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            closeButton.Parent = pictureBox; // for transparent picturebox button
            pictureInfo.Parent = pictureBox; // for transparent picturebox button
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                //do something here
            }
            else//left or middle click
            {
                //do something here

                OpenFileDialog ofd = new OpenFileDialog();
                // ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*bmp)|*.bmp|png (*.png)|*png|gif (*.gif)|*.gif";

                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
                {
                    String path = ofd.FileName;
                    String pathDirectory = Path.GetDirectoryName(path);
                    allImages = GetImagesPath(pathDirectory);
                    k = allImages.IndexOf(path);
                    fitImage(path);
                    //  Dispose();
                    if (pictureBox.BackgroundImage != null)
                    {
                        pictureBox.BackgroundImage.Dispose();
                        pictureBox.BackgroundImage = null;
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right)
            {
                goNext();
            }
            if (keyData == Keys.Left)
            {
                goPrev();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void goNext()
        {
            if (k < allImages.Count - 1 && allImages.Count > 0)
            {
                k++;
                getPicture(k);
            }
            else k = 0;
        }

        void goPrev()
        {
            if (0 < k && allImages.Count > 0)
            {
                k--;
                getPicture(k);
            }
            else k = allImages.Count - 1;
        }
        void getPicture(int m)
        {
            String nextFile = allImages[m];
            fitImage(nextFile);
        }

        private void pictureInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
