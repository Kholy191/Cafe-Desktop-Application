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
    }
}
