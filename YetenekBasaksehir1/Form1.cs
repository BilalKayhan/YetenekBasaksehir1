namespace YetenekBasaksehir1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni bir mesaj eklendi");
            MessageBox.Show("Yeni bir mesaj eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = "Yeni bir de�i�ken";
            if (string.IsNullOrEmpty(test))
            {
                MessageBox.Show("Deger yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
