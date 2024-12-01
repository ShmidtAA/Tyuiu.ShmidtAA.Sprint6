using Tyuiu.ShmidtAA.Sprint6.Task3.V8.Lib;

namespace Tyuiu.ShmidtAA.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = buttonDone;
        }

        DataService ds = new DataService();
        int[,] valueArray = new int[5, 5]
            {

            { -10, 10, -7, 19, 6 },
            { 15, -13, -19, 9, 1 },
            { -20, -15, -6, 8, -4 },
            { 10, 18, -5, 9, -6 },
            { 16, -10, 4, 15, 16 }

            };
        private void FormMain_Load(object sender, EventArgs e)
        {
            try 
            {

                

                dataGridViewMatrix.ColumnCount = 5;
                dataGridViewMatrix.RowCount = 5;
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewMatrix.Columns[i].Width = 25;
                   
                }
            
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(valueArray[i, j]);
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Что-то не так с загрузкой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }


        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
              
                dataGridViewMatrix.RowCount = 5;
                int[,] res = ds.Calculate(valueArray);

                for (int i = 0; i < res.GetLength(0); i++)
                {
                    for (int j = 0; j < res.GetLength(1); j++)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Вы допустили ошибку","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент ИБКСб-24-1 Шмидт Андрей Андреевич", "Сообщение", MessageBoxButtons.OK);

        }

    }
}
