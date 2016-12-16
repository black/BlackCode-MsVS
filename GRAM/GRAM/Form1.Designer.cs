namespace Gram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.fitToScreen = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.setAsDesktop = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoSize = true;
            this.tableLayout.BackColor = System.Drawing.Color.White;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayout.Controls.Add(this.panel1, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayout.Size = new System.Drawing.Size(807, 457);
            this.tableLayout.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.openFile);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.fitToScreen);
            this.panel1.Controls.Add(this.prevButton);
            this.panel1.Controls.Add(this.setAsDesktop);
            this.panel1.Location = new System.Drawing.Point(286, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 46);
            this.panel1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(191, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = " ";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(144, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(40, 40);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = " ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // fitToScreen
            // 
            this.fitToScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fitToScreen.BackgroundImage")));
            this.fitToScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fitToScreen.FlatAppearance.BorderSize = 0;
            this.fitToScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fitToScreen.Location = new System.Drawing.Point(97, 4);
            this.fitToScreen.Name = "fitToScreen";
            this.fitToScreen.Size = new System.Drawing.Size(40, 40);
            this.fitToScreen.TabIndex = 2;
            this.fitToScreen.Text = " ";
            this.fitToScreen.UseVisualStyleBackColor = true;
            this.fitToScreen.Click += new System.EventHandler(this.fitToScreen_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevButton.BackgroundImage")));
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevButton.FlatAppearance.BorderSize = 0;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Location = new System.Drawing.Point(50, 4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(40, 40);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = " ";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // setAsDesktop
            // 
            this.setAsDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setAsDesktop.BackgroundImage")));
            this.setAsDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.setAsDesktop.FlatAppearance.BorderSize = 0;
            this.setAsDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAsDesktop.Location = new System.Drawing.Point(3, 3);
            this.setAsDesktop.Name = "setAsDesktop";
            this.setAsDesktop.Size = new System.Drawing.Size(40, 40);
            this.setAsDesktop.TabIndex = 0;
            this.setAsDesktop.Text = " ";
            this.setAsDesktop.UseVisualStyleBackColor = true;
            this.setAsDesktop.Click += new System.EventHandler(this.setAsDesktop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 457);
            this.Controls.Add(this.tableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "Form1";
            this.Text = "G R A M";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setAsDesktop;
        private System.Windows.Forms.Button fitToScreen;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button nextButton;
    }
}

