using System.Windows.Forms;
using Tyuiu.ShmidtAA.Sprint6.Task7.V9.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task7.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path;



        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                path = openFileDialog.FileName;

                using(StreamReader read = new StreamReader(path))
                {
                    string fileData = read.ReadToEnd();
                    fileData = fileData.Replace('\n','\r');
                    string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    int rows = lines.Length;
                    int cols = lines[0].Split(';').Length;
                    int[,] matrix = new int[rows, cols];


                    dataGridViewInput.ColumnCount = cols;
                
                    for (int r = 0; r < rows; r++)
                    {
                        string[] line_r = lines[r].Split(';');
                        for (int c = 0; c < cols; c++)
                        {
                            matrix[r, c] = Convert.ToInt32(line_r[c]); 

                        }
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewInput);

                        for (int j = 0; j < cols; j++)
                        {
                            row.Cells[j].Value = matrix[i, j];
                        }
                        dataGridViewInput.Rows.Add(row);

                    }
                    dataGridViewInput.AutoResizeColumns();
                }
                groupBoxInput.Text = groupBoxInput.Text + " " + path;

                buttonDone.Enabled = true;
               
            }
            catch 
            {
                MessageBox.Show("Ошибка с загрузкой файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = ds.GetMatrix(path);

                dataGridViewOutput.ColumnCount = matrix.GetLength(1);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewOutput);

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        row.Cells[j].Value = matrix[i, j];
                    }
                    dataGridViewOutput.Rows.Add(row);

                }
                dataGridViewOutput.AutoResizeColumns();
                buttonSave.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка с выполнением программы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
        try
            {
                saveFileDialog.FileName = "OutPutDataFileTask7V9.csv";
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.ShowDialog();

                string pathSave = saveFileDialog.FileName;

                FileInfo fileInfo = new FileInfo(pathSave);
                if (fileInfo.Exists)
                {
                    File.Delete(pathSave);
                }

                int row = dataGridViewOutput.RowCount;
                int col = dataGridViewOutput.ColumnCount;
                string str = "";

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (j < col)
                        {
                            str += dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewOutput.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(pathSave, str + Environment.NewLine);
                    str = "";

                }
                groupBoxOutput.Text = groupBoxOutput.Text + " " + pathSave;
            }
            catch
            {
                MessageBox.Show("Ошибка в сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                FormAbout about = new FormAbout();
                about.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка с открытие FormAbout","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
