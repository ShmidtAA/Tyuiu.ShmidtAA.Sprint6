using Tyuiu.ShmidtAA.Sprint6.Task0.V12.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task0.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResultSAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxVarSAA.Text)));
            }
            catch
            {
                MessageBox.Show("У вас ошибка, сэр", "Вы ошиблись!", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void TextBoxResultSAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
