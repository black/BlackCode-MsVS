using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROBOT
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            flowLayoutPanel.VerticalScroll.Enabled = false;
            flowLayoutPanel.VerticalScroll.Visible = false;

            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.WorkingArea.Contains(this.Location))
                {
                    this.Location = new Point(scrn.WorkingArea.Right - this.Width+10, scrn.WorkingArea.Top);
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                this.ShowInTaskbar = false;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Icon = SystemIcons.Application; 
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }

        private void carregarImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            // allow multiple selection
            d.Multiselect = true;

            // filter the desired file types
            d.Filter = "JPG |*.jpg|PNG|*.png|BMP|*.bmp";

            // show the dialog and check if the selection was made

            if (d.ShowDialog() == DialogResult.OK)
            {
                foreach (string image in d.FileNames)
                {
                    // create a new control
                    PictureBox pb = new PictureBox();

                   // pb.Tag = tag;
                 //   btn.Tag = tag;
                   // pb.MouseDown += pictureBox_MouseDown;
                    // assign the image
                    pb.Image = new Bitmap(image);

                   // listaImagens.Add(new Bitmap(image));

                    // stretch the image
                    pb.SizeMode = PictureBoxSizeMode.Zoom;

                    // set the size of the picture box 
                    pb.Width = this.Width-30;
                    pb.Height = 200;
                    // add the control to the container
                    flowLayoutPanel.Controls.Add(pb);
                   // listaPicBoxes.Add(pb);
                   // tag++;

                }

            }

        }

    }
}
