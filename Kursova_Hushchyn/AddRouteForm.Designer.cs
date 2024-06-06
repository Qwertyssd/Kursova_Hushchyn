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
            this.btnAdd.Font = new System.Drawing.Font("Noto Sans Armenian", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(589, 488);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Route";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chbConditioner
            // 
            this.chbConditioner.AutoSize = true;
            this.chbConditioner.Font = new System.Drawing.Font("Noto Sans Armenian", 10F);
            this.chbConditioner.Location = new System.Drawing.Point(5, 23);
            this.chbConditioner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbConditioner.Name = "chbConditioner";
            this.chbConditioner.Size = new System.Drawing.Size(117, 27);
            this.chbConditioner.TabIndex = 2;
            this.chbConditioner.Text = "Conditioner";
            this.chbConditioner.UseVisualStyleBackColor = true;
            // 
            // chbToilet
            // 
            this.chbToilet.AutoSize = true;
            this.chbToilet.Font = new System.Drawing.Font("Noto Sans Armenian", 10F);
            this.chbToilet.Location = new System.Drawing.Point(5, 51);
            this.chbToilet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbToilet.Name = "chbToilet";
            this.chbToilet.Size = new System.Drawing.Size(73, 27);
            this.chbToilet.TabIndex = 3;
            this.chbToilet.Text = "Toilet";
            this.chbToilet.UseVisualStyleBackColor = true;
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Font = new System.Drawing.Font("Noto Sans Armenian", 10F);
            this.chbInternet.Location = new System.Drawing.Point(5, 79);
            this.chbInternet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(88, 27);
            this.chbInternet.TabIndex = 4;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.gbOptions.Controls.Add(this.chbPowerOutlets);
            this.gbOptions.Controls.Add(this.chbToilet);
            this.gbOptions.Controls.Add(this.chbInternet);
            this.gbOptions.Controls.Add(this.chbConditioner);
            this.gbOptions.Font = new System.Drawing.Font("Noto Sans Armenian", 10F, System.Drawing.FontStyle.Bold);
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(12, 81);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOptions.Size = new System.Drawing.Size(207, 147);
            this.gbOptions.TabIndex = 5;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chbPowerOutlets
            // 
            this.chbPowerOutlets.AutoSize = true;
            this.chbPowerOutlets.Font = new System.Drawing.Font("Noto Sans Armenian", 10F);
            this.chbPowerOutlets.Location = new System.Drawing.Point(5, 106);
            this.chbPowerOutlets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPowerOutlets.Name = "chbPowerOutlets";
            this.chbPowerOutlets.Size = new System.Drawing.Size(137, 27);
            this.chbPowerOutlets.TabIndex = 5;
            this.chbPowerOutlets.Text = "Power Outlets";
            this.chbPowerOutlets.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtCapacity.Location = new System.Drawing.Point(395, 261);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(135, 26);
            this.txtCapacity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(238, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Passenger capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(243, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Route Number";
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(395, 78);
            this.txtRouteNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(135, 23);
            this.txtRouteNumber.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(238, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Carrier Company";
            // 
            // txtCarrierCompany
            // 
            this.txtCarrierCompany.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtCarrierCompany.Location = new System.Drawing.Point(395, 210);
            this.txtCarrierCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarrierCompany.Name = "txtCarrierCompany";
            this.txtCarrierCompany.Size = new System.Drawing.Size(135, 26);
            this.txtCarrierCompany.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(548, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtPrice.Location = new System.Drawing.Point(613, 210);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 26);
            this.txtPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(238, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(238, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Arrival Date";
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtDepartureDate.Location = new System.Drawing.Point(395, 308);
            this.txtDepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartureDate.Mask = "00/00/0000";
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(135, 26);
            this.txtDepartureDate.TabIndex = 16;
            this.txtDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtArrivalDate.Location = new System.Drawing.Point(395, 355);
            this.txtArrivalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArrivalDate.Mask = "00/00/0000";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(135, 26);
            this.txtArrivalDate.TabIndex = 17;
            this.txtArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(238, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stops";
            // 
            // txtStops
            // 
            this.txtStops.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtStops.Location = new System.Drawing.Point(311, 416);
            this.txtStops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStops.Name = "txtStops";
            this.txtStops.Size = new System.Drawing.Size(437, 26);
            this.txtStops.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Noto Sans Armenian", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(431, 489);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 42);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Noto Sans Armenian", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(19, 488);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 43);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(-5, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(771, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "             Add Bus Route                                                       " +
    "           ";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtModel.Location = new System.Drawing.Point(613, 170);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(135, 26);
            this.txtModel.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(548, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Model";
            // 
            // dgvTravelDurations
            // 
            this.dgvTravelDurations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTravelDurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravelDurations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StopsTime});
            this.dgvTravelDurations.Location = new System.Drawing.Point(12, 244);
            this.dgvTravelDurations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTravelDurations.Name = "dgvTravelDurations";
            this.dgvTravelDurations.RowHeadersWidth = 51;
            this.dgvTravelDurations.RowTemplate.Height = 24;
            this.dgvTravelDurations.Size = new System.Drawing.Size(207, 215);
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
            this.label10.Font = new System.Drawing.Font("Noto Sans Armenian", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(238, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stops Duration";
            // 
            // txtStopsDuration
            // 
            this.txtStopsDuration.Font = new System.Drawing.Font("Noto Sans Armenian", 8F);
            this.txtStopsDuration.Location = new System.Drawing.Point(395, 170);
            this.txtStopsDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStopsDuration.Mask = "00:00";
            this.txtStopsDuration.Name = "txtStopsDuration";
            this.txtStopsDuration.Size = new System.Drawing.Size(135, 26);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(762, 580);
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
            this.Font = new System.Drawing.Font("Noto Sans Armenian", 7F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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