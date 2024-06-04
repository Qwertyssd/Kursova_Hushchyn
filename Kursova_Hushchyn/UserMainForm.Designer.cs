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
            this.SuspendLayout();
            // 
            // btnSearchTickets
            // 
            this.btnSearchTickets.Location = new System.Drawing.Point(11, 139);
            this.btnSearchTickets.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTickets.Name = "btnSearchTickets";
            this.btnSearchTickets.Size = new System.Drawing.Size(148, 29);
            this.btnSearchTickets.TabIndex = 7;
            this.btnSearchTickets.Text = "Search Tickets";
            this.btnSearchTickets.UseVisualStyleBackColor = true;
            this.btnSearchTickets.Click += new System.EventHandler(this.btnSearchTickets_Click);
            // 
            // btnSearchRoutes
            // 
            this.btnSearchRoutes.Location = new System.Drawing.Point(11, 89);
            this.btnSearchRoutes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRoutes.Name = "btnSearchRoutes";
            this.btnSearchRoutes.Size = new System.Drawing.Size(148, 29);
            this.btnSearchRoutes.TabIndex = 6;
            this.btnSearchRoutes.Text = "Search Routes";
            this.btnSearchRoutes.UseVisualStyleBackColor = true;
            this.btnSearchRoutes.Click += new System.EventHandler(this.btnSearchRoutes_Click);
            // 
            // btnTicketOperations
            // 
            this.btnTicketOperations.Location = new System.Drawing.Point(11, 194);
            this.btnTicketOperations.Margin = new System.Windows.Forms.Padding(2);
            this.btnTicketOperations.Name = "btnTicketOperations";
            this.btnTicketOperations.Size = new System.Drawing.Size(148, 29);
            this.btnTicketOperations.TabIndex = 8;
            this.btnTicketOperations.Text = "Ticket Operations";
            this.btnTicketOperations.UseVisualStyleBackColor = true;
            this.btnTicketOperations.Click += new System.EventHandler(this.btnTicketOperations_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 236);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 280);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTicketOperations);
            this.Controls.Add(this.btnSearchTickets);
            this.Controls.Add(this.btnSearchRoutes);
            this.Name = "UserMainForm";
            this.Text = "UserMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchTickets;
        private System.Windows.Forms.Button btnSearchRoutes;
        private System.Windows.Forms.Button btnTicketOperations;
        private System.Windows.Forms.Button btnExit;
    }
}