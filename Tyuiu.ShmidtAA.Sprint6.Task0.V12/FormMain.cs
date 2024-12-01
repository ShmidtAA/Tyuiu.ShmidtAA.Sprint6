using Tyuiu.ShmidtAA.Sprint6.Task0.V12.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task0.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = ButtonResultSAA;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResultSAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxVarSAA.Text)));
            }
            catch
            {

                MessageBox.Show("У вас ошибка, сэр", "Вы ошиблись!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Выполнил студент группы ИБКСб-24-1 Шмидт Андрей Андреевич", "Сообщение");
            
            
        }

       
    }
}
