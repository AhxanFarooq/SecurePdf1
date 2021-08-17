
namespace SecurePdf
{
    partial class SecurePdfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurePdfForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.convertFile = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.folderPath = new System.Windows.Forms.Label();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.selectDestination = new System.Windows.Forms.Button();
            this.destinationPath = new System.Windows.Forms.Label();
            this.convertFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(1249, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILE CONVERTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28713F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel2.Controls.Add(this.selectFileBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.convertFile, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.filePath, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 173);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1252, 125);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            this.selectFileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectFileBtn.ForeColor = System.Drawing.Color.White;
            this.selectFileBtn.Location = new System.Drawing.Point(93, 31);
            this.selectFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(230, 63);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "Select/Open File";
            this.selectFileBtn.UseVisualStyleBackColor = false;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // convertFile
            // 
            this.convertFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convertFile.BackColor = System.Drawing.Color.Sienna;
            this.convertFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertFile.ForeColor = System.Drawing.Color.White;
            this.convertFile.Location = new System.Drawing.Point(967, 33);
            this.convertFile.Name = "convertFile";
            this.convertFile.Size = new System.Drawing.Size(200, 59);
            this.convertFile.TabIndex = 2;
            this.convertFile.Text = "Convert File";
            this.convertFile.UseVisualStyleBackColor = false;
            this.convertFile.Click += new System.EventHandler(this.convertFile_Click);
            // 
            // filePath
            // 
            this.filePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filePath.BackColor = System.Drawing.Color.White;
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePath.Location = new System.Drawing.Point(323, 32);
            this.filePath.Margin = new System.Windows.Forms.Padding(0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(509, 60);
            this.filePath.TabIndex = 3;
            this.filePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28713F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel3.Controls.Add(this.folderPath, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.selectFolderBtn, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 374);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1252, 68);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // folderPath
            // 
            this.folderPath.BackColor = System.Drawing.Color.White;
            this.folderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderPath.Location = new System.Drawing.Point(323, 0);
            this.folderPath.Margin = new System.Windows.Forms.Padding(0);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(509, 60);
            this.folderPath.TabIndex = 4;
            this.folderPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            this.selectFolderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectFolderBtn.ForeColor = System.Drawing.Color.White;
            this.selectFolderBtn.Location = new System.Drawing.Point(93, 0);
            this.selectFolderBtn.Margin = new System.Windows.Forms.Padding(0);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(230, 63);
            this.selectFolderBtn.TabIndex = 3;
            this.selectFolderBtn.Text = "Select Folder";
            this.selectFolderBtn.UseVisualStyleBackColor = false;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28713F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel4.Controls.Add(this.selectDestination, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.destinationPath, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.convertFolder, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 467);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1252, 71);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // selectDestination
            // 
            this.selectDestination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            this.selectDestination.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectDestination.ForeColor = System.Drawing.Color.White;
            this.selectDestination.Location = new System.Drawing.Point(93, 0);
            this.selectDestination.Margin = new System.Windows.Forms.Padding(0);
            this.selectDestination.Name = "selectDestination";
            this.selectDestination.Size = new System.Drawing.Size(230, 63);
            this.selectDestination.TabIndex = 3;
            this.selectDestination.Text = "Enter Destination";
            this.selectDestination.UseVisualStyleBackColor = false;
            this.selectDestination.Click += new System.EventHandler(this.selectDestination_Click);
            // 
            // destinationPath
            // 
            this.destinationPath.BackColor = System.Drawing.Color.White;
            this.destinationPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destinationPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationPath.Location = new System.Drawing.Point(323, 0);
            this.destinationPath.Margin = new System.Windows.Forms.Padding(0);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(509, 60);
            this.destinationPath.TabIndex = 4;
            this.destinationPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertFolder
            // 
            this.convertFolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.convertFolder.BackColor = System.Drawing.Color.Sienna;
            this.convertFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertFolder.ForeColor = System.Drawing.Color.White;
            this.convertFolder.Location = new System.Drawing.Point(967, 3);
            this.convertFolder.Name = "convertFolder";
            this.convertFolder.Size = new System.Drawing.Size(200, 62);
            this.convertFolder.TabIndex = 2;
            this.convertFolder.Text = "Convert All Files";
            this.convertFolder.UseVisualStyleBackColor = false;
            this.convertFolder.Click += new System.EventHandler(this.convertFolder_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 653);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1255, 41);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(1249, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Developed by AIMS IT Solutions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(503, 281);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(205, 161);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 10;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.convertFolder_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.convertFolder_RunWorker);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.convertFile_DoWorker);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.convertFile_RunWorker);
            // 
            // SecurePdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 706);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SecurePdfForm";
            this.Text = "SecurePdfForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Button convertFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button convertFolder;
        private System.Windows.Forms.Button selectDestination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox loading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label folderPath;
        private System.Windows.Forms.Label destinationPath;
    }
}