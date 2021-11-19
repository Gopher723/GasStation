using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;


namespace GasStation
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(@"log.txt", Encoding.Default);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            Word.Application appWord = new Word.Application();
            var wordDocument = appWord.Documents.Open(baseDirectoryPath + @"\log.txt");
            wordDocument.ExportAsFixedFormat(baseDirectoryPath + @"\log.pdf", Word.WdExportFormat.wdExportFormatPDF);
            appWord.ActiveDocument.Close();

            string destFilePath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                destFilePath = sfd.FileName;
            }

            File.Copy(@"log.pdf", destFilePath + ".pdf");
            File.Delete(@"log.pdf");
            MessageBox.Show("Govno");
        }
    }
}
