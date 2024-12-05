namespace Tyuiu.ShmidtAA.Sprint6.Task4.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            panelRight = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelLeft = new Panel();
            pictureBoxGif = new PictureBox();
            groupBoxInput = new GroupBox();
            textBoxStopValue = new TextBox();
            textBoxStartValue = new TextBox();
            labelEndValue = new Label();
            labelStartValue = new Label();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            groupBoxCondition = new GroupBox();
            pictureBoxFunction = new PictureBox();
            labelCondition = new Label();
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGif).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.Location = new Point(4, 72);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(80, 50);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Помощь";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Location = new Point(90, 72);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 50);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Location = new Point(176, 72);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(80, 50);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += ButtonDone_Click;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(chartFunction);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(419, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(565, 411);
            panelRight.TabIndex = 1;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Location = new Point(15, 7);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(539, 392);
            chartFunction.TabIndex = 6;
            chartFunction.Text = "chart1";
            title1.BackColor = Color.Transparent;
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.Name = "TitleChartFunction";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(pictureBoxGif);
            panelLeft.Controls.Add(groupBoxInput);
            panelLeft.Controls.Add(groupBoxOutput);
            panelLeft.Controls.Add(groupBoxCondition);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(407, 411);
            panelLeft.TabIndex = 3;
            // 
            // pictureBoxGif
            // 
            pictureBoxGif.Image = Properties.Resources.kitty;
            pictureBoxGif.Location = new Point(139, 168);
            pictureBoxGif.Name = "pictureBoxGif";
            pictureBoxGif.Size = new Size(88, 97);
            pictureBoxGif.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGif.TabIndex = 6;
            pictureBoxGif.TabStop = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonSave);
            groupBoxInput.Controls.Add(textBoxStopValue);
            groupBoxInput.Controls.Add(textBoxStartValue);
            groupBoxInput.Controls.Add(buttonHelp);
            groupBoxInput.Controls.Add(labelEndValue);
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(labelStartValue);
            groupBoxInput.Location = new Point(139, 271);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(262, 128);
            groupBoxInput.TabIndex = 4;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(176, 41);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(80, 23);
            textBoxStopValue.TabIndex = 1;
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(8, 41);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(80, 23);
            textBoxStartValue.TabIndex = 0;
            // 
            // labelEndValue
            // 
            labelEndValue.AutoSize = true;
            labelEndValue.Location = new Point(176, 19);
            labelEndValue.Name = "labelEndValue";
            labelEndValue.Size = new Size(72, 15);
            labelEndValue.TabIndex = 8;
            labelEndValue.Text = "Конец шага";
            // 
            // labelStartValue
            // 
            labelStartValue.AutoSize = true;
            labelStartValue.Location = new Point(6, 19);
            labelStartValue.Name = "labelStartValue";
            labelStartValue.Size = new Size(69, 15);
            labelStartValue.TabIndex = 7;
            labelStartValue.Text = "Старт шага";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Location = new Point(3, 168);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(135, 230);
            groupBoxOutput.TabIndex = 5;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(2, 22);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(119, 203);
            textBoxOutput.TabIndex = 1;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxFunction);
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(3, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(407, 156);
            groupBoxCondition.TabIndex = 4;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxFunction
            // 
            pictureBoxFunction.Image = Properties.Resources._51c5b8e2_7571_40ca_a1a3_324a1319d3ab;
            pictureBoxFunction.Location = new Point(6, 111);
            pictureBoxFunction.Name = "pictureBoxFunction";
            pictureBoxFunction.Size = new Size(321, 39);
            pictureBoxFunction.TabIndex = 1;
            pictureBoxFunction.TabStop = false;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(6, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(403, 90);
            labelCondition.TabIndex = 0;
            labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(407, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(21, 411);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kitty;
            pictureBox1.Location = new Point(221, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.kitty;
            pictureBox2.Location = new Point(307, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(splitter1);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            MinimumSize = new Size(1000, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 4 | V5 | Shmidt A.A.";
            Load += FormMain_Load;
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGif).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonDone;
        private Panel panelRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Panel panelLeft;
        private GroupBox groupBoxInput;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
        private Label labelEndValue;
        private Label labelStartValue;
        private PictureBox pictureBoxFunction;
        private Label labelCondition;
        private GroupBox groupBoxCondition;
        private TextBox textBoxOutput;
        private GroupBox groupBoxOutput;
        private Splitter splitter1;
        private PictureBox pictureBoxGif;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
