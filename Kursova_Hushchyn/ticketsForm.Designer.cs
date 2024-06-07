namespace Kursova_Hushchyn
{
    partial class ticketsForm
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
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.dgvShowDepartures = new System.Windows.Forms.DataGridView();
            this.Departures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowArrivals = new System.Windows.Forms.DataGridView();
            this.Arrivals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtDateOfTrip = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDepartures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowArrivals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnAddTicket.ForeColor = System.Drawing.Color.White;
            this.btnAddTicket.Location = new System.Drawing.Point(557, 531);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(198, 55);
            this.btnAddTicket.TabIndex = 6;
            this.btnAddTicket.Text = "Book A Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // dgvShowDepartures
            // 
            this.dgvShowDepartures.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShowDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departures});
            this.dgvShowDepartures.Location = new System.Drawing.Point(32, 231);
            this.dgvShowDepartures.Margin = new System.Windows.Forms.Padding(6);
            this.dgvShowDepartures.Name = "dgvShowDepartures";
            this.dgvShowDepartures.RowHeadersWidth = 51;
            this.dgvShowDepartures.Size = new System.Drawing.Size(264, 266);
            this.dgvShowDepartures.TabIndex = 2;
            this.dgvShowDepartures.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDepartures_CellClick);
            // 
            // Departures
            // 
            this.Departures.HeaderText = "Departures";
            this.Departures.MinimumWidth = 6;
            this.Departures.Name = "Departures";
            this.Departures.ReadOnly = true;
            this.Departures.Width = 125;
            // 
            // dgvShowArrivals
            // 
            this.dgvShowArrivals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShowArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowArrivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrivals});
            this.dgvShowArrivals.Location = new System.Drawing.Point(402, 231);
            this.dgvShowArrivals.Margin = new System.Windows.Forms.Padding(6);
            this.dgvShowArrivals.Name = "dgvShowArrivals";
            this.dgvShowArrivals.RowHeadersWidth = 51;
            this.dgvShowArrivals.Size = new System.Drawing.Size(264, 266);
            this.dgvShowArrivals.TabIndex = 5;
            this.dgvShowArrivals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowArrivals_CellClick);
            // 
            // Arrivals
            // 
            this.Arrivals.HeaderText = "Arrivals";
            this.Arrivals.MinimumWidth = 6;
            this.Arrivals.Name = "Arrivals";
            this.Arrivals.ReadOnly = true;
            this.Arrivals.Width = 125;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(32, 172);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(6);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(264, 23);
            this.txtDeparture.TabIndex = 3;
            this.txtDeparture.TextChanged += new System.EventHandler(this.txtDeparture_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deparure Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label5.Location = new System.Drawing.Point(398, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Arrival Point";
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(402, 172);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(6);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(264, 23);
            this.txtArrival.TabIndex = 4;
            this.txtArrival.TextChanged += new System.EventHandler(this.txtArrival_TextChanged);
            // 
            // txtDateOfTrip
            // 
            this.txtDateOfTrip.Location = new System.Drawing.Point(147, 509);
            this.txtDateOfTrip.Margin = new System.Windows.Forms.Padding(6);
            this.txtDateOfTrip.Mask = "00/00/0000";
            this.txtDateOfTrip.Name = "txtDateOfTrip";
            this.txtDateOfTrip.Size = new System.Drawing.Size(149, 23);
            this.txtDateOfTrip.TabIndex = 1;
            this.txtDateOfTrip.ValidatingType = typeof(System.DateTime);
            this.txtDateOfTrip.TextChanged += new System.EventHandler(this.txtDateOfTrip_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label8.Location = new System.Drawing.Point(28, 516);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date of Trip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "                             FIND TICKETS                          ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(347, 531);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 55);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ticketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(788, 606);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateOfTrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.dgvShowArrivals);
            this.Controls.Add(this.dgvShowDepartures);
            this.Controls.Add(this.btnAddTicket);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ticketsForm";
            this.Text = "Find Bus";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ticketsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDepartures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowArrivals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.DataGridView dgvShowDepartures;
        private System.Windows.Forms.DataGridView dgvShowArrivals;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departures;
        private System.Windows.Forms.MaskedTextBox txtDateOfTrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrivals;
        private System.Windows.Forms.Button btnClose;
    }
}