namespace Laba_18
{
    public partial class MainForm : Form
    {
        Random rand = new Random();
        const int SIZE = 15;
        int[] arr = new int[SIZE];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = arr.Length;
            dataGridViewArray.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewTree.RowCount = 4;
            dataGridViewTree.ColumnCount = arr.Length;
            dataGridViewTree.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewResultSelection.RowCount = 1;
            dataGridViewResultSelection.ColumnCount = arr.Length;
            dataGridViewResultSelection.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewArray.Columns[i].Width = 60;
                dataGridViewTree.Columns[i].Width = 60;
                dataGridViewResultSelection.Columns[i].Width = 60;
            }

        }

        private void Print(int[] A)
        {
            for (int i = 0; i < dataGridViewArray.ColumnCount; i++) dataGridViewArray.Rows[0].Cells[i].Value = A[i];

            dataGridViewTree.Rows[0].Cells[dataGridViewTree.ColumnCount / 2].Value = A[0];
            dataGridViewTree.Rows[1].Cells[dataGridViewTree.ColumnCount / 4].Value = A[1];
            dataGridViewTree.Rows[1].Cells[dataGridViewTree.ColumnCount / 2 + (dataGridViewTree.ColumnCount / 4 + 1)].Value = A[2];
            int index = 3;
            for (int i = 1; i < dataGridViewTree.ColumnCount; i = i + 4)
            {
                dataGridViewTree.Rows[2].Cells[i].Value = A[index];
                index++;
            }
            for (int i = 0; i < dataGridViewTree.ColumnCount; i = i + 2)
            {
                dataGridViewTree.Rows[3].Cells[i].Value = A[index];
                index++;
            }

        }

        private bool Clear(DataGridView table)
        {
            bool flag = true;
            for (int row = 0; row < table.RowCount; row++)
            {
                for (int col = 0; col < table.ColumnCount; col++)
                {
                    if (table.Rows[row].Cells[col].Value != "") flag = false;
                    table.Rows[row].Cells[col].Value = "";
                }
            }
            return flag;

        }

        private void buttonCreateQueue_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(10, 99);
            Print(arr);
        }

        private void buttonClearQueue_Click(object sender, EventArgs e)
        {
            if (Clear(dataGridViewArray)) MessageBox.Show("Таблица уже очищена!");
            Clear(dataGridViewTree);
            Clear(dataGridViewResultSelection);
            Clear(dataGridViewArray);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
