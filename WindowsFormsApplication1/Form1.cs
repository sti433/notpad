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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string documentfilepath = "";
        bool savestatus = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                documentfilepath = saveFileDialog1.FileName;
                File.AppendAllText(documentfilepath, txtmaindocument.Text);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (documentfilepath == "")
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    documentfilepath = saveFileDialog1.FileName;
                }

            }
            File.AppendAllText(documentfilepath, txtmaindocument.Text);
            savestatus = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtmaindocument.TextLength!=0)
            {
                if(MessageBox.Show("do yopu save??","save",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                documentfilepath = saveFileDialog1.FileName;
               File.AppendAllText(documentfilepath,txtmaindocument.Text);

            }
        }
    }

         if (openFileDialog1.ShowDialog() == DialogResult.OK)

    {
        documentfilepath = openFileDialog1.FileName;
        txtmaindocument.Text = File.ReadAllText(documentfilepath);
    }
}
       

        private void txtmaindocument_TextChanged(object sender, EventArgs e)
        {
            savestatus = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savestatus == true)
            

                this.Close();
           
            else
            {
                DialogResult r = MessageBox.Show("do you want to save change?", "note pad", MessageBoxButtons.YesNoCancel);
                if(r==DialogResult.Yes)
                {
                    if (documentfilepath == "")
                    {

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            documentfilepath = saveFileDialog1.FileName;
                            File.AppendAllText(documentfilepath, txtmaindocument.Text);
                            savestatus = true;
                        }
                    }
                    else
                    {
                        File.AppendAllText(documentfilepath, txtmaindocument.Text);
                        savestatus = true;
                    }
                    this.Close();
                }
                    if (r == DialogResult.Cancel)
                    {
                        return;
                    }
                    if (r == DialogResult.No)
                    {
                        this.Close();
                    }  
               }
           }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtmaindocument.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtmaindocument.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtmaindocument.Cut();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savestatus == true)
                txtmaindocument.Clear();

            else
            {
                DialogResult r = MessageBox.Show("do you want to save change?", "note pad", MessageBoxButtons.YesNoCancel);
                if (r == DialogResult.Yes)
                {
                    if (documentfilepath == "")
                    {

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            documentfilepath = saveFileDialog1.FileName;
                            File.AppendAllText(documentfilepath, txtmaindocument.Text);
                            savestatus = true;
                        }
                    }
                    else
                    {
                        File.AppendAllText(documentfilepath, txtmaindocument.Text);
                        savestatus = true;
                    }
                    txtmaindocument.Clear();
                }
                if (r == DialogResult.Cancel)
                {
                    return;
                }
                if (r == DialogResult.No)
                {
                    txtmaindocument.Clear();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (savestatus == true)
                txtmaindocument.Clear();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtmaindocument.SelectAll();
        }

        private void backcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}