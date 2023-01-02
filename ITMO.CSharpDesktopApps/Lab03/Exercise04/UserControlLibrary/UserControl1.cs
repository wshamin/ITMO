namespace UserControlLibrary
{
    public partial class UserControl1 : UserControl
    {
        public List<Person> people = new List<Person>();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FullName = textBox1.Text;
            people.Add(p);
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(textBox1, "Поле не может содержать цифры");
                e.Handled = true;
            }
        }
    }
}