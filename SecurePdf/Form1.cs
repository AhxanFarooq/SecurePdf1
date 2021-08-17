using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePdf
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            
        }
        public void StartApplication()
        {
            try
            {
                while (true)
                {
                    Application.Run(new SplashScreen());
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine((string)abortException.ExceptionState);
            }
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(username.Text == "admin" && password.Text == "admin")
            {
                //ConvertSecurePdf pdf = new ConvertSecurePdf();
                //pdf.NotPrintableImage();
                this.Hide();
                var  pdfForm = new SecurePdfForm();
                pdfForm.Show();
            }
            else
            {
                username.Text = "";
                password.Text = "";
                MessageBox.Show("Please enter correct username and password");
                
            }
        }
        
    }
}
