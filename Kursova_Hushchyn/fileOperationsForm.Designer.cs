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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(116, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Routes To File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(491, 201);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(228, 35);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Routes From File";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUploadTickets
            // 
            this.btnUploadTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnUploadTickets.ForeColor = System.Drawing.Color.White;
            this.btnUploadTickets.Location = new System.Drawing.Point(491, 257);
            this.btnUploadTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUploadTickets.Name = "btnUploadTickets";
            this.btnUploadTickets.Size = new System.Drawing.Size(228, 35);
            this.btnUploadTickets.TabIndex = 3;
            this.btnUploadTickets.Text = "Tickets From File";
            this.btnUploadTickets.UseVisualStyleBackColor = false;
            this.btnUploadTickets.Click += new System.EventHandler(this.btnUploadTickets_Click);
            // 
            // btnSaveTickets
            // 
            this.btnSaveTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSaveTickets.ForeColor = System.Drawing.Color.White;
            this.btnSaveTickets.Location = new System.Drawing.Point(116, 257);
            this.btnSaveTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTickets.Name = "btnSaveTickets";
            this.btnSaveTickets.Size = new System.Drawing.Size(228, 35);
            this.btnSaveTickets.TabIndex = 2;
            this.btnSaveTickets.Text = "Tickets To File";
            this.btnSaveTickets.UseVisualStyleBackColor = false;
            this.btnSaveTickets.Click += new System.EventHandler(this.btnSaveTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label1.Font = new System.Drawing.Font("Noto Sans Armenian", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(-2, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "              OPERATIONS WITH TICKETS                    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Armenian", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(112, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Armenian", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(487, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Upload:";
            // 
            // fileOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(873, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadTickets);
            this.Controls.Add(this.btnSaveTickets);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Noto Sans Armenian", 9F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fileOperationsForm";
            this.ShowIcon = false;
            this.Text = "File operations  ";
            this.Load += new System.EventHandler(this.fileOperationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnUploadTickets;
        private System.Windows.Forms.Button btnSaveTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}