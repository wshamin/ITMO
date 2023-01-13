using UserControlLibrary;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person p in uc.people)
            {
                listBox1.Items.Add(p.FullName);
            }
        }
    }
}