using Tyuiu.ShmidtAA.Sprint6.Task6.V15.Lib;
namespace Tyuiu.ShmidtAA.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                openFilePath = openFileDialog.FileName;
                textBoxInput.Text = File.ReadAllText(openFilePath);
                groupBoxInput.Text = groupBoxInput.Text + " " + openFilePath;
                buttonDone.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка в загрузке файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
            }
            catch
            {
                MessageBox.Show("Ошибка при выполнении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
