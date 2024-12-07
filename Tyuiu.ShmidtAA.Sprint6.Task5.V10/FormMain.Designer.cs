namespace Tyuiu.ShmidtAA.Sprint6.Task5.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonOpen = new Button();
            buttonDone = new Button();
            groupBoxCondition = new GroupBox();
            labelComdition = new Label();
            panelLeft = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridView = new DataGridView();
            splitter = new Splitter();
            panelRight = new Panel();
            groupBoxFunction = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelRight.SuspendLayout();
            groupBoxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonOpen);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(groupBoxCondition);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(5);
            panelTop.Size = new Size(906, 100);
            panelTop.TabIndex = 3;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(560, 24);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(100, 60);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelp_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(680, 24);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(100, 60);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += ButtonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(800, 24);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 60);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += ButtonDone_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelComdition);
            groupBoxCondition.Dock = DockStyle.Left;
            groupBoxCondition.Location = new Point(5, 5);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(550, 90);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelComdition
            // 
            labelComdition.AutoSize = true;
            labelComdition.Dock = DockStyle.Fill;
            labelComdition.Location = new Point(3, 19);
            labelComdition.Name = "labelComdition";
            labelComdition.Size = new Size(544, 60);
            labelComdition.TabIndex = 0;
            labelComdition.Text = resources.GetString("labelComdition.Text");
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxOutput);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 100);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(5);
            panelLeft.Size = new Size(194, 350);
            panelLeft.TabIndex = 2;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridView);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(5, 5);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(184, 340);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.Size = new Size(178, 318);
            dataGridView.TabIndex = 0;
            dataGridView.TabStop = false;
            // 
            // splitter
            // 
            splitter.Location = new Point(194, 100);
            splitter.Name = "splitter";
            splitter.Size = new Size(3, 350);
            splitter.TabIndex = 1;
            splitter.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.Transparent;
            panelRight.Controls.Add(groupBoxFunction);
            panelRight.Dock = DockStyle.Fill;
            panelRight.ImeMode = ImeMode.NoControl;
            panelRight.Location = new Point(197, 100);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(5);
            panelRight.Size = new Size(709, 350);
            panelRight.TabIndex = 0;
            // 
            // groupBoxFunction
            // 
            groupBoxFunction.Controls.Add(chartFunction);
            groupBoxFunction.Dock = DockStyle.Fill;
            groupBoxFunction.Location = new Point(5, 5);
            groupBoxFunction.Name = "groupBoxFunction";
            groupBoxFunction.Size = new Size(699, 340);
            groupBoxFunction.TabIndex = 0;
            groupBoxFunction.TabStop = false;
            groupBoxFunction.Text = "Функция";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Dock = DockStyle.Fill;
            chartFunction.Location = new Point(3, 19);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(693, 318);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.Name = "TitleFunction";
            title1.Text = "Функция значений";
            chartFunction.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(panelRight);
            Controls.Add(splitter);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Sprint 6 | Task 5 | V10 | Shmidt A.A.";
            panelTop.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Splitter splitter;
        private Panel panelRight;
        private GroupBox groupBoxCondition;
        private GroupBox groupBoxOutput;
        private GroupBox groupBoxFunction;
        private DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Label labelComdition;
        private Button buttonDone;
        private Button buttonHelp;
        private Button buttonOpen;
    }
}
