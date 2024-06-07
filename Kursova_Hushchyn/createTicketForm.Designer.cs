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
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
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
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(276, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Route Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arrival Point";
            // 
            // txtDeparturePoint
            // 
            this.txtDeparturePoint.Location = new System.Drawing.Point(137, 118);
            this.txtDeparturePoint.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeparturePoint.Name = "txtDeparturePoint";
            this.txtDeparturePoint.ReadOnly = true;
            this.txtDeparturePoint.Size = new System.Drawing.Size(132, 19);
            this.txtDeparturePoint.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Departure Point";
            // 
            // txtArrivalPoint
            // 
            this.txtArrivalPoint.Location = new System.Drawing.Point(137, 150);
            this.txtArrivalPoint.Margin = new System.Windows.Forms.Padding(4);
            this.txtArrivalPoint.Name = "txtArrivalPoint";
            this.txtArrivalPoint.ReadOnly = true;
            this.txtArrivalPoint.Size = new System.Drawing.Size(132, 19);
            this.txtArrivalPoint.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(137, 87);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(132, 19);
            this.txtDOB.TabIndex = 3;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 19);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(137, 54);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 19);
            this.txtSurname.TabIndex = 2;
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
            this.modelDataGridViewTextBoxColumn});
            this.dgvRoutes.DataSource = this.busRoutesBindingSource;
            this.dgvRoutes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRoutes.Location = new System.Drawing.Point(309, 23);
            this.dgvRoutes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.RowHeadersWidth = 51;
            this.dgvRoutes.Size = new System.Drawing.Size(830, 236);
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
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1009, 363);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 44);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrival,
            this.Departure,
            this.Stop});
            this.dgvSchedule.Location = new System.Drawing.Point(514, 306);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.Size = new System.Drawing.Size(465, 149);
            this.dgvSchedule.TabIndex = 51;
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label16.Location = new System.Drawing.Point(13, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Carrier Company";
            // 
            // txtCarrierCompany
            // 
            this.txtCarrierCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.txtCarrierCompany.Location = new System.Drawing.Point(137, 27);
            this.txtCarrierCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarrierCompany.Name = "txtCarrierCompany";
            this.txtCarrierCompany.Size = new System.Drawing.Size(132, 18);
            this.txtCarrierCompany.TabIndex = 4;
            // 
            // gbOptions
            // 
            this.gbOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.gbOptions.Controls.Add(this.chbPowerOutlets);
            this.gbOptions.Controls.Add(this.chbToilet);
            this.gbOptions.Controls.Add(this.chbInternet);
            this.gbOptions.Controls.Add(this.chbConditioner);
            this.gbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(309, 270);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOptions.Size = new System.Drawing.Size(176, 118);
            this.gbOptions.TabIndex = 48;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chbPowerOutlets
            // 
            this.chbPowerOutlets.AutoSize = true;
            this.chbPowerOutlets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chbPowerOutlets.Location = new System.Drawing.Point(5, 92);
            this.chbPowerOutlets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPowerOutlets.Name = "chbPowerOutlets";
            this.chbPowerOutlets.Size = new System.Drawing.Size(92, 16);
            this.chbPowerOutlets.TabIndex = 5;
            this.chbPowerOutlets.Text = "Power Outlets";
            this.chbPowerOutlets.UseVisualStyleBackColor = true;
            // 
            // chbToilet
            // 
            this.chbToilet.AutoSize = true;
            this.chbToilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chbToilet.Location = new System.Drawing.Point(5, 44);
            this.chbToilet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbToilet.Name = "chbToilet";
            this.chbToilet.Size = new System.Drawing.Size(52, 16);
            this.chbToilet.TabIndex = 3;
            this.chbToilet.Text = "Toilet";
            this.chbToilet.UseVisualStyleBackColor = true;
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chbInternet.Location = new System.Drawing.Point(5, 67);
            this.chbInternet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(62, 16);
            this.chbInternet.TabIndex = 4;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // chbConditioner
            // 
            this.chbConditioner.AutoSize = true;
            this.chbConditioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chbConditioner.Location = new System.Drawing.Point(5, 21);
            this.chbConditioner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbConditioner.Name = "chbConditioner";
            this.chbConditioner.Size = new System.Drawing.Size(79, 16);
            this.chbConditioner.TabIndex = 2;
            this.chbConditioner.Text = "Conditioner";
            this.chbConditioner.UseVisualStyleBackColor = true;
            // 
            // txtPriceLow
            // 
            this.txtPriceLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtPriceLow.Location = new System.Drawing.Point(137, 94);
            this.txtPriceLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceLow.Name = "txtPriceLow";
            this.txtPriceLow.Size = new System.Drawing.Size(132, 19);
            this.txtPriceLow.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtModel.Location = new System.Drawing.Point(137, 57);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 19);
            this.txtModel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Price Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label9.Location = new System.Drawing.Point(13, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Model";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label13.Location = new System.Drawing.Point(13, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Departure Time";
            // 
            // txtPriceHigh
            // 
            this.txtPriceHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtPriceHigh.Location = new System.Drawing.Point(137, 128);
            this.txtPriceHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceHigh.Name = "txtPriceHigh";
            this.txtPriceHigh.Size = new System.Drawing.Size(132, 19);
            this.txtPriceHigh.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label12.Location = new System.Drawing.Point(15, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Arrival Time";
            // 
            // txtDepartureTime
            // 
            this.txtDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtDepartureTime.Location = new System.Drawing.Point(137, 166);
            this.txtDepartureTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartureTime.Mask = "00:00";
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(132, 19);
            this.txtDepartureTime.TabIndex = 8;
            this.txtDepartureTime.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label11.Location = new System.Drawing.Point(15, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Price Max";
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtArrivalTime.Location = new System.Drawing.Point(137, 199);
            this.txtArrivalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArrivalTime.Mask = "00:00";
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(132, 19);
            this.txtArrivalTime.TabIndex = 9;
            this.txtArrivalTime.ValidatingType = typeof(System.DateTime);
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
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtCarrierCompany);
            this.groupBox2.Controls.Add(this.txtPriceLow);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(276, 234);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1009, 303);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 39);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbHighToLow
            // 
            this.rbHighToLow.AutoSize = true;
            this.rbHighToLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rbHighToLow.Location = new System.Drawing.Point(7, 34);
            this.rbHighToLow.Margin = new System.Windows.Forms.Padding(4);
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
            this.gbSorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(133)))));
            this.gbSorts.Controls.Add(this.rbLowToHigh);
            this.gbSorts.Controls.Add(this.rbHighToLow);
            this.gbSorts.ForeColor = System.Drawing.Color.White;
            this.gbSorts.Location = new System.Drawing.Point(309, 402);
            this.gbSorts.Margin = new System.Windows.Forms.Padding(4);
            this.gbSorts.Name = "gbSorts";
            this.gbSorts.Padding = new System.Windows.Forms.Padding(4);
            this.gbSorts.Size = new System.Drawing.Size(176, 99);
            this.gbSorts.TabIndex = 55;
            this.gbSorts.TabStop = false;
            this.gbSorts.Text = "Price";
            // 
            // rbLowToHigh
            // 
            this.rbLowToHigh.AutoSize = true;
            this.rbLowToHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rbLowToHigh.Location = new System.Drawing.Point(7, 62);
            this.rbLowToHigh.Margin = new System.Windows.Forms.Padding(4);
            this.rbLowToHigh.Name = "rbLowToHigh";
            this.rbLowToHigh.Size = new System.Drawing.Size(86, 17);
            this.rbLowToHigh.TabIndex = 55;
            this.rbLowToHigh.TabStop = true;
            this.rbLowToHigh.Text = "Low To High";
            this.rbLowToHigh.UseVisualStyleBackColor = true;
            this.rbLowToHigh.CheckedChanged += new System.EventHandler(this.rbLowToHigh_CheckedChanged);
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(137, 184);
            this.txtRouteNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.ReadOnly = true;
            this.txtRouteNumber.Size = new System.Drawing.Size(132, 19);
            this.txtRouteNumber.TabIndex = 12;
            // 
            // routeNumberDataGridViewTextBoxColumn
            // 
            this.routeNumberDataGridViewTextBoxColumn.DataPropertyName = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.HeaderText = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeNumberDataGridViewTextBoxColumn.Name = "routeNumberDataGridViewTextBoxColumn";
            this.routeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrierCompanyDataGridViewTextBoxColumn
            // 
            this.carrierCompanyDataGridViewTextBoxColumn.DataPropertyName = "CarrierCompany";
            this.carrierCompanyDataGridViewTextBoxColumn.HeaderText = "CarrierCompany";
            this.carrierCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrierCompanyDataGridViewTextBoxColumn.Name = "carrierCompanyDataGridViewTextBoxColumn";
            this.carrierCompanyDataGridViewTextBoxColumn.ReadOnly = true;
            this.carrierCompanyDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataSource = typeof(Kursova_Hushchyn.RouteList);
            // 
            // createTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1174, 523);
            this.Controls.Add(this.gbSorts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvRoutes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "createTicketForm";
            this.Text = "Create ticket";
            this.Load += new System.EventHandler(this.createTicketForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.createTicketForm_KeyDown);
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCarrierCompany;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbHighToLow;
        private System.Windows.Forms.GroupBox gbSorts;
        private System.Windows.Forms.RadioButton rbLowToHigh;
        protected System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtRouteNumber;
    }
}