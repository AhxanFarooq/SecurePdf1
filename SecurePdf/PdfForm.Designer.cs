
namespace SecurePdf
{
    partial class PdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfForm));
            this.file = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.destinationfolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileFromDirectory = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.Label();
            this.selectAFile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.convertToAFie = new System.Windows.Forms.Button();
            this.docFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(291, -83);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(0, 20);
            this.file.TabIndex = 1;
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(493, 356);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(0, 20);
            this.destination.TabIndex = 2;
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.convert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convert.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.convert.Location = new System.Drawing.Point(273, 437);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(224, 50);
            this.convert.TabIndex = 4;
            this.convert.Text = "Convert all file";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Folder:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.singleFile_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.singleFile_RunWorker);
            // 
            // destinationfolder
            // 
            this.destinationfolder.Location = new System.Drawing.Point(263, 352);
            this.destinationfolder.Name = "destinationfolder";
            this.destinationfolder.Size = new System.Drawing.Size(224, 29);
            this.destinationfolder.TabIndex = 3;
            this.destinationfolder.Text = "choose file";
            this.destinationfolder.UseVisualStyleBackColor = true;
            this.destinationfolder.Click += new System.EventHandler(this.destinationfolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Folder:";
            // 
            // OpenFileFromDirectory
            // 
            this.OpenFileFromDirectory.Location = new System.Drawing.Point(263, 286);
            this.OpenFileFromDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenFileFromDirectory.Name = "OpenFileFromDirectory";
            this.OpenFileFromDirectory.Size = new System.Drawing.Size(224, 31);
            this.OpenFileFromDirectory.TabIndex = 0;
            this.OpenFileFromDirectory.Text = "choose file";
            this.OpenFileFromDirectory.UseVisualStyleBackColor = true;
            this.OpenFileFromDirectory.Click += new System.EventHandler(this.OpenFileFromDirectory_Click);
            // 
            // filepath
            // 
            this.filepath.AutoSize = true;
            this.filepath.Location = new System.Drawing.Point(493, 291);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(0, 20);
            this.filepath.TabIndex = 7;
            // 
            // selectAFile
            // 
            this.selectAFile.AutoSize = true;
            this.selectAFile.Location = new System.Drawing.Point(504, 124);
            this.selectAFile.Name = "selectAFile";
            this.selectAFile.Size = new System.Drawing.Size(0, 20);
            this.selectAFile.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(146, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select File";
            // 
            // convertToAFie
            // 
            this.convertToAFie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.convertToAFie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertToAFie.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.convertToAFie.Location = new System.Drawing.Point(313, 173);
            this.convertToAFie.Name = "convertToAFie";
            this.convertToAFie.Size = new System.Drawing.Size(144, 36);
            this.convertToAFie.TabIndex = 12;
            this.convertToAFie.Text = "Convert a file";
            this.convertToAFie.UseVisualStyleBackColor = false;
            this.convertToAFie.Click += new System.EventHandler(this.convertToAFie_Click);
            // 
            // docFile
            // 
            this.docFile.Location = new System.Drawing.Point(263, 119);
            this.docFile.Name = "docFile";
            this.docFile.Size = new System.Drawing.Size(234, 31);
            this.docFile.TabIndex = 11;
            this.docFile.Text = "choose path";
            this.docFile.UseVisualStyleBackColor = true;
            this.docFile.Click += new System.EventHandler(this.docFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(302, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome Admin";
            // 
            // PdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.selectAFile);
            this.Controls.Add(this.convertToAFie);
            this.Controls.Add(this.docFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.destinationfolder);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.file);
            this.Controls.Add(this.OpenFileFromDirectory);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PdfForm";
            this.Text = "PdfForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button destinationfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenFileFromDirectory;
        private System.Windows.Forms.Label filepath;
        private System.Windows.Forms.Label selectAFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convertToAFie;
        private System.Windows.Forms.Button docFile;
        private System.Windows.Forms.Label label3;
    }
}