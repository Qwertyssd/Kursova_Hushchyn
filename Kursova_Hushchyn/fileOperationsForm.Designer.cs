namespace Kursova_Hushchyn
{
    partial class fileOperationsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnUploadTickets = new System.Windows.Forms.Button();
            this.btnSaveTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(77, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Routes To File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(77, 216);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(152, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload Routes From File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUploadTickets
            // 
            this.btnUploadTickets.Location = new System.Drawing.Point(489, 216);
            this.btnUploadTickets.Name = "btnUploadTickets";
            this.btnUploadTickets.Size = new System.Drawing.Size(152, 23);
            this.btnUploadTickets.TabIndex = 3;
            this.btnUploadTickets.Text = "Upload Tickets From File";
            this.btnUploadTickets.UseVisualStyleBackColor = true;
            this.btnUploadTickets.Click += new System.EventHandler(this.btnUploadTickets_Click);
            // 
            // btnSaveTickets
            // 
            this.btnSaveTickets.Location = new System.Drawing.Point(489, 147);
            this.btnSaveTickets.Name = "btnSaveTickets";
            this.btnSaveTickets.Size = new System.Drawing.Size(152, 23);
            this.btnSaveTickets.TabIndex = 2;
            this.btnSaveTickets.Text = "Save Tickets To File";
            this.btnSaveTickets.UseVisualStyleBackColor = true;
            this.btnSaveTickets.Click += new System.EventHandler(this.btnSaveTickets_Click);
            // 
            // fileOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUploadTickets);
            this.Controls.Add(this.btnSaveTickets);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSave);
            this.Name = "fileOperationsForm";
            this.Text = "fileOperationsForm";
            this.Load += new System.EventHandler(this.fileOperationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnUploadTickets;
        private System.Windows.Forms.Button btnSaveTickets;
    }
}