namespace WHILE_NUMEROL_1_AL_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            while (a <= 20)
            {
                listBox1.Items.Add(a);
                a++;
            }
        }
    }
}