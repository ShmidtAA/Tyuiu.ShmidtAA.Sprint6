using Tyuiu.ShmidtAA.Sprint6.Task1.V28.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task1.V28
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = ButtonResultSAA;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {
            
            try
            {
                int startStep = Convert.ToInt32(TextBoxStartStepSAA.Text);
                int stopStep = Convert.ToInt32(TextBoxStopStepSAA.Text);

                double[] res = ds.GetMassFunction(startStep,stopStep);
                string line;
                TextBoxResultSAA.Text = "";
                TextBoxResultSAA.AppendText("+-------+--------+" + Environment.NewLine);
                TextBoxResultSAA.AppendText("|    x       |       f(x)  |" + Environment.NewLine);
                TextBoxResultSAA.AppendText("+-------+--------+" + Environment.NewLine);
                for (int i = 0; i < res.Length; i++)
                {
                    Console.WriteLine(res[i]);
                    line = String.Format("|{0,5:d}       |   {1,5:f2}     |", startStep + i, res[i]);
                    TextBoxResultSAA.AppendText(line + Environment.NewLine);
                }
                TextBoxResultSAA.AppendText("+-------+--------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("У вас ошибка, сэр", "Вы ошиблись!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void buttonHelp_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Выполнил студент группы ИБКСб-24-1 Шмидт Андрей Андреевич", "Сообщение");


        }
    }
}
