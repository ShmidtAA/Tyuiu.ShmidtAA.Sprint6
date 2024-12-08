namespace Tyuiu.ShmidtAA.Sprint6.Task6.V15
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonLoadFile = new Button();
            groupBoxCondition = new GroupBox();
            labelCondtion = new Label();
            panelLeft = new Panel();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            panelRight = new Panel();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            toolTipHint = new ToolTip(components);
            openFileDialog = new OpenFileDialog();
            panelTop.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxInput.SuspendLayout();
            panelRight.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonLoadFile);
            panelTop.Controls.Add(groupBoxCondition);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(5);
            panelTop.Size = new Size(900, 100);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.fb1a34d8_90a3_413d_855a_a69fd6cec549;
            buttonHelp.Location = new Point(785, 20);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 66);
            buttonHelp.TabIndex = 3;
            toolTipHint.SetToolTip(buttonHelp, "Кнопка для помощи.");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = Properties.Resources.ok;
            buttonDone.Location = new Point(673, 20);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(93, 66);
            buttonDone.TabIndex = 2;
            toolTipHint.SetToolTip(buttonDone, "Кнопка для запуска программы.");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLoadFile.Cursor = Cursors.Hand;
            buttonLoadFile.Image = Properties.Resources.Farm_Fresh_page_white_put;
            buttonLoadFile.Location = new Point(560, 20);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(93, 66);
            buttonLoadFile.TabIndex = 1;
            toolTipHint.SetToolTip(buttonLoadFile, "Кнопка для загрузки файла.");
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += ButtonLoadFile_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondtion);
            groupBoxCondition.Dock = DockStyle.Left;
            groupBoxCondition.Location = new Point(5, 5);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Padding = new Padding(3, 10, 3, 3);
            groupBoxCondition.Size = new Size(541, 90);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondtion
            // 
            labelCondtion.AutoSize = true;
            labelCondtion.Dock = DockStyle.Fill;
            labelCondtion.Location = new Point(3, 26);
            labelCondtion.Name = "labelCondtion";
            labelCondtion.Size = new Size(534, 45);
            labelCondtion.TabIndex = 0;
            labelCondtion.Text = resources.GetString("labelCondtion.Text");
            // 
            // panelLeft
            // 
            panelLeft.Anchor = AnchorStyles.Left;
            panelLeft.Controls.Add(groupBoxInput);
            panelLeft.Location = new Point(0, 106);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(5);
            panelLeft.Size = new Size(348, 344);
            panelLeft.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(5, 5);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(338, 334);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(3, 19);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(332, 312);
            textBoxInput.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelRight.Controls.Add(groupBoxOutput);
            panelRight.Location = new Point(424, 106);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(5);
            panelRight.Size = new Size(476, 344);
            panelRight.TabIndex = 2;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(5, 5);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(466, 334);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(3, 19);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(460, 312);
            textBoxOutput.TabIndex = 0;
            // 
            // toolTipHint
            // 
            toolTipHint.Tag = "";
            toolTipHint.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Sprint 6 | Task 6 | V15 | Shmidt A.A.";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panelRight.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private GroupBox groupBoxCondition;
        private Label labelCondtion;
        private Panel panelRight;
        private GroupBox groupBoxInput;
        private TextBox textBoxInput;
        private GroupBox groupBoxOutput;
        private TextBox textBoxOutput;
        private Button buttonLoadFile;
        private Button buttonDone;
        private Button buttonHelp;
        private ToolTip toolTipHint;
        private OpenFileDialog openFileDialog;
    }
}
