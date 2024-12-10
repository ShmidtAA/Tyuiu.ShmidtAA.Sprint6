namespace Tyuiu.ShmidtAA.Sprint6.Task7.V9
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
            buttonSave = new Button();
            buttonDone = new Button();
            buttonLoad = new Button();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            panelLeft = new Panel();
            groupBoxInput = new GroupBox();
            dataGridViewInput = new DataGridView();
            splitter1 = new Splitter();
            panelRight = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            panelTop.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            panelRight.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonSave);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonLoad);
            panelTop.Controls.Add(groupBoxCondition);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(5);
            panelTop.Size = new Size(800, 149);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Image = Properties.Resources.fb1a34d8_90a3_413d_855a_a69fd6cec549;
            buttonHelp.Location = new Point(717, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(62, 45);
            buttonHelp.TabIndex = 4;
            toolTipButton.SetToolTip(buttonHelp, "О приложении");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Image = Properties.Resources.sertifikaty;
            buttonSave.Location = new Point(174, 8);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(62, 45);
            buttonSave.TabIndex = 3;
            toolTipButton.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = Properties.Resources.ok;
            buttonDone.Location = new Point(94, 9);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(62, 45);
            buttonDone.TabIndex = 2;
            toolTipButton.SetToolTip(buttonDone, "Запустить приложение");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Image = Properties.Resources.Farm_Fresh_page_white_put;
            buttonLoad.Location = new Point(16, 9);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(62, 45);
            buttonLoad.TabIndex = 1;
            toolTipButton.SetToolTip(buttonLoad, "Загрузить файл");
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Dock = DockStyle.Bottom;
            groupBoxCondition.Location = new Point(5, 60);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(790, 84);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Dock = DockStyle.Fill;
            labelCondition.Location = new Point(3, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(619, 60);
            labelCondition.TabIndex = 0;
            labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxInput);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 149);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(5);
            panelLeft.Size = new Size(384, 343);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(5, 5);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(374, 333);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.ColumnHeadersVisible = false;
            dataGridViewInput.Dock = DockStyle.Fill;
            dataGridViewInput.Location = new Point(3, 19);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.RowHeadersVisible = false;
            dataGridViewInput.Size = new Size(368, 311);
            dataGridViewInput.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(384, 149);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 343);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxOutput);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(387, 149);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(5);
            panelRight.Size = new Size(413, 343);
            panelRight.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(5, 5);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(403, 333);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.ColumnHeadersVisible = false;
            dataGridViewOutput.Dock = DockStyle.Fill;
            dataGridViewOutput.Location = new Point(3, 19);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(397, 311);
            dataGridViewOutput.TabIndex = 0;
            // 
            // toolTipButton
            // 
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(panelRight);
            Controls.Add(splitter1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Sprint 6 | Task 7 | V9 | Shmidt A.A.";
            panelTop.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private GroupBox groupBoxCondition;
        private Panel panelLeft;
        private Splitter splitter1;
        private Panel panelRight;
        private Label labelCondition;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private Button buttonDone;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonHelp;
        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewOutput;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
