namespace Kursova_Hushchyn
{
    partial class UserMainForm
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
            this.btnSearchTickets = new System.Windows.Forms.Button();
            this.btnSearchRoutes = new System.Windows.Forms.Button();
            this.btnTicketOperations = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchTickets
            // 
            this.btnSearchTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSearchTickets.ForeColor = System.Drawing.Color.White;
            this.btnSearchTickets.Location = new System.Drawing.Point(21, 246);
            this.btnSearchTickets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchTickets.Name = "btnSearchTickets";
            this.btnSearchTickets.Size = new System.Drawing.Size(271, 52);
            this.btnSearchTickets.TabIndex = 7;
            this.btnSearchTickets.Text = "Search Tickets";
            this.btnSearchTickets.UseVisualStyleBackColor = false;
            this.btnSearchTickets.Click += new System.EventHandler(this.btnSearchTickets_Click);
            // 
            // btnSearchRoutes
            // 
            this.btnSearchRoutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSearchRoutes.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoutes.Location = new System.Drawing.Point(21, 158);
            this.btnSearchRoutes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchRoutes.Name = "btnSearchRoutes";
            this.btnSearchRoutes.Size = new System.Drawing.Size(271, 52);
            this.btnSearchRoutes.TabIndex = 6;
            this.btnSearchRoutes.Text = "Search Routes";
            this.btnSearchRoutes.UseVisualStyleBackColor = false;
            this.btnSearchRoutes.Click += new System.EventHandler(this.btnSearchRoutes_Click);
            // 
            // btnTicketOperations
            // 
            this.btnTicketOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnTicketOperations.ForeColor = System.Drawing.Color.White;
            this.btnTicketOperations.Location = new System.Drawing.Point(21, 344);
            this.btnTicketOperations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTicketOperations.Name = "btnTicketOperations";
            this.btnTicketOperations.Size = new System.Drawing.Size(271, 52);
            this.btnTicketOperations.TabIndex = 8;
            this.btnTicketOperations.Text = "Ticket Operations";
            this.btnTicketOperations.UseVisualStyleBackColor = false;
            this.btnTicketOperations.Click += new System.EventHandler(this.btnTicketOperations_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(618, 458);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label1.Font = new System.Drawing.Font("Noto Sans Armenian", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "                                      MAIN MENU                                  " +
    "   ";
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(917, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTicketOperations);
            this.Controls.Add(this.btnSearchTickets);
            this.Controls.Add(this.btnSearchRoutes);
            this.Font = new System.Drawing.Font("Noto Sans Armenian", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserMainForm";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchTickets;
        private System.Windows.Forms.Button btnSearchRoutes;
        private System.Windows.Forms.Button btnTicketOperations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}