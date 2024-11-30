namespace Tyuiu.ShmidtAA.Sprint6.Task0.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonResultSAA = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            TextBoxResultSAA = new TextBox();
            TextBoxVarSAA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonResultSAA
            // 
            ButtonResultSAA.BackColor = SystemColors.ActiveCaption;
            ButtonResultSAA.Location = new Point(561, 354);
            ButtonResultSAA.Name = "ButtonResultSAA";
            ButtonResultSAA.Size = new Size(200, 60);
            ButtonResultSAA.TabIndex = 0;
            ButtonResultSAA.Text = "Выполнить";
            ButtonResultSAA.UseVisualStyleBackColor = false;
            ButtonResultSAA.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 250);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(600, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 83);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TextBoxResultSAA
            // 
            TextBoxResultSAA.Location = new Point(617, 314);
            TextBoxResultSAA.Name = "TextBoxResultSAA";
            TextBoxResultSAA.Size = new Size(131, 23);
            TextBoxResultSAA.TabIndex = 5;
            TextBoxResultSAA.Text = "Результат";
            TextBoxResultSAA.TextAlign = HorizontalAlignment.Center;
            TextBoxResultSAA.TextChanged += TextBoxResultSAA_TextChanged;
            // 
            // TextBoxVarSAA
            // 
            TextBoxVarSAA.Location = new Point(203, 342);
            TextBoxVarSAA.Name = "TextBoxVarSAA";
            TextBoxVarSAA.Size = new Size(100, 23);
            TextBoxVarSAA.TabIndex = 1;
            TextBoxVarSAA.Text = "Переменная х";
            TextBoxVarSAA.KeyPress += textBoxVar_KeyPress;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxVarSAA);
            Controls.Add(TextBoxResultSAA);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(ButtonResultSAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Шмидт А.А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonResultSAA;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox TextBoxResultSAA;
        private TextBox TextBoxVarSAA;
    }
}
