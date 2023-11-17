namespace accreditation2111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPB.Image = accreditation2111.Properties.Resources.buttonclicked;
            clicks.Enabled = true;
        }

        private void clicks_Tick(object sender, EventArgs e)
        {
            buttonPB.Image = accreditation2111.Properties.Resources.buttonunclicked;
        }
    }
}