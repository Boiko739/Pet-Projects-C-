using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GDZ_Downloader
{
    internal class Downloader
    {
        private DownloaderSettings ds;
        WebClient wc = new WebClient();

        public Downloader(DownloaderSettings ds)
        {
            this.ds = ds;
        }
        public void Download()
        {
            ds.f1.Invoke(new Action(() =>
            {
                ds.f1.downloadButton1.Enabled = false;
            }));
            try
            {
                for (int i = 1; i <= 567; i++)
                {
                    Uri uri = new Uri(@"https://otvetkin.info/files/12/" + i + ".jpg");
                    string save_path = ds.way +
                        "\\GDZ_Downloader - Files\\Английский язык. Грамматика. Сборник упражнений" +
                            " Ю. Б. Голицынский - 7 издание, КАРО, 2011г.";
                    string name = $"\\{i}.jpg";

                    if (!Directory.Exists(save_path))
                        Directory.CreateDirectory(save_path);
                    if (File.Exists(save_path + name))
                        continue;

                    wc.DownloadFile(uri, save_path + name);
                    ds.f1.Invoke(new Action(() =>
                    {
                        ds.f1.toolStripProgressBar1.Value = (int)(i / 567 * 100);
                        ds.f1.percent.Text = ((int)(i / 567 * 100)).ToString() + " %";
                    }));
                    i = 566;
                    using (FileStream fs = new FileStream(save_path + "\\Message.txt", FileMode.Create))
                    {
                        byte[] data = Encoding.UTF8.GetBytes("There could be all the other images, but" +
                        " I think you already get it! ;)");
                        fs.Write(data, 0, data.Length);
                    };
                }
                Thread.Sleep(1000);
                for (int i = 1; i <= 3; i++)
                {
                    Uri uri = new Uri(@"https://otvetkin.info/files/12/kr" + i + ".jpg");

                    string save_path = ds.way +
                        "\\GDZ_Downloader - Files\\Английский язык. Грамматика. Сборник упражнений" +
                        " Ю. Б. Голицынский - 7 издание, КАРО, 2011г.\\Контрольные упражнения";

                    string name = $"\\kr{i}.jpg";

                    if (!Directory.Exists(save_path))
                        Directory.CreateDirectory(save_path);
                    if (File.Exists(save_path + name))
                        continue;

                    wc.DownloadFile(uri, save_path + name);

                    ds.f1.Invoke(new Action(() =>
                    {
                        ds.f1.toolStripProgressBar1.Value = (int)(i / 3 * 100);
                        ds.f1.percent.Text = ((int)(i / 3 * 100)).ToString() + " %";
                    }));
                }
                MessageBox.Show("Успешно загружено!\nЕсли загруженая папка не отображается, " +
                    "обновите папку с содержимым (или рабочий стол)");
            }
            catch (WebException)
            {
                MessageBox.Show("Проверьте соединение с интернетом!", "Ошибка загрузки!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка загрузки!");
            }
            finally
            {
                ds.f1.Invoke(new Action(() =>
                {
                    ds.f1.downloadButton1.Enabled = true;
                    wc.Dispose();
                }));
            }
        }
    }

    class DownloaderSettings
    {
        internal string discipline;
        internal int form;
        internal string author;
        internal string way;
        internal string[] uris;
        public Form1 f1 { get; set; }

        public DownloaderSettings(string discipline, int form, string author, string way, Form1 f1)
        {
            this.discipline = discipline;
            this.form = form;
            this.author = author;
            if (way == @"C:\..\Desktop")
                this.way = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                this.way = way;
            this.f1 = f1;
            uris = ChooseUris(discipline, form, author);

        }
        private static string[] ChooseUris(string discipline, int form, string author)
        {
            var uris = new string[] { };
            //choosing (from enum) and returning uris to download images
            return uris;
        }

    }
}
