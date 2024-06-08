namespace Kursova_Hushchyn
{
    partial class deleteRouteForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.lblRouteNumber = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(305, 237);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 51);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(213, 64);
            this.txtRouteNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(250, 19);
            this.txtRouteNumber.TabIndex = 2;
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRouteNumber.Location = new System.Drawing.Point(18, 69);
            this.lblRouteNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(100, 15);
            this.lblRouteNumber.TabIndex = 2;
            this.lblRouteNumber.Text = "Route Number";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblModel.Location = new System.Drawing.Point(18, 116);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(90, 15);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model of bus";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(213, 111);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(250, 19);
            this.txtModel.TabIndex = 3;
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarrier.Location = new System.Drawing.Point(18, 163);
            this.lblCarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(51, 15);
            this.lblCarrier.TabIndex = 6;
            this.lblCarrier.Text = "Carrier";
            // 
            // txtCarrier
            // 
            this.txtCarrier.Location = new System.Drawing.Point(213, 162);
            this.txtCarrier.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(250, 19);
            this.txtCarrier.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ticket Number";
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Location = new System.Drawing.Point(213, 21);
            this.txtTicketNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(250, 19);
            this.txtTicketNumber.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(21, 237);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 51);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // deleteRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(507, 354);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarrier);
            this.Controls.Add(this.txtCarrier);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblRouteNumber);
            this.Controls.Add(this.txtRouteNumber);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "deleteRouteForm";
            this.Text = "deleteRouteForm";
            this.Load += new System.EventHandler(this.deleteRouteForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteRouteForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.Label lblRouteNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.TextBox txtCarrier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.Button btnClose;
    }
}