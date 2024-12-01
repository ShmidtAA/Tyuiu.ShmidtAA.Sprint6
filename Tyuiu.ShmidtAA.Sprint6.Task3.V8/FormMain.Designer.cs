namespace Tyuiu.ShmidtAA.Sprint6.Task3.V8
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
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            dataGridViewMatrix = new DataGridView();
            groupBoxOutput = new GroupBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(32, 39);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(335, 255);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(6, 28);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(293, 210);
            labelCondition.TabIndex = 0;
            labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(17, 28);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(131, 133);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewMatrix);
            groupBoxOutput.Location = new Point(392, 39);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(197, 255);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(502, 300);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(87, 23);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += ButtonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(466, 300);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(30, 23);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 330);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Sprint 6 | Task 3 | V8 | Shmidt A.A.";
            Load += FormMain_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private Label labelCondition;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxOutput;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
