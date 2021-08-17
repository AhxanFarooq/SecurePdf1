using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SecurePdf
{
    public partial class PdfForm : Form
    {
        private string message;
        public PdfForm()
        {
            InitializeComponent();
            convert.Enabled = false;
            convertToAFie.Enabled = false;
            
        }

        private void OpenFileFromDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string filep = fbd.SelectedPath;
                file.Text = filep;
                file.Hide();
                filepath.Text = filep;
            }
            if (destination.Text != "" && file.Text != "")
            {
                convert.Enabled = true;
            }
        }

        private void destinationfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string file = fbd.SelectedPath;
                destination.Text = file;
            }
            if (destination.Text != "" && file.Text != "")
            {
                convert.Enabled = true;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            convert.Enabled = false;
            pictureBox1.Dock = DockStyle.Fill;
            backgroundWorker1.RunWorkerAsync();
            
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertSecurePdf securePdf = new ConvertSecurePdf();
            message = securePdf.ConvertPdfToSecurePdfAsync(file.Text, destination.Text);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (message != "Success")
            {
                if (message.StartsWith("Please"))
                {
                    convert.Enabled = true;
                    pictureBox1.Visible = false;

                    MessageBox.Show(message);
                }
                else
                {
                    convert.Enabled = true;
                    pictureBox1.Visible = false;
                    MessageBox.Show("Some error occured \n" + message);
                }

            }
            else
            {
                destination.Text = "";
                file.Text = "";
                filepath.Text = "";
                MessageBox.Show("Your Pdf converted successfully to secure pdf");
                pictureBox1.Visible = false;
            }
        }

        private void docFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Filter = "docx files (*.docx)|*.docx|doc files (*.doc)|*.doc";
            fbd.FilterIndex = 1;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string filep = fbd.FileName;
                selectAFile.Text = filep;
                //docFile.Text = filep;
            }
            if (selectAFile.Text != "")
            {
                convertToAFie.Enabled = true;
            }
        }

        private void convertToAFie_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            convert.Enabled = false;
            convertToAFie.Enabled = false;
            pictureBox1.Dock = DockStyle.Fill;
            backgroundWorker2.RunWorkerAsync();
            
        }

        private void singleFile_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertSecurePdf securePdf = new ConvertSecurePdf();
            message = securePdf.ConvertWordFileToPdf(selectAFile.Text);
        }

        private void singleFile_RunWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            if (message != "Success")
            {
                    convertToAFie.Enabled = true;
                    pictureBox1.Visible = false;
                    MessageBox.Show("Some error occured \n" + message);
                
            }
            else
            {
                selectAFile.Text = "";
                MessageBox.Show("Your Pdf converted successfully to secure pdf");
                pictureBox1.Visible = false;
            }
        }
    }
}
