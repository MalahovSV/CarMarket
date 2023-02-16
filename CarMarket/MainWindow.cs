namespace CarMarket
{
    public partial class MainWindow : Form
    {
        protected Authorization _authorization;
        protected Dictionary<string, UserControl> _windows;
        public MainWindow(Authorization authorization)
        {
            InitializeComponent();
            _authorization = authorization;
            loadData();
        }

        private void loadData()
        {
            _windows = new Dictionary<string, UserControl>()
            {
                {"Catalog", new MiniWindows.catalogWindow()},
                {"News", new MiniWindows.newsWindow()}
            };
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var reply = MessageBox.Show(
                "Вернуться к форме авторизации?",
                "Завершение работы",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );
            if(reply == DialogResult.Yes)
            {
                _authorization.Show();
            } else if(reply == DialogResult.Cancel)
            {
                e.Cancel = true;
            } else
            {
                _authorization.Close();
            }
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(_windows["Catalog"]);
        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(_windows["News"]);
        }

        private void setupControlsInPanel(UserControl userControl)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
        }
    }
}