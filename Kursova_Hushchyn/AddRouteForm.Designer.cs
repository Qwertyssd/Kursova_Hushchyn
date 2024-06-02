namespace Kursova_Hushchyn
{
    partial class AddRouteForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chbConditioner = new System.Windows.Forms.CheckBox();
            this.chbToilet = new System.Windows.Forms.CheckBox();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chbPowerOutlets = new System.Windows.Forms.CheckBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarrierCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartureDate = new System.Windows.Forms.MaskedTextBox();
            this.txtArrivalDate = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStops = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvTravelDurations = new System.Windows.Forms.DataGridView();
            this.StopsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStopsDuration = new System.Windows.Forms.MaskedTextBox();
            this.busRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelDurations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 373);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Route";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chbConditioner
            // 
            this.chbConditioner.AutoSize = true;
            this.chbConditioner.Location = new System.Drawing.Point(4, 18);
            this.chbConditioner.Margin = new System.Windows.Forms.Padding(2);
            this.chbConditioner.Name = "chbConditioner";
            this.chbConditioner.Size = new System.Drawing.Size(79, 17);
            this.chbConditioner.TabIndex = 2;
            this.chbConditioner.Text = "Conditioner";
            this.chbConditioner.UseVisualStyleBackColor = true;
            // 
            // chbToilet
            // 
            this.chbToilet.AutoSize = true;
            this.chbToilet.Location = new System.Drawing.Point(4, 39);
            this.chbToilet.Margin = new System.Windows.Forms.Padding(2);
            this.chbToilet.Name = "chbToilet";
            this.chbToilet.Size = new System.Drawing.Size(52, 17);
            this.chbToilet.TabIndex = 3;
            this.chbToilet.Text = "Toilet";
            this.chbToilet.UseVisualStyleBackColor = true;
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Location = new System.Drawing.Point(4, 60);
            this.chbInternet.Margin = new System.Windows.Forms.Padding(2);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(62, 17);
            this.chbInternet.TabIndex = 4;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chbPowerOutlets);
            this.gbOptions.Controls.Add(this.chbToilet);
            this.gbOptions.Controls.Add(this.chbInternet);
            this.gbOptions.Controls.Add(this.chbConditioner);
            this.gbOptions.Location = new System.Drawing.Point(14, 62);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbOptions.Size = new System.Drawing.Size(150, 112);
            this.gbOptions.TabIndex = 5;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chbPowerOutlets
            // 
            this.chbPowerOutlets.AutoSize = true;
            this.chbPowerOutlets.Location = new System.Drawing.Point(4, 81);
            this.chbPowerOutlets.Margin = new System.Windows.Forms.Padding(2);
            this.chbPowerOutlets.Name = "chbPowerOutlets";
            this.chbPowerOutlets.Size = new System.Drawing.Size(92, 17);
            this.chbPowerOutlets.TabIndex = 5;
            this.chbPowerOutlets.Text = "Power Outlets";
            this.chbPowerOutlets.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(284, 195);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(102, 20);
            this.txtCapacity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Passenger capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Route Number";
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(362, 62);
            this.txtRouteNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(102, 20);
            this.txtRouteNumber.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Carrier Company";
            // 
            // txtCarrierCompany
            // 
            this.txtCarrierCompany.Location = new System.Drawing.Point(284, 161);
            this.txtCarrierCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarrierCompany.Name = "txtCarrierCompany";
            this.txtCarrierCompany.Size = new System.Drawing.Size(102, 20);
            this.txtCarrierCompany.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(460, 275);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(102, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Arrival Date";
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(284, 236);
            this.txtDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartureDate.Mask = "00/00/0000";
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(102, 20);
            this.txtDepartureDate.TabIndex = 16;
            this.txtDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(284, 275);
            this.txtArrivalDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtArrivalDate.Mask = "00/00/0000";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(102, 20);
            this.txtArrivalDate.TabIndex = 17;
            this.txtArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stops";
            // 
            // txtStops
            // 
            this.txtStops.Location = new System.Drawing.Point(284, 318);
            this.txtStops.Margin = new System.Windows.Forms.Padding(2);
            this.txtStops.Name = "txtStops";
            this.txtStops.Size = new System.Drawing.Size(278, 20);
            this.txtStops.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(165, 374);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 32);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(14, 373);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 33);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Add Bus Route";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(460, 236);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(102, 20);
            this.txtModel.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 236);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Model";
            // 
            // dgvTravelDurations
            // 
            this.dgvTravelDurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravelDurations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StopsTime});
            this.dgvTravelDurations.Location = new System.Drawing.Point(9, 187);
            this.dgvTravelDurations.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTravelDurations.Name = "dgvTravelDurations";
            this.dgvTravelDurations.RowHeadersWidth = 51;
            this.dgvTravelDurations.RowTemplate.Height = 24;
            this.dgvTravelDurations.Size = new System.Drawing.Size(136, 164);
            this.dgvTravelDurations.TabIndex = 25;
            // 
            // StopsTime
            // 
            this.StopsTime.HeaderText = "StopsTime";
            this.StopsTime.MinimumWidth = 6;
            this.StopsTime.Name = "StopsTime";
            this.StopsTime.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stops Duration";
            // 
            // txtStopsDuration
            // 
            this.txtStopsDuration.Location = new System.Drawing.Point(284, 125);
            this.txtStopsDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopsDuration.Mask = "00:00";
            this.txtStopsDuration.Name = "txtStopsDuration";
            this.txtStopsDuration.Size = new System.Drawing.Size(102, 20);
            this.txtStopsDuration.TabIndex = 27;
            this.txtStopsDuration.ValidatingType = typeof(System.DateTime);
            // 
            // busRoutesBindingSource
            // 
            this.busRoutesBindingSource.DataMember = "BusRoutes";
            this.busRoutesBindingSource.DataSource = this.routeListBindingSource;
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataSource = typeof(Kursova_Hushchyn.RouteList);
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 417);
            this.Controls.Add(this.txtStopsDuration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvTravelDurations);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtStops);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarrierCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRouteNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddRouteForm";
            this.Text = "UKR BUS";
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelDurations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chbConditioner;
        private System.Windows.Forms.CheckBox chbToilet;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.CheckBox chbPowerOutlets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarrierCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDepartureDate;
        private System.Windows.Forms.MaskedTextBox txtArrivalDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStops;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvTravelDurations;
        private System.Windows.Forms.BindingSource busRoutesBindingSource;
        private System.Windows.Forms.BindingSource routeListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopsTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtStopsDuration;
    }
}