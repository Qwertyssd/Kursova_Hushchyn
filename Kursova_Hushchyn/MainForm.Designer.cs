namespace Kursova_Hushchyn
{
    partial class MainForm
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
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnSearchRoutes = new System.Windows.Forms.Button();
            this.btnTicketOperations = new System.Windows.Forms.Button();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.btnFileOperations = new System.Windows.Forms.Button();
            this.btnSearchTickets = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(87, 104);
            this.btnAddRoute.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(142, 33);
            this.btnAddRoute.TabIndex = 0;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnSearchRoutes
            // 
            this.btnSearchRoutes.Location = new System.Drawing.Point(87, 196);
            this.btnSearchRoutes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRoutes.Name = "btnSearchRoutes";
            this.btnSearchRoutes.Size = new System.Drawing.Size(142, 29);
            this.btnSearchRoutes.TabIndex = 1;
            this.btnSearchRoutes.Text = "Search Routes";
            this.btnSearchRoutes.UseVisualStyleBackColor = true;
            this.btnSearchRoutes.Click += new System.EventHandler(this.btnSearchRoutes_Click);
            // 
            // btnTicketOperations
            // 
            this.btnTicketOperations.Location = new System.Drawing.Point(350, 104);
            this.btnTicketOperations.Margin = new System.Windows.Forms.Padding(2);
            this.btnTicketOperations.Name = "btnTicketOperations";
            this.btnTicketOperations.Size = new System.Drawing.Size(148, 29);
            this.btnTicketOperations.TabIndex = 2;
            this.btnTicketOperations.Text = "Ticket Operations";
            this.btnTicketOperations.UseVisualStyleBackColor = true;
            this.btnTicketOperations.Click += new System.EventHandler(this.btnTicketOperations_Click);
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.Location = new System.Drawing.Point(87, 273);
            this.btnDeleteRoute.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(142, 33);
            this.btnDeleteRoute.TabIndex = 3;
            this.btnDeleteRoute.Text = "Delete Route";
            this.btnDeleteRoute.UseVisualStyleBackColor = true;
            this.btnDeleteRoute.Click += new System.EventHandler(this.btnDeleteRoute_Click);
            // 
            // btnFileOperations
            // 
            this.btnFileOperations.Location = new System.Drawing.Point(350, 245);
            this.btnFileOperations.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileOperations.Name = "btnFileOperations";
            this.btnFileOperations.Size = new System.Drawing.Size(142, 33);
            this.btnFileOperations.TabIndex = 4;
            this.btnFileOperations.Text = "File Management";
            this.btnFileOperations.UseVisualStyleBackColor = true;
            this.btnFileOperations.Click += new System.EventHandler(this.btnFileOperations_Click);
            // 
            // btnSearchTickets
            // 
            this.btnSearchTickets.Location = new System.Drawing.Point(350, 167);
            this.btnSearchTickets.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTickets.Name = "btnSearchTickets";
            this.btnSearchTickets.Size = new System.Drawing.Size(148, 29);
            this.btnSearchTickets.TabIndex = 5;
            this.btnSearchTickets.Text = "Search Tickets";
            this.btnSearchTickets.UseVisualStyleBackColor = true;
            this.btnSearchTickets.Click += new System.EventHandler(this.btnSearchTickets_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(350, 311);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchTickets);
            this.Controls.Add(this.btnFileOperations);
            this.Controls.Add(this.btnDeleteRoute);
            this.Controls.Add(this.btnTicketOperations);
            this.Controls.Add(this.btnSearchRoutes);
            this.Controls.Add(this.btnAddRoute);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "UKR BUS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnSearchRoutes;
        private System.Windows.Forms.Button btnTicketOperations;
        private System.Windows.Forms.Button btnDeleteRoute;
        private System.Windows.Forms.Button btnFileOperations;
        private System.Windows.Forms.Button btnSearchTickets;
        private System.Windows.Forms.Button btnExit;
    }
}