namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        nForm myF2;

        public Form1()
        {
            InitializeComponent();
            myF2 = new nForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myF2.StartPosition = FormStartPosition.Manual;
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            try
            {
                myF2.Show();
                myF2.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myF2 = new nForm();
                myF2.Text = "��������� �������� �����";
                myF2.Show();
                myF2.Activate();
            }
        }
    }
}