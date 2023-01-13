using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            label2.Text = "Левая граница: " + form2.min + ", правая граница: " + form2.max;
            for (double i = form2.min; i <= form2.max; i = i + 0.1)
            {
                sb.Append(Math.Round(i, 2) + ": " + Math.Round(Math.Sin(i), 2) + "\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}