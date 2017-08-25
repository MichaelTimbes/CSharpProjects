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

namespace Review
{
    

    public partial class MainForm : Form
    {
        public StreamReader fin;
        public StreamWriter fout;
        public Stream Ofil;
        public WarningException WarningWin = new WarningException();
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OpenFile= new OpenFileDialog();
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sbuff;
                    fin = new StreamReader(OpenFile.FileName);
                    sbuff = fin.ReadToEnd();
                    fin.Close();
                    MainTextBox.Text = sbuff;

                }
                catch (WarningException WarningWin)
                {
                    WarningWin.ToString();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFile = new SaveFileDialog();
            SFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (SFile.ShowDialog() == DialogResult.OK) {
                try
                {
                    string sbuff;
                    sbuff = MainTextBox.Text;
                    fout = new StreamWriter(SFile.FileName);
                    fout.Write(sbuff);
                    fout.Close();

                }
                catch (WarningException WarningWin)
                {
                    WarningWin.ToString();
                }


            }
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Clear();
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FontCh = new FontDialog();
            if (FontCh.ShowDialog() == DialogResult.OK)
            {
                MainTextBox.SelectionFont = FontCh.Font;
            }
        }

        private void fontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog FontS = new FontDialog();
            FontS.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click( sender,e);
        }
    }
}
