using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd_Open.ShowDialog() == DialogResult.OK)
            {

                // Traitement du fichier qui a été sélectionné !!!
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd_Open.ShowDialog() == DialogResult.OK)
            {

                // Traitement du fichier qui a été sélectionné !!!
                string[] readText = File.ReadAllLines(ofd_Open.FileName, Encoding.Default);

                foreach (string uneLigne in readText)
                {
                    textBox1.Text += uneLigne + Environment.NewLine;
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    // Code to read the contents of the text file
                    if (File.Exists(fileLoc))
                    {
                        TextReader tr = new StreamReader(fileLoc, Encoding.Default);
                        MessageBox.Show(tr.ReadToEnd());
                        
                    }
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

    }
}
