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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShowDepartures = new System.Windows.Forms.DataGridView();
            this.Departures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowArrivals = new System.Windows.Forms.DataGridView();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.Arrivals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDateOfTrip = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDepartures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowArrivals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(680, 407);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(108, 31);
            this.btnAddTicket.TabIndex = 0;
            this.btnAddTicket.Text = "Book A Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Of Birth";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(97, 102);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 268);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dgvShowDepartures
            // 
            this.dgvShowDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDepartures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departures});
            this.dgvShowDepartures.Location = new System.Drawing.Point(292, 124);
            this.dgvShowDepartures.Name = "dgvShowDepartures";
            this.dgvShowDepartures.Size = new System.Drawing.Size(176, 150);
            this.dgvShowDepartures.TabIndex = 8;
            this.dgvShowDepartures.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDepartures_CellClick);
            // 
            // Departures
            // 
            this.Departures.HeaderText = "Departures";
            this.Departures.Name = "Departures";
            // 
            // dgvShowArrivals
            // 
            this.dgvShowArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowArrivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrivals});
            this.dgvShowArrivals.Location = new System.Drawing.Point(532, 124);
            this.dgvShowArrivals.Name = "dgvShowArrivals";
            this.dgvShowArrivals.Size = new System.Drawing.Size(144, 150);
            this.dgvShowArrivals.TabIndex = 9;
            this.dgvShowArrivals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowArrivals_CellClick);
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(292, 89);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(176, 20);
            this.txtDeparture.TabIndex = 10;
            this.txtDeparture.TextChanged += new System.EventHandler(this.txtDeparture_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deparure Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Arrival Point";
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(532, 89);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(134, 20);
            this.txtArrival.TabIndex = 13;
            this.txtArrival.TextChanged += new System.EventHandler(this.txtArrival_TextChanged);
            // 
            // Arrivals
            // 
            this.Arrivals.HeaderText = "Arrivals";
            this.Arrivals.Name = "Arrivals";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arrival Point";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Departure Point";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // txtDateOfTrip
            // 
            this.txtDateOfTrip.Location = new System.Drawing.Point(371, 337);
            this.txtDateOfTrip.Mask = "00/00/0000";
            this.txtDateOfTrip.Name = "txtDateOfTrip";
            this.txtDateOfTrip.Size = new System.Drawing.Size(100, 20);
            this.txtDateOfTrip.TabIndex = 15;
            this.txtDateOfTrip.ValidatingType = typeof(System.DateTime);
            this.txtDateOfTrip.TextChanged += new System.EventHandler(this.txtDateOfTrip_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date of Trip";
            // 
            // ticketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDateOfTrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.dgvShowArrivals);
            this.Controls.Add(this.dgvShowDepartures);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTicket);
            this.Name = "ticketsForm";
            this.Text = "ticketsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDepartures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowArrivals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvShowDepartures;
        private System.Windows.Forms.DataGridView dgvShowArrivals;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrivals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox txtDateOfTrip;
        private System.Windows.Forms.Label label8;
    }
}