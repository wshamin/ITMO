namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string SolData
        {
            get { return textBoxF1.Text; }
            set { textBoxF1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
        }
    }
}