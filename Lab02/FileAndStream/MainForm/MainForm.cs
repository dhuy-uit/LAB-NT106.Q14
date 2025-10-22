namespace Lab02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenDialog(Form child)
        {
            child.StartPosition = FormStartPosition.CenterParent;
            child.ShowIcon = false;
            child.MaximizeBox = false;
            child.MinimizeBox = false;
            child.ShowDialog(this);
        }

        private void btnLBai01_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai01());
        }

        private void lblBai02_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai02());
        }

        private void lblBai03_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai03());
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBai04_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai04());
        }

        private void lblBai05_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai05());
        }

        private void lblBai06_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai06());
        }

        private void lblBai07_Click(object sender, EventArgs e)
        {
            OpenDialog(new Lab02_Bai07());
        }
    }
}

