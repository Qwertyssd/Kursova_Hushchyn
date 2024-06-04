namespace Kursova_Hushchyn
{
    partial class createTicketForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeparturePoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArrivalPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.busRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCarrierCompany = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chbPowerOutlets = new System.Windows.Forms.CheckBox();
            this.chbToilet = new System.Windows.Forms.CheckBox();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.chbConditioner = new System.Windows.Forms.CheckBox();
            this.txtPriceLow = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPriceHigh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDepartureTime = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArrivalTime = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbHighToLow = new System.Windows.Forms.RadioButton();
            this.gbSorts = new System.Windows.Forms.GroupBox();
            this.rbLowToHigh = new System.Windows.Forms.RadioButton();
            this.routeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRouteNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDeparturePoint);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtArrivalPoint);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 268);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(97, 222);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRouteNumber.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Route Number";
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
            // txtDeparturePoint
            // 
            this.txtDeparturePoint.Location = new System.Drawing.Point(97, 142);
            this.txtDeparturePoint.Name = "txtDeparturePoint";
            this.txtDeparturePoint.Size = new System.Drawing.Size(100, 20);
            this.txtDeparturePoint.TabIndex = 7;
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
            // txtArrivalPoint
            // 
            this.txtArrivalPoint.Location = new System.Drawing.Point(97, 180);
            this.txtArrivalPoint.Name = "txtArrivalPoint";
            this.txtArrivalPoint.Size = new System.Drawing.Size(100, 20);
            this.txtArrivalPoint.TabIndex = 10;
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
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(97, 102);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 6;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(97, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.AutoGenerateColumns = false;
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeNumberDataGridViewTextBoxColumn,
            this.carrierCompanyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.availableSeatsDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.dgvRoutes.DataSource = this.busRoutesBindingSource;
            this.dgvRoutes.Location = new System.Drawing.Point(240, 21);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.Size = new System.Drawing.Size(749, 256);
            this.dgvRoutes.TabIndex = 9;
            this.dgvRoutes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoutes_CellClick);
            // 
            // busRoutesBindingSource
            // 
            this.busRoutesBindingSource.DataMember = "BusRoutes";
            this.busRoutesBindingSource.DataSource = this.routeListBindingSource;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(948, 576);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 48);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrival,
            this.Departure,
            this.Stop});
            this.dgvSchedule.Location = new System.Drawing.Point(696, 298);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(410, 230);
            this.dgvSchedule.TabIndex = 51;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // Stop
            // 
            this.Stop.HeaderText = "Stop";
            this.Stop.Name = "Stop";
            this.Stop.ReadOnly = true;
            this.Stop.Width = 165;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 42);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Carrier Company";
            // 
            // txtCarrierCompany
            // 
            this.txtCarrierCompany.Location = new System.Drawing.Point(142, 35);
            this.txtCarrierCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarrierCompany.Name = "txtCarrierCompany";
            this.txtCarrierCompany.Size = new System.Drawing.Size(102, 20);
            this.txtCarrierCompany.TabIndex = 33;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chbPowerOutlets);
            this.gbOptions.Controls.Add(this.chbToilet);
            this.gbOptions.Controls.Add(this.chbInternet);
            this.gbOptions.Controls.Add(this.chbConditioner);
            this.gbOptions.Location = new System.Drawing.Point(58, 349);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbOptions.Size = new System.Drawing.Size(176, 152);
            this.gbOptions.TabIndex = 48;
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
            // txtPriceLow
            // 
            this.txtPriceLow.Location = new System.Drawing.Point(142, 109);
            this.txtPriceLow.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceLow.Name = "txtPriceLow";
            this.txtPriceLow.Size = new System.Drawing.Size(102, 20);
            this.txtPriceLow.TabIndex = 35;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(142, 75);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(102, 20);
            this.txtModel.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Price Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Model";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 185);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Departure Time";
            // 
            // txtPriceHigh
            // 
            this.txtPriceHigh.Location = new System.Drawing.Point(142, 138);
            this.txtPriceHigh.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceHigh.Name = "txtPriceHigh";
            this.txtPriceHigh.Size = new System.Drawing.Size(102, 20);
            this.txtPriceHigh.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Arrival Time";
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(142, 178);
            this.txtDepartureTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartureTime.Mask = "00:00";
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(102, 20);
            this.txtDepartureTime.TabIndex = 48;
            this.txtDepartureTime.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Price Max";
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(142, 211);
            this.txtArrivalTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtArrivalTime.Mask = "00:00";
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(102, 20);
            this.txtArrivalTime.TabIndex = 49;
            this.txtArrivalTime.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArrivalTime);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDepartureTime);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPriceHigh);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtCarrierCompany);
            this.groupBox2.Controls.Add(this.txtPriceLow);
            this.groupBox2.Location = new System.Drawing.Point(327, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 284);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(789, 576);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 48);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbHighToLow
            // 
            this.rbHighToLow.AutoSize = true;
            this.rbHighToLow.Location = new System.Drawing.Point(6, 46);
            this.rbHighToLow.Name = "rbHighToLow";
            this.rbHighToLow.Size = new System.Drawing.Size(86, 17);
            this.rbHighToLow.TabIndex = 54;
            this.rbHighToLow.TabStop = true;
            this.rbHighToLow.Text = "High To Low";
            this.rbHighToLow.UseVisualStyleBackColor = true;
            this.rbHighToLow.CheckedChanged += new System.EventHandler(this.rbHighToLow_CheckedChanged);
            // 
            // gbSorts
            // 
            this.gbSorts.Controls.Add(this.rbLowToHigh);
            this.gbSorts.Controls.Add(this.rbHighToLow);
            this.gbSorts.Location = new System.Drawing.Point(35, 521);
            this.gbSorts.Name = "gbSorts";
            this.gbSorts.Size = new System.Drawing.Size(268, 110);
            this.gbSorts.TabIndex = 55;
            this.gbSorts.TabStop = false;
            this.gbSorts.Text = "groupBox3";
            // 
            // rbLowToHigh
            // 
            this.rbLowToHigh.AutoSize = true;
            this.rbLowToHigh.Location = new System.Drawing.Point(6, 71);
            this.rbLowToHigh.Name = "rbLowToHigh";
            this.rbLowToHigh.Size = new System.Drawing.Size(86, 17);
            this.rbLowToHigh.TabIndex = 55;
            this.rbLowToHigh.TabStop = true;
            this.rbLowToHigh.Text = "Low To High";
            this.rbLowToHigh.UseVisualStyleBackColor = true;
            this.rbLowToHigh.CheckedChanged += new System.EventHandler(this.rbLowToHigh_CheckedChanged);
            // 
            // routeNumberDataGridViewTextBoxColumn
            // 
            this.routeNumberDataGridViewTextBoxColumn.DataPropertyName = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.HeaderText = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.Name = "routeNumberDataGridViewTextBoxColumn";
            // 
            // carrierCompanyDataGridViewTextBoxColumn
            // 
            this.carrierCompanyDataGridViewTextBoxColumn.DataPropertyName = "CarrierCompany";
            this.carrierCompanyDataGridViewTextBoxColumn.HeaderText = "CarrierCompany";
            this.carrierCompanyDataGridViewTextBoxColumn.Name = "carrierCompanyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // availableSeatsDataGridViewTextBoxColumn
            // 
            this.availableSeatsDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeats";
            this.availableSeatsDataGridViewTextBoxColumn.HeaderText = "AvailableSeats";
            this.availableSeatsDataGridViewTextBoxColumn.Name = "availableSeatsDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataSource = typeof(Kursova_Hushchyn.RouteList);
            // 
            // createTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 654);
            this.Controls.Add(this.gbSorts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvRoutes);
            this.Controls.Add(this.groupBox1);
            this.Name = "createTicketForm";
            this.Text = "createTicketForm";
            this.Load += new System.EventHandler(this.createTicketForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSorts.ResumeLayout(false);
            this.gbSorts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeparturePoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArrivalPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.BindingSource busRoutesBindingSource;
        private System.Windows.Forms.BindingSource routeListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCarrierCompany;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chbPowerOutlets;
        private System.Windows.Forms.CheckBox chbToilet;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.CheckBox chbConditioner;
        private System.Windows.Forms.TextBox txtPriceLow;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPriceHigh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtDepartureTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtArrivalTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbHighToLow;
        private System.Windows.Forms.GroupBox gbSorts;
        private System.Windows.Forms.RadioButton rbLowToHigh;
    }
}