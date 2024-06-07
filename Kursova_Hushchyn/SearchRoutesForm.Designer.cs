
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gbSorts = new System.Windows.Forms.GroupBox();
            this.rbLowToHigh = new System.Windows.Forms.RadioButton();
            this.rbHighToLow = new System.Windows.Forms.RadioButton();
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
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busRoutesBindingSource)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.gbSorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.AutoGenerateColumns = false;
            this.dgvRoutes.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dgvRoutes.Location = new System.Drawing.Point(18, 30);
            this.dgvRoutes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.RowHeadersWidth = 51;
            this.dgvRoutes.Size = new System.Drawing.Size(1732, 426);
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
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1159, 764);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 53);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1569, 764);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.gbOptions.Controls.Add(this.chbPowerOutlets);
            this.gbOptions.Controls.Add(this.chbToilet);
            this.gbOptions.Controls.Add(this.chbInternet);
            this.gbOptions.Controls.Add(this.chbConditioner);
            this.gbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(16, 482);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOptions.Size = new System.Drawing.Size(264, 171);
            this.gbOptions.TabIndex = 6;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chbPowerOutlets
            // 
            this.chbPowerOutlets.AutoSize = true;
            this.chbPowerOutlets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbPowerOutlets.Location = new System.Drawing.Point(8, 130);
            this.chbPowerOutlets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPowerOutlets.Name = "chbPowerOutlets";
            this.chbPowerOutlets.Size = new System.Drawing.Size(102, 19);
            this.chbPowerOutlets.TabIndex = 5;
            this.chbPowerOutlets.Text = "Power Outlets";
            this.chbPowerOutlets.UseVisualStyleBackColor = true;
            // 
            // chbToilet
            // 
            this.chbToilet.AutoSize = true;
            this.chbToilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbToilet.Location = new System.Drawing.Point(6, 62);
            this.chbToilet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbToilet.Name = "chbToilet";
            this.chbToilet.Size = new System.Drawing.Size(56, 19);
            this.chbToilet.TabIndex = 3;
            this.chbToilet.Text = "Toilet";
            this.chbToilet.UseVisualStyleBackColor = true;
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbInternet.Location = new System.Drawing.Point(8, 94);
            this.chbInternet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(67, 19);
            this.chbInternet.TabIndex = 4;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // chbConditioner
            // 
            this.chbConditioner.AutoSize = true;
            this.chbConditioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbConditioner.Location = new System.Drawing.Point(8, 29);
            this.chbConditioner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbConditioner.Name = "chbConditioner";
            this.chbConditioner.Size = new System.Drawing.Size(89, 19);
            this.chbConditioner.TabIndex = 2;
            this.chbConditioner.Text = "Conditioner";
            this.chbConditioner.UseVisualStyleBackColor = true;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(199, 191);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(151, 21);
            this.txtDeparture.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Departure Point";
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(199, 146);
            this.txtArrivalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArrivalDate.Mask = "00/00/0000";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(151, 21);
            this.txtArrivalDate.TabIndex = 39;
            this.txtArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(199, 104);
            this.txtDepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartureDate.Mask = "00/00/0000";
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(151, 21);
            this.txtDepartureDate.TabIndex = 38;
            this.txtDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Arrival Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Departure Date";
            // 
            // txtCarrierCompany
            // 
            this.txtCarrierCompany.Location = new System.Drawing.Point(199, 22);
            this.txtCarrierCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarrierCompany.Name = "txtCarrierCompany";
            this.txtCarrierCompany.Size = new System.Drawing.Size(151, 21);
            this.txtCarrierCompany.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Carrier Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Passenger capacity";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(199, 62);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(151, 21);
            this.txtCapacity.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(289, 482);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(388, 338);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // txtIntermediate
            // 
            this.txtIntermediate.Location = new System.Drawing.Point(199, 286);
            this.txtIntermediate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntermediate.Name = "txtIntermediate";
            this.txtIntermediate.Size = new System.Drawing.Size(151, 21);
            this.txtIntermediate.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "Intermediate Point";
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(199, 242);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(151, 21);
            this.txtArrival.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Arrival Point";
            // 
            // txtPriceLow
            // 
            this.txtPriceLow.Location = new System.Drawing.Point(189, 107);
            this.txtPriceLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceLow.Name = "txtPriceLow";
            this.txtPriceLow.Size = new System.Drawing.Size(151, 21);
            this.txtPriceLow.TabIndex = 35;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(189, 62);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(151, 21);
            this.txtModel.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Price Min";
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(189, 22);
            this.txtRouteNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(151, 21);
            this.txtRouteNumber.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Route Number";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(685, 482);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(457, 335);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(189, 246);
            this.txtArrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArrivalTime.Mask = "00:00";
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(151, 21);
            this.txtArrivalTime.TabIndex = 49;
            this.txtArrivalTime.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Price Max";
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Location = new System.Drawing.Point(189, 195);
            this.txtDepartureTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartureTime.Mask = "00:00";
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(151, 21);
            this.txtDepartureTime.TabIndex = 48;
            this.txtDepartureTime.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Arrival Time";
            // 
            // txtPriceHigh
            // 
            this.txtPriceHigh.Location = new System.Drawing.Point(189, 150);
            this.txtPriceHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceHigh.Name = "txtPriceHigh";
            this.txtPriceHigh.Size = new System.Drawing.Size(151, 21);
            this.txtPriceHigh.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "Departure Time";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrival,
            this.Departure,
            this.Stop,
            this.Date});
            this.dgvSchedule.Location = new System.Drawing.Point(1159, 482);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.Size = new System.Drawing.Size(591, 255);
            this.dgvSchedule.TabIndex = 47;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(1359, 764);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(181, 53);
            this.btnView.TabIndex = 48;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gbSorts
            // 
            this.gbSorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.gbSorts.Controls.Add(this.rbLowToHigh);
            this.gbSorts.Controls.Add(this.rbHighToLow);
            this.gbSorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gbSorts.ForeColor = System.Drawing.Color.White;
            this.gbSorts.Location = new System.Drawing.Point(16, 660);
            this.gbSorts.Margin = new System.Windows.Forms.Padding(4);
            this.gbSorts.Name = "gbSorts";
            this.gbSorts.Padding = new System.Windows.Forms.Padding(4);
            this.gbSorts.Size = new System.Drawing.Size(264, 157);
            this.gbSorts.TabIndex = 56;
            this.gbSorts.TabStop = false;
            this.gbSorts.Text = "Price";
            // 
            // rbLowToHigh
            // 
            this.rbLowToHigh.AutoSize = true;
            this.rbLowToHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbLowToHigh.Location = new System.Drawing.Point(8, 81);
            this.rbLowToHigh.Margin = new System.Windows.Forms.Padding(4);
            this.rbLowToHigh.Name = "rbLowToHigh";
            this.rbLowToHigh.Size = new System.Drawing.Size(94, 19);
            this.rbLowToHigh.TabIndex = 55;
            this.rbLowToHigh.TabStop = true;
            this.rbLowToHigh.Text = "Low To High";
            this.rbLowToHigh.UseVisualStyleBackColor = true;
            this.rbLowToHigh.CheckedChanged += new System.EventHandler(this.rbLowToHigh_CheckedChanged);
            // 
            // rbHighToLow
            // 
            this.rbHighToLow.AutoSize = true;
            this.rbHighToLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbHighToLow.Location = new System.Drawing.Point(8, 41);
            this.rbHighToLow.Margin = new System.Windows.Forms.Padding(4);
            this.rbHighToLow.Name = "rbHighToLow";
            this.rbHighToLow.Size = new System.Drawing.Size(94, 19);
            this.rbHighToLow.TabIndex = 54;
            this.rbHighToLow.TabStop = true;
            this.rbHighToLow.Text = "High To Low";
            this.rbHighToLow.UseVisualStyleBackColor = true;
            this.rbHighToLow.CheckedChanged += new System.EventHandler(this.rbHighToLow_CheckedChanged);
            // 
            // routeNumberDataGridViewTextBoxColumn
            // 
            this.routeNumberDataGridViewTextBoxColumn.DataPropertyName = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.HeaderText = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeNumberDataGridViewTextBoxColumn.Name = "routeNumberDataGridViewTextBoxColumn";
            this.routeNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrierCompanyDataGridViewTextBoxColumn
            // 
            this.carrierCompanyDataGridViewTextBoxColumn.DataPropertyName = "CarrierCompany";
            this.carrierCompanyDataGridViewTextBoxColumn.HeaderText = "CarrierCompany";
            this.carrierCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrierCompanyDataGridViewTextBoxColumn.Name = "carrierCompanyDataGridViewTextBoxColumn";
            this.carrierCompanyDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableSeatsDataGridViewTextBoxColumn
            // 
            this.availableSeatsDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeats";
            this.availableSeatsDataGridViewTextBoxColumn.HeaderText = "AvailableSeats";
            this.availableSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableSeatsDataGridViewTextBoxColumn.Name = "availableSeatsDataGridViewTextBoxColumn";
            this.availableSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // passengerCapacityDataGridViewTextBoxColumn
            // 
            this.passengerCapacityDataGridViewTextBoxColumn.DataPropertyName = "PassengerCapacity";
            this.passengerCapacityDataGridViewTextBoxColumn.HeaderText = "PassengerCapacity";
            this.passengerCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengerCapacityDataGridViewTextBoxColumn.Name = "passengerCapacityDataGridViewTextBoxColumn";
            this.passengerCapacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // hasAirConditionerDataGridViewCheckBoxColumn
            // 
            this.hasAirConditionerDataGridViewCheckBoxColumn.DataPropertyName = "HasAirConditioner";
            this.hasAirConditionerDataGridViewCheckBoxColumn.HeaderText = "HasAirConditioner";
            this.hasAirConditionerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.hasAirConditionerDataGridViewCheckBoxColumn.Name = "hasAirConditionerDataGridViewCheckBoxColumn";
            this.hasAirConditionerDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hasToiletDataGridViewCheckBoxColumn
            // 
            this.hasToiletDataGridViewCheckBoxColumn.DataPropertyName = "HasToilet";
            this.hasToiletDataGridViewCheckBoxColumn.HeaderText = "HasToilet";
            this.hasToiletDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.hasToiletDataGridViewCheckBoxColumn.Name = "hasToiletDataGridViewCheckBoxColumn";
            this.hasToiletDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hasPowerOutletsDataGridViewCheckBoxColumn
            // 
            this.hasPowerOutletsDataGridViewCheckBoxColumn.DataPropertyName = "HasPowerOutlets";
            this.hasPowerOutletsDataGridViewCheckBoxColumn.HeaderText = "HasPowerOutlets";
            this.hasPowerOutletsDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.hasPowerOutletsDataGridViewCheckBoxColumn.Name = "hasPowerOutletsDataGridViewCheckBoxColumn";
            this.hasPowerOutletsDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hasInternetDataGridViewCheckBoxColumn
            // 
            this.hasInternetDataGridViewCheckBoxColumn.DataPropertyName = "HasInternet";
            this.hasInternetDataGridViewCheckBoxColumn.HeaderText = "HasInternet";
            this.hasInternetDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.hasInternetDataGridViewCheckBoxColumn.Name = "hasInternetDataGridViewCheckBoxColumn";
            this.hasInternetDataGridViewCheckBoxColumn.Width = 125;
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataSource = typeof(Kursova_Hushchyn.RouteList);
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 125;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 6;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 125;
            // 
            // Stop
            // 
            this.Stop.HeaderText = "Stop";
            this.Stop.MinimumWidth = 6;
            this.Stop.Name = "Stop";
            this.Stop.ReadOnly = true;
            this.Stop.Width = 165;
            // 
            // Date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date";
            this.Date.MaxInputLength = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SearchRoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1897, 868);
            this.Controls.Add(this.gbSorts);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvRoutes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchRoutesForm";
            this.ShowIcon = false;
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
            this.gbSorts.ResumeLayout(false);
            this.gbSorts.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbSorts;
        private System.Windows.Forms.RadioButton rbLowToHigh;
        private System.Windows.Forms.RadioButton rbHighToLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}