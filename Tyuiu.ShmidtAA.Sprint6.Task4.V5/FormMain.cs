using Tyuiu.ShmidtAA.Sprint6.Task4.V5.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = buttonDone;
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        { }



        private void ButtonDone_Click(object sender, EventArgs e) 
        {

            try
            {
                this.chartFunction.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxOutput.Clear();
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue.Text);
                double[] FunctionArray = ds.GetMassFunction(startValue, stopValue);
                foreach (double var in FunctionArray)
                {
                    textBoxOutput.AppendText(var + Environment.NewLine);
                    this.chartFunction.Series[0].Points.AddXY(startValue++, var);
                }
            }
            catch
            {
                MessageBox.Show("�� ��������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ����� ������� ����������� �� ������ �����-24-1", "���������");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V5.txt");
                File.WriteAllText(path, textBoxOutput.Text);

                DialogResult dialogResult = MessageBox.Show($"���� {path} �������� �������!/n������� ������ ��� � ��������?","���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information  );

                if ( dialogResult == DialogResult.Yes )
                {
                    System.Diagnostics.Process txt= new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
