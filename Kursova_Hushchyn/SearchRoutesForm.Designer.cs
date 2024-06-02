
namespace Kursova_Hushchyn
{
    partial class SearchRoutesForm
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
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.busRoutesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chbPowerOutlets = new System.Windows.Forms.CheckBox();
            this.chbToilet = new System.Windows.Forms.CheckBox();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.chbConditioner = new System.Windows.Forms.CheckBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArrivalDate = new System.Windows.Forms.MaskedTextBox();
            this.txtDepartureDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarrierCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIntermediate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceLow = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArrivalTime = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDepartureTime = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPriceHigh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.routeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAirConditionerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasToiletDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasPowerOutletsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasInternetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.modelDataGridViewTextBoxColumn,
            this.passengerCapacityDataGridViewTextBoxColumn,
            this.hasAirConditionerDataGridViewCheckBoxColumn,
            this.hasToiletDataGridViewCheckBoxColumn,
            this.hasPowerOutletsDataGridViewCheckBoxColumn,
            this.hasInternetDataGridViewCheckBoxColumn});
            this.dgvRoutes.DataSource = this.busRoutesBindingSource;
            this.dgvRoutes.Location = new System.Drawing.Point(12, 22);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.Size = new System.Drawing.Size(1257, 308);
            this.dgvRoutes.TabIndex = 0;
            this.dgvRoutes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoutes_CellClick);
            // 
            // busRoutesBindingSource
            // 
            this.busRoutesBindingSource.DataMember = "BusRoutes";
            this.busRoutesBindingSource.DataSource = this.routeListBindingSource;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1148, 611);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(783, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chbPowerOutlets);
            this.gbOptions.Controls.Add(this.chbToilet);
            this.gbOptions.Controls.Add(this.chbInternet);
            this.gbOptions.Controls.Add(this.chbConditioner);
            this.gbOptions.Location = new System.Drawing.Point(12, 399);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbOptions.Size = new System.Drawing.Size(176, 152);
            this.gbOptions.TabIndex = 6;
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
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(133, 182);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(102, 20);
            this.txtDeparture.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Departure Point";
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(133, 150);
            this.txtArrivalDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtArrivalDate.Mask = "00/00/0000";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(102, 20);
            this.txtArrivalDate.TabIndex = 39;
            this.txtArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(133, 117);
            this.txtDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartureDate.Mask = "00/00/0000";
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(102, 20);
            this.txtDepartureDate.TabIndex = 38;
            this.txtDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Arrival Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Departure Date";
            // 
            // txtCarrierCompany
            // 
            this.txtCarrierCompany.Location = new System.Drawing.Point(133, 44);
            this.txtCarrierCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarrierCompany.Name = "txtCarrierCompany";
            this.txtCarrierCompany.Size = new System.Drawing.Size(102, 20);
            this.txtCarrierCompany.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Carrier Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Passenger capacity";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(133, 80);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(102, 20);
            this.txtCapacity.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIntermediate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtArrival);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArrivalDate);
            this.groupBox1.Controls.Add(this.txtCapacity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDeparture);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDepartureDate);
            this.groupBox1.Controls.Add(this.txtCarrierCompany);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(193, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 284);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // txtIntermediate
            // 
            this.txtIntermediate.Location = new System.Drawing.Point(133, 251);
            this.txtIntermediate.Margin = new System.Windows.Forms.Padding(2);
            this.txtIntermediate.Name = "txtIntermediate";
            this.txtIntermediate.Size = new System.Drawing.Size(102, 20);
            this.txtIntermediate.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Intermediate Point";
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(133, 212);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(2);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(102, 20);
            this.txtArrival.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Arrival Point";
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
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(142, 43);
            this.txtRouteNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(102, 20);
            this.txtRouteNumber.TabIndex = 43;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Route Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArrivalTime);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDepartureTime);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPriceHigh);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRouteNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtPriceLow);
            this.groupBox2.Location = new System.Drawing.Point(463, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 284);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
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
            // txtPriceHigh
            // 
            this.txtPriceHigh.Location = new System.Drawing.Point(142, 138);
            this.txtPriceHigh.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceHigh.Name = "txtPriceHigh";
            this.txtPriceHigh.Size = new System.Drawing.Size(102, 20);
            this.txtPriceHigh.TabIndex = 44;
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
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrival,
            this.Departure,
            this.Stop});
            this.dgvSchedule.Location = new System.Drawing.Point(783, 355);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(410, 230);
            this.dgvSchedule.TabIndex = 47;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(969, 611);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 38);
            this.btnView.TabIndex = 48;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            // passengerCapacityDataGridViewTextBoxColumn
            // 
            this.passengerCapacityDataGridViewTextBoxColumn.DataPropertyName = "PassengerCapacity";
            this.passengerCapacityDataGridViewTextBoxColumn.HeaderText = "PassengerCapacity";
            this.passengerCapacityDataGridViewTextBoxColumn.Name = "passengerCapacityDataGridViewTextBoxColumn";
            // 
            // hasAirConditionerDataGridViewCheckBoxColumn
            // 
            this.hasAirConditionerDataGridViewCheckBoxColumn.DataPropertyName = "HasAirConditioner";
            this.hasAirConditionerDataGridViewCheckBoxColumn.HeaderText = "HasAirConditioner";
            this.hasAirConditionerDataGridViewCheckBoxColumn.Name = "hasAirConditionerDataGridViewCheckBoxColumn";
            // 
            // hasToiletDataGridViewCheckBoxColumn
            // 
            this.hasToiletDataGridViewCheckBoxColumn.DataPropertyName = "HasToilet";
            this.hasToiletDataGridViewCheckBoxColumn.HeaderText = "HasToilet";
            this.hasToiletDataGridViewCheckBoxColumn.Name = "hasToiletDataGridViewCheckBoxColumn";
            // 
            // hasPowerOutletsDataGridViewCheckBoxColumn
            // 
            this.hasPowerOutletsDataGridViewCheckBoxColumn.DataPropertyName = "HasPowerOutlets";
            this.hasPowerOutletsDataGridViewCheckBoxColumn.HeaderText = "HasPowerOutlets";
            this.hasPowerOutletsDataGridViewCheckBoxColumn.Name = "hasPowerOutletsDataGridViewCheckBoxColumn";
            // 
            // hasInternetDataGridViewCheckBoxColumn
            // 
            this.hasInternetDataGridViewCheckBoxColumn.DataPropertyName = "HasInternet";
            this.hasInternetDataGridViewCheckBoxColumn.HeaderText = "HasInternet";
            this.hasInternetDataGridViewCheckBoxColumn.Name = "hasInternetDataGridViewCheckBoxColumn";
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataSource = typeof(Kursova_Hushchyn.RouteList);
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
            // SearchRoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 661);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvRoutes);
            this.Name = "SearchRoutesForm";
            this.Text = "UKR BUS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasAirConditionerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasToiletDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasPowerOutletsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasInternetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource busRoutesBindingSource;
        private System.Windows.Forms.BindingSource routeListBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chbPowerOutlets;
        private System.Windows.Forms.CheckBox chbToilet;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.CheckBox chbConditioner;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtArrivalDate;
        private System.Windows.Forms.MaskedTextBox txtDepartureDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarrierCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPriceLow;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntermediate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPriceHigh;
        private System.Windows.Forms.MaskedTextBox txtArrivalTime;
        private System.Windows.Forms.MaskedTextBox txtDepartureTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
    }
}