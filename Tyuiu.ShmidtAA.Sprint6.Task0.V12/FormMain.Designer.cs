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
            TextBoxResultSAA = new TextBox();
            TextBoxVarSAA = new TextBox();
            gifBoxPrincessSAA = new PictureBox();
            groupBoxConditionSAA = new GroupBox();
            pictureBoxFormulaSAA = new PictureBox();
            labelConditionSAA = new Label();
            groupBoxVarsSAA = new GroupBox();
            labelVarX = new Label();
            groupBoxOutput = new GroupBox();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)gifBoxPrincessSAA).BeginInit();
            groupBoxConditionSAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).BeginInit();
            groupBoxVarsSAA.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonResultSAA
            // 
            ButtonResultSAA.BackColor = SystemColors.ActiveCaption;
            ButtonResultSAA.Location = new Point(570, 378);
            ButtonResultSAA.Name = "ButtonResultSAA";
            ButtonResultSAA.Size = new Size(200, 60);
            ButtonResultSAA.TabIndex = 0;
            ButtonResultSAA.Text = "Выполнить";
            ButtonResultSAA.UseVisualStyleBackColor = false;
            ButtonResultSAA.Click += buttonResult_Click;
            // 
            // TextBoxResultSAA
            // 
            TextBoxResultSAA.BackColor = SystemColors.ControlLight;
            TextBoxResultSAA.Location = new Point(5, 58);
            TextBoxResultSAA.Name = "TextBoxResultSAA";
            TextBoxResultSAA.ReadOnly = true;
            TextBoxResultSAA.Size = new Size(131, 23);
            TextBoxResultSAA.TabIndex = 5;
            TextBoxResultSAA.Text = "Результат";
            TextBoxResultSAA.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxVarSAA
            // 
            TextBoxVarSAA.Location = new Point(6, 62);
            TextBoxVarSAA.Name = "TextBoxVarSAA";
            TextBoxVarSAA.Size = new Size(100, 23);
            TextBoxVarSAA.TabIndex = 0;
            TextBoxVarSAA.KeyPress += textBoxVar_KeyPress;
            // 
            // gifBoxPrincessSAA
            // 
            gifBoxPrincessSAA.Image = (Image)resources.GetObject("gifBoxPrincessSAA.Image");
            gifBoxPrincessSAA.Location = new Point(570, 53);
            gifBoxPrincessSAA.Name = "gifBoxPrincessSAA";
            gifBoxPrincessSAA.Size = new Size(200, 122);
            gifBoxPrincessSAA.SizeMode = PictureBoxSizeMode.StretchImage;
            gifBoxPrincessSAA.TabIndex = 6;
            gifBoxPrincessSAA.TabStop = false;
            // 
            // groupBoxConditionSAA
            // 
            groupBoxConditionSAA.Controls.Add(pictureBoxFormulaSAA);
            groupBoxConditionSAA.Controls.Add(labelConditionSAA);
            groupBoxConditionSAA.Location = new Point(48, 39);
            groupBoxConditionSAA.Name = "groupBoxConditionSAA";
            groupBoxConditionSAA.Size = new Size(462, 136);
            groupBoxConditionSAA.TabIndex = 7;
            groupBoxConditionSAA.TabStop = false;
            groupBoxConditionSAA.Text = "Условие";
            // 
            // pictureBoxFormulaSAA
            // 
            pictureBoxFormulaSAA.Image = (Image)resources.GetObject("pictureBoxFormulaSAA.Image");
            pictureBoxFormulaSAA.Location = new Point(240, 19);
            pictureBoxFormulaSAA.Name = "pictureBoxFormulaSAA";
            pictureBoxFormulaSAA.Size = new Size(181, 97);
            pictureBoxFormulaSAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormulaSAA.TabIndex = 10;
            pictureBoxFormulaSAA.TabStop = false;
            // 
            // labelConditionSAA
            // 
            labelConditionSAA.AutoSize = true;
            labelConditionSAA.Location = new Point(6, 19);
            labelConditionSAA.Name = "labelConditionSAA";
            labelConditionSAA.Size = new Size(208, 15);
            labelConditionSAA.TabIndex = 0;
            labelConditionSAA.Text = "Вычислить выражение по формуле.\r\n";
            // 
            // groupBoxVarsSAA
            // 
            groupBoxVarsSAA.Controls.Add(labelVarX);
            groupBoxVarsSAA.Controls.Add(TextBoxVarSAA);
            groupBoxVarsSAA.Location = new Point(54, 275);
            groupBoxVarsSAA.Name = "groupBoxVarsSAA";
            groupBoxVarsSAA.Size = new Size(319, 100);
            groupBoxVarsSAA.TabIndex = 8;
            groupBoxVarsSAA.TabStop = false;
            groupBoxVarsSAA.Text = "Входные данные:";
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(6, 44);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(89, 15);
            labelVarX.TabIndex = 2;
            labelVarX.Text = "Переменная X:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(TextBoxResultSAA);
            groupBoxOutput.Location = new Point(502, 275);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(268, 97);
            groupBoxOutput.TabIndex = 9;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(502, 383);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(50, 50);
            buttonHelp.TabIndex = 10;
            buttonHelp.Text = " ?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxVarsSAA);
            Controls.Add(groupBoxConditionSAA);
            Controls.Add(gifBoxPrincessSAA);
            Controls.Add(ButtonResultSAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Шмидт А.А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)gifBoxPrincessSAA).EndInit();
            groupBoxConditionSAA.ResumeLayout(false);
            groupBoxConditionSAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).EndInit();
            groupBoxVarsSAA.ResumeLayout(false);
            groupBoxVarsSAA.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonResultSAA;
        private TextBox TextBoxResultSAA;
        private TextBox TextBoxVarSAA;
        private PictureBox gifBoxPrincessSAA;
        private GroupBox groupBoxConditionSAA;
        private Label labelConditionSAA;
        private GroupBox groupBoxVarsSAA;
        private Label labelVarX;
        private GroupBox groupBoxOutput;
        private PictureBox pictureBoxFormulaSAA;
        private Button buttonHelp;
    }
}
