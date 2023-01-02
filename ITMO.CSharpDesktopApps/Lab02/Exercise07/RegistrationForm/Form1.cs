using System.Drawing;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new Point(38, 174); 
                lbl.Size = new Size(78, 32); 
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new Point(205, 171); 
                txt.Size = new Size(358, 39); 
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else 
            {
                int lcv;
                lcv = groupBox1.Controls.Count;
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
                // groupBox1.Controls.RemoveAt(lcv - 1);
                // groupBox1.Controls.RemoveAt(lcv - 1);
            }
        }
    }
}