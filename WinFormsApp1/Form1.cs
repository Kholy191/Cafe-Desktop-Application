namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            Orders newForm = new Orders();
            newForm.Show();
            this.Hide();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm newForm = new AddProductForm();
            newForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = DepartmentService.GetDepartments();
        }
    }
}
