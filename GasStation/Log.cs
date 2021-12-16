using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace GasStation
{
    public partial class Log : Form
    {
        DateTime date = DateTime.Now;
        public Log()
        {
            InitializeComponent();
            //File.Copy("log.txt", "tmplog.txt");
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = $"Отчет за {date.ToLongDateString()}\n\n";
            richTextBox1.Text += File.ReadAllText(@"log.txt", Encoding.Default);
            richTextBox1.Text += $"Выручка: {GasStation.Revenue} Руб.";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("log.txt", "tmplog.txt");
                GasStation.InsertText("tmplog.txt", $"Отчет за {date.ToLongDateString()}\n\n");

                string writePath = @"tmplog.txt";
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Выручка: {GasStation.Revenue} Руб.");
                }
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                Word.Application appWord = new Word.Application();
                var wordDocument = appWord.Documents.Open(baseDirectoryPath + @"\tmplog.txt");
                wordDocument.ExportAsFixedFormat(baseDirectoryPath + @"\tmplog.pdf", Word.WdExportFormat.wdExportFormatPDF);
                appWord.ActiveDocument.Close();

                string destFilePath = "";
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    destFilePath = sfd.FileName;
                }

                File.Copy(@"tmplog.pdf", destFilePath + ".pdf");
                File.Delete(@"tmplog.pdf");
                MessageBox.Show("Файл сохранен.", "OilCity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OilCity");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //UserSelection frm = new UserSelection();
            //frm.Show();
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("tmplog.txt");
        }
    }
}
