namespace Tyuiu.ShmidtAA.Sprint6.Task2.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition = new GroupBox();
            pictureBoxFunction = new PictureBox();
            labelCondition = new Label();
            groupBoxInput = new GroupBox();
            textBoxStopValue = new TextBox();
            textBoxStartValue = new TextBox();
            labelStopValue = new Label();
            labelStartValue = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOutput = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            Function = new DataGridViewTextBoxColumn();
            Variable = new DataGridViewTextBoxColumn();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxFunction);
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(493, 306);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxFunction
            // 
            pictureBoxFunction.Image = (Image)resources.GetObject("pictureBoxFunction.Image");
            pictureBoxFunction.Location = new Point(6, 68);
            pictureBoxFunction.Name = "pictureBoxFunction";
            pictureBoxFunction.Size = new Size(284, 38);
            pictureBoxFunction.TabIndex = 1;
            pictureBoxFunction.TabStop = false;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(6, 30);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(359, 45);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Протабулировать данную функцию на заданном диапазоне. \r\nРезультат вывести в DataGridView и построить график функции.\r\n\r\n";
            // 
            // groupBoxInput
            // 
            groupBoxInput.BackColor = Color.Transparent;
            groupBoxInput.Controls.Add(textBoxStopValue);
            groupBoxInput.Controls.Add(textBoxStartValue);
            groupBoxInput.Controls.Add(labelStopValue);
            groupBoxInput.Controls.Add(labelStartValue);
            groupBoxInput.Location = new Point(12, 334);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(273, 70);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.BackColor = Color.WhiteSmoke;
            textBoxStopValue.BorderStyle = BorderStyle.FixedSingle;
            textBoxStopValue.ForeColor = SystemColors.WindowFrame;
            textBoxStopValue.Location = new Point(138, 37);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(77, 23);
            textBoxStopValue.TabIndex = 1;
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.BackColor = Color.WhiteSmoke;
            textBoxStartValue.BorderStyle = BorderStyle.FixedSingle;
            textBoxStartValue.ForeColor = SystemColors.WindowFrame;
            textBoxStartValue.Location = new Point(9, 38);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(77, 23);
            textBoxStartValue.TabIndex = 0;
            // 
            // labelStopValue
            // 
            labelStopValue.AutoSize = true;
            labelStopValue.Location = new Point(138, 19);
            labelStopValue.Name = "labelStopValue";
            labelStopValue.Size = new Size(72, 15);
            labelStopValue.TabIndex = 1;
            labelStopValue.Text = "Конец шага";
            // 
            // labelStartValue
            // 
            labelStartValue.AutoSize = true;
            labelStartValue.Location = new Point(9, 19);
            labelStartValue.Name = "labelStartValue";
            labelStartValue.Size = new Size(69, 15);
            labelStartValue.TabIndex = 0;
            labelStartValue.Text = "Старт шага";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.AppWorkspace;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(302, 344);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 60);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.GradientActiveCaption;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Location = new Point(383, 344);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(122, 60);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(chartFunction);
            groupBoxOutput.Controls.Add(dataGridViewFunction);
            groupBoxOutput.Location = new Point(533, 21);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(439, 383);
            groupBoxOutput.TabIndex = 4;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartFunction.BackColor = Color.Gainsboro;
            chartFunction.BorderlineColor = SystemColors.Window;
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            chartFunction.Location = new Point(115, 21);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(318, 371);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.BackgroundColor = SystemColors.ControlLight;
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Function, Variable });
            dataGridViewFunction.Location = new Point(6, 22);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.ReadOnly = true;
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(103, 361);
            dataGridViewFunction.TabIndex = 0;
            // 
            // Function
            // 
            Function.HeaderText = "F(X)";
            Function.Name = "Function";
            Function.ReadOnly = true;
            Function.Width = 50;
            // 
            // Variable
            // 
            Variable.HeaderText = "X";
            Variable.Name = "Variable";
            Variable.ReadOnly = true;
            Variable.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 425);
            Controls.Add(groupBoxOutput);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 2 | V 24 | Shmidt A.A.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private PictureBox pictureBoxFunction;
        private Label labelCondition;
        private GroupBox groupBoxInput;
        private Label labelStopValue;
        private Label labelStartValue;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn Function;
        private DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
