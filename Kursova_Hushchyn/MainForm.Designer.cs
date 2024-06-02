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
            this.SuspendLayout();
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(116, 138);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(108, 23);
            this.btnAddRoute.TabIndex = 0;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnSearchRoutes
            // 
            this.btnSearchRoutes.Location = new System.Drawing.Point(116, 222);
            this.btnSearchRoutes.Name = "btnSearchRoutes";
            this.btnSearchRoutes.Size = new System.Drawing.Size(108, 23);
            this.btnSearchRoutes.TabIndex = 1;
            this.btnSearchRoutes.Text = "Search Routes";
            this.btnSearchRoutes.UseVisualStyleBackColor = true;
            this.btnSearchRoutes.Click += new System.EventHandler(this.btnSearchRoutes_Click);
            // 
            // btnTicketOperations
            // 
            this.btnTicketOperations.Location = new System.Drawing.Point(324, 138);
            this.btnTicketOperations.Name = "btnTicketOperations";
            this.btnTicketOperations.Size = new System.Drawing.Size(196, 23);
            this.btnTicketOperations.TabIndex = 2;
            this.btnTicketOperations.Text = "Ticket Operations";
            this.btnTicketOperations.UseVisualStyleBackColor = true;
            this.btnTicketOperations.Click += new System.EventHandler(this.btnTicketOperations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTicketOperations);
            this.Controls.Add(this.btnSearchRoutes);
            this.Controls.Add(this.btnAddRoute);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnSearchRoutes;
        private System.Windows.Forms.Button btnTicketOperations;
    }
}