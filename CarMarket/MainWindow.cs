namespace CarMarket
{
    public partial class MainWindow : Form
    {
        protected Authorization _authorization;
        public MainWindow(Authorization authorization)
        {
            InitializeComponent();
            _authorization = authorization;
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
    }
}