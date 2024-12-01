using Tyuiu.ShmidtAA.Sprint6.Task2.V24.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = buttonDone;
            this.chartFunction.Titles.Add("√рафик функции");
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {

            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue.Text);
                double[] valueArray = ds.GetMassFunction(startValue, stopValue);


                this.chartFunction.ChartAreas[0].AxisX.Title = "ќсь X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "ќсь Y";

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }


            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("—делал студент гр. »Ѕ —б-24-1 Ўмидт јндрей јндреевич", "—ообщение", MessageBoxButtons.OK);
        }
    }
}
