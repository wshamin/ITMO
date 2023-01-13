using System.Text;
using System.Windows.Forms;
using BiblWorm.Bibl;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Срок пользования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public string Volume // Том
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public int Number // Номер журнала
        {
            get { return (int)numericUpDown9.Value; }
            set { numericUpDown9.Value = value; }
        }
        public string MagazineTitle // Название журнала
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public int MagazineYear // Год издания журнала
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        public int MagazineInvNumber // Инвентарный номер журнала
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool MagazineExistence // Наличие журнала
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        public bool Subscription // Подписка на журнал
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }

        List<Item> its = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, 
                Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();

            b.PriceBook(PeriodUse);

            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SortInvNumber) its.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item it in its) sb.Append("\n" + it.ToString());

            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Volume, Number, MagazineTitle, MagazineYear,
                MagazineInvNumber, MagazineExistence);

            if (Subscription) m.Subs();

            its.Add(m);

            Volume = MagazineTitle = "";
            Number = MagazineInvNumber = 0;
            MagazineYear = 2020;
            MagazineExistence = Subscription = false;
        }
    }
}