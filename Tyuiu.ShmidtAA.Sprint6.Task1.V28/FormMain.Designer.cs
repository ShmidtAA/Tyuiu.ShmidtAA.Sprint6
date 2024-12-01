namespace Tyuiu.ShmidtAA.Sprint6.Task1.V28
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
            TextBoxStartStepSAA = new TextBox();
            groupBoxConditionSAA = new GroupBox();
            pictureBoxFormulaSAA = new PictureBox();
            labelConditionSAA = new Label();
            groupBoxVarsSAA = new GroupBox();
            labelEnd = new Label();
            TextBoxStopStepSAA = new TextBox();
            labelStart = new Label();
            groupBoxOutput = new GroupBox();
            buttonHelp = new Button();
            groupBoxConditionSAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).BeginInit();
            groupBoxVarsSAA.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonResultSAA
            // 
            ButtonResultSAA.BackColor = SystemColors.ActiveCaption;
            ButtonResultSAA.Location = new Point(328, 370);
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
            TextBoxResultSAA.Location = new Point(5, 22);
            TextBoxResultSAA.Multiline = true;
            TextBoxResultSAA.Name = "TextBoxResultSAA";
            TextBoxResultSAA.ReadOnly = true;
            TextBoxResultSAA.Size = new Size(249, 396);
            TextBoxResultSAA.TabIndex = 5;
            TextBoxResultSAA.Text = "Результат";
            TextBoxResultSAA.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxStartStepSAA
            // 
            TextBoxStartStepSAA.Location = new Point(6, 42);
            TextBoxStartStepSAA.Name = "TextBoxStartStepSAA";
            TextBoxStartStepSAA.Size = new Size(100, 23);
            TextBoxStartStepSAA.TabIndex = 0;
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
            pictureBoxFormulaSAA.Location = new Point(112, 69);
            pictureBoxFormulaSAA.Name = "pictureBoxFormulaSAA";
            pictureBoxFormulaSAA.Size = new Size(344, 61);
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
            groupBoxVarsSAA.Controls.Add(labelEnd);
            groupBoxVarsSAA.Controls.Add(TextBoxStopStepSAA);
            groupBoxVarsSAA.Controls.Add(labelStart);
            groupBoxVarsSAA.Controls.Add(TextBoxStartStepSAA);
            groupBoxVarsSAA.Location = new Point(12, 357);
            groupBoxVarsSAA.Name = "groupBoxVarsSAA";
            groupBoxVarsSAA.Size = new Size(319, 73);
            groupBoxVarsSAA.TabIndex = 8;
            groupBoxVarsSAA.TabStop = false;
            groupBoxVarsSAA.Text = "Входные данные:";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(136, 24);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(72, 15);
            labelEnd.TabIndex = 12;
            labelEnd.Text = "Конец шага";
            // 
            // TextBoxStopStepSAA
            // 
            TextBoxStopStepSAA.Location = new Point(136, 42);
            TextBoxStopStepSAA.Name = "TextBoxStopStepSAA";
            TextBoxStopStepSAA.Size = new Size(100, 23);
            TextBoxStopStepSAA.TabIndex = 1;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 24);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(69, 15);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(TextBoxResultSAA);
            groupBoxOutput.Location = new Point(534, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(254, 426);
            groupBoxOutput.TabIndex = 9;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(260, 375);
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
            Controls.Add(ButtonResultSAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 28 | Шмидт А.А.";
            Load += FormMain_Load;
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
        private TextBox TextBoxStartStepSAA;
        private GroupBox groupBoxConditionSAA;
        private Label labelConditionSAA;
        private GroupBox groupBoxVarsSAA;
        private Label labelStart;
        private GroupBox groupBoxOutput;
        private PictureBox pictureBoxFormulaSAA;
        private Button buttonHelp;
        private Label labelEnd;
        private TextBox TextBoxStopStepSAA;
    }
}
