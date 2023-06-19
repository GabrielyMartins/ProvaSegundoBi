namespace ProvaSegundoBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_sevicos_Click(object sender, EventArgs e)
        {
            Servicos s = new Servicos();
            s.ShowDialog();
        }
    }
}