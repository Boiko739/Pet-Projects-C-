using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDZ_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void DownloadGolicButton_Click(object sender, EventArgs e)
        {
            var ds = new DownloaderSettings
                (disciplines.Text, (int)form.Value, authors.Text, directory.Text, this);
            var downloader = new Downloader(ds);

            await Task.Run(() =>
            {
                downloader.Download();
            });
        }

        private void DownloadBookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция в разработке");
        }

        private void DownloadTasksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция в разработке");
        }

        private void directory_TextChanged(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "\nВыберите папку для сохранения ГДЗ";
            folderBrowserDialog1.ShowDialog();
            directory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            directory_TextChanged(sender, e);
        }
        internal void UpdateBrogressBar(int value)
        {
        }
    }
}
