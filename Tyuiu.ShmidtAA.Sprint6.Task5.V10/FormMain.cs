using Tyuiu.ShmidtAA.Sprint6.Task5.V10.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
namespace Tyuiu.ShmidtAA.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = buttonDone;
        }
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V10.txt");

        public void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                double[] nums = ds.LoadFromDataFile(path);

                // ��������
                dataGridView.Rows.Clear();

                dataGridView.ColumnCount = 2;
                dataGridView.Columns[0].Width = 30;
                dataGridView.Columns[1].Width = 128;
                int count = 1;
                foreach (double num in nums)
                {
                    dataGridView.Rows.Add(count, num);
                    dataGridView.Columns[0].HeaderText = "�";
                    dataGridView.Columns[1].HeaderText = "��������";
                    count++;
                }
                // ��� ��������� �� ������ �����
                dataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // ��� �������� �� ������ �����
                dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // �������
                chartFunction.Series[0].Points.Clear();

                this.chartFunction.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

                count = 0;
                foreach (double num in nums)
                {
                    chartFunction.Series[0].Points.AddXY(count, num);
                    count++;
                }
            }
            catch
            {
                MessageBox.Show("������ � ����������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("������ � ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ButtonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("������ ����� ������ ���������, ��. �����-24-1","���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }

        }
    }
}
