namespace Tyuiu.ShmidtAA.Sprint6.Task7.V9
{
    partial class FormAbout
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
            groupBoxAbout = new GroupBox();
            label1 = new Label();
            pictureBoxGif = new PictureBox();
            groupBoxAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGif).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAbout
            // 
            groupBoxAbout.Controls.Add(pictureBoxGif);
            groupBoxAbout.Controls.Add(label1);
            groupBoxAbout.Dock = DockStyle.Fill;
            groupBoxAbout.Location = new Point(0, 0);
            groupBoxAbout.Name = "groupBoxAbout";
            groupBoxAbout.Size = new Size(800, 450);
            groupBoxAbout.TabIndex = 0;
            groupBoxAbout.TabStop = false;
            groupBoxAbout.Text = "О приложении";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(311, 15);
            label1.TabIndex = 0;
            label1.Text = "Сделал Шмидт Андрей Андреевич, группа ИБКСб-24-1.";
            // 
            // pictureBoxGif
            // 
            pictureBoxGif.Image = Properties.Resources.kitty;
            pictureBoxGif.Location = new Point(6, 46);
            pictureBoxGif.Name = "pictureBoxGif";
            pictureBoxGif.Size = new Size(788, 392);
            pictureBoxGif.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGif.TabIndex = 1;
            pictureBoxGif.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxAbout);
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О приложении";
            groupBoxAbout.ResumeLayout(false);
            groupBoxAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAbout;
        private Label label1;
        private PictureBox pictureBoxGif;
    }
}