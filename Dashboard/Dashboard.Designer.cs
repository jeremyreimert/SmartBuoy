/**************************************************************************************
 * NAME:        Jeremy Reimert
 * DATE:        April 25, 2020
 * PROJECT:     SmartBuoy Dashboard
 * DESCRIPTION: This program creates a user interface for viewing data from SmartBuoy.
 *              SmartBuoy was built to measure and transmit water quaity data.
 *              Data is live streamed and stored in a database.
 * 
 *              The application has two main functions:
 *              1. To retrieve historic data from a database. 
 *              2. To retrieve live streaming data using the Dweet.io service. 
 * 
 *              In both cases, data is presented within a dataGridView, a line chart, 
 *              and customized gauges. Location data is used to plot points on a map.  
 **************************************************************************************/

namespace SmartBuoyDashboard
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gaugeBatt = new CircularProgressBar.CircularProgressBar();
            this.rangeSlider = new System.Windows.Forms.TrackBar();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.btnHistoric = new System.Windows.Forms.Button();
            this.lblSlider = new System.Windows.Forms.Label();
            this.lblEndSlide = new System.Windows.Forms.Label();
            this.lblStartSlide = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnLive = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.lblGet = new System.Windows.Forms.Label();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.MapHost = new System.Windows.Forms.Integration.ElementHost();
            this.BuoyMap = new SmartBuoyDashboard.MapUserControl();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.groupBoxBattery = new System.Windows.Forms.GroupBox();
            this.groupBoxTemp = new System.Windows.Forms.GroupBox();
            this.gaugeTemp = new CircularProgressBar.CircularProgressBar();
            this.groupBoxEC = new System.Windows.Forms.GroupBox();
            this.gaugeEC = new CircularProgressBar.CircularProgressBar();
            this.groupBoxpH = new System.Windows.Forms.GroupBox();
            this.gaugePH = new CircularProgressBar.CircularProgressBar();
            this.groupBoxTDS = new System.Windows.Forms.GroupBox();
            this.gaugeTDS = new CircularProgressBar.CircularProgressBar();
            this.groupBoxTurb = new System.Windows.Forms.GroupBox();
            this.gaugeTurb = new CircularProgressBar.CircularProgressBar();
            this.LiveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rangeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.groupBoxRange.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.groupBoxChart.SuspendLayout();
            this.groupBoxBattery.SuspendLayout();
            this.groupBoxTemp.SuspendLayout();
            this.groupBoxEC.SuspendLayout();
            this.groupBoxpH.SuspendLayout();
            this.groupBoxTDS.SuspendLayout();
            this.groupBoxTurb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gaugeBatt
            // 
            this.gaugeBatt.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gaugeBatt.AnimationSpeed = 500;
            this.gaugeBatt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeBatt.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeBatt.ForeColor = System.Drawing.Color.Lime;
            this.gaugeBatt.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeBatt.InnerMargin = 2;
            this.gaugeBatt.InnerWidth = -1;
            this.gaugeBatt.Location = new System.Drawing.Point(11, 16);
            this.gaugeBatt.Margin = new System.Windows.Forms.Padding(2);
            this.gaugeBatt.MarqueeAnimationSpeed = 2000;
            this.gaugeBatt.Maximum = 50;
            this.gaugeBatt.Name = "gaugeBatt";
            this.gaugeBatt.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gaugeBatt.OuterMargin = -25;
            this.gaugeBatt.OuterWidth = 26;
            this.gaugeBatt.ProgressColor = System.Drawing.Color.Lime;
            this.gaugeBatt.ProgressWidth = 15;
            this.gaugeBatt.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeBatt.Size = new System.Drawing.Size(176, 170);
            this.gaugeBatt.StartAngle = 90;
            this.gaugeBatt.SubscriptColor = System.Drawing.Color.Black;
            this.gaugeBatt.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.gaugeBatt.SubscriptText = "Volts";
            this.gaugeBatt.SuperscriptColor = System.Drawing.Color.Black;
            this.gaugeBatt.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.gaugeBatt.SuperscriptText = "";
            this.gaugeBatt.TabIndex = 0;
            this.gaugeBatt.Text = "0.0";
            this.gaugeBatt.TextMargin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            // 
            // rangeSlider
            // 
            this.rangeSlider.Enabled = false;
            this.rangeSlider.Location = new System.Drawing.Point(27, 54);
            this.rangeSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rangeSlider.Maximum = 24;
            this.rangeSlider.Name = "rangeSlider";
            this.rangeSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rangeSlider.Size = new System.Drawing.Size(1032, 56);
            this.rangeSlider.TabIndex = 5;
            this.rangeSlider.Scroll += new System.EventHandler(this.rangeSlider_Scroll);
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "M\'/\'dd\'/\'yyyy h\':\'mm tt";
            this.dtStart.Location = new System.Drawing.Point(1271, 36);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtStart.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(304, 23);
            this.dtStart.TabIndex = 1;
            this.dtStart.Value = new System.DateTime(2020, 2, 23, 0, 0, 0, 0);
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.AllowUserToResizeColumns = false;
            this.dataHistory.AllowUserToResizeRows = false;
            this.dataHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Timestamp,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHistory.Location = new System.Drawing.Point(4, 20);
            this.dataHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.RowHeadersVisible = false;
            this.dataHistory.RowHeadersWidth = 51;
            this.dataHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataHistory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHistory.Size = new System.Drawing.Size(924, 568);
            this.dataHistory.TabIndex = 6;
            // 
            // Timestamp
            // 
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.MinimumWidth = 6;
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.Width = 115;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Battery";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 89;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Temperature";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "pH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 57;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Conductivity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TDS";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 68;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Turbidity";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 101;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Latitude";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 96;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Longitude";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 109;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "M\'/\'dd\'/\'yyyy h\':\'mm tt";
            this.dtEnd.Location = new System.Drawing.Point(1271, 78);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(304, 23);
            this.dtEnd.TabIndex = 2;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.btnHistoric);
            this.groupBoxRange.Controls.Add(this.lblSlider);
            this.groupBoxRange.Controls.Add(this.lblEndSlide);
            this.groupBoxRange.Controls.Add(this.lblStartSlide);
            this.groupBoxRange.Controls.Add(this.lblEndDate);
            this.groupBoxRange.Controls.Add(this.lblStartDate);
            this.groupBoxRange.Controls.Add(this.rangeSlider);
            this.groupBoxRange.Controls.Add(this.dtEnd);
            this.groupBoxRange.Controls.Add(this.btnLive);
            this.groupBoxRange.Controls.Add(this.dtStart);
            this.groupBoxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRange.ForeColor = System.Drawing.Color.White;
            this.groupBoxRange.Location = new System.Drawing.Point(16, 838);
            this.groupBoxRange.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRange.Size = new System.Drawing.Size(1888, 140);
            this.groupBoxRange.TabIndex = 0;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Range Selection";
            // 
            // btnHistoric
            // 
            this.btnHistoric.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoric.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistoric.BackgroundImage")));
            this.btnHistoric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistoric.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistoric.FlatAppearance.BorderSize = 0;
            this.btnHistoric.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistoric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoric.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoric.ForeColor = System.Drawing.Color.White;
            this.btnHistoric.Location = new System.Drawing.Point(1693, 85);
            this.btnHistoric.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistoric.Name = "btnHistoric";
            this.btnHistoric.Size = new System.Drawing.Size(152, 41);
            this.btnHistoric.TabIndex = 3;
            this.btnHistoric.Text = "GET DATA";
            this.btnHistoric.UseVisualStyleBackColor = false;
            this.btnHistoric.Click += new System.EventHandler(this.btnHistoric_Click);
            // 
            // lblSlider
            // 
            this.lblSlider.AutoSize = true;
            this.lblSlider.Location = new System.Drawing.Point(23, 36);
            this.lblSlider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlider.Name = "lblSlider";
            this.lblSlider.Size = new System.Drawing.Size(102, 17);
            this.lblSlider.TabIndex = 0;
            this.lblSlider.Text = "Range Slider";
            // 
            // lblEndSlide
            // 
            this.lblEndSlide.AutoSize = true;
            this.lblEndSlide.Location = new System.Drawing.Point(1020, 94);
            this.lblEndSlide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndSlide.Name = "lblEndSlide";
            this.lblEndSlide.Size = new System.Drawing.Size(36, 17);
            this.lblEndSlide.TabIndex = 0;
            this.lblEndSlide.Text = "End";
            // 
            // lblStartSlide
            // 
            this.lblStartSlide.AutoSize = true;
            this.lblStartSlide.Location = new System.Drawing.Point(20, 94);
            this.lblStartSlide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartSlide.Name = "lblStartSlide";
            this.lblStartSlide.Size = new System.Drawing.Size(43, 17);
            this.lblStartSlide.TabIndex = 0;
            this.lblStartSlide.Text = "Start";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(1168, 82);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 17);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(1168, 41);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 17);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnLive
            // 
            this.btnLive.BackColor = System.Drawing.Color.Transparent;
            this.btnLive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLive.BackgroundImage")));
            this.btnLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLive.FlatAppearance.BorderSize = 0;
            this.btnLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLive.ForeColor = System.Drawing.Color.White;
            this.btnLive.Location = new System.Drawing.Point(1693, 24);
            this.btnLive.Margin = new System.Windows.Forms.Padding(0);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(152, 41);
            this.btnLive.TabIndex = 4;
            this.btnLive.Text = "GO LIVE";
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_ClickAsync);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.dataHistory);
            this.groupBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.ForeColor = System.Drawing.Color.White;
            this.groupBoxData.Location = new System.Drawing.Point(972, 15);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxData.Size = new System.Drawing.Size(932, 592);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGet.Location = new System.Drawing.Point(450, 53);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(1021, 95);
            this.lblGet.TabIndex = 8;
            this.lblGet.Text = "Connecting to SmartBuoy";
            this.lblGet.Visible = false;
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.btnZoomOut);
            this.groupBoxMap.Controls.Add(this.btnZoomIn);
            this.groupBoxMap.Controls.Add(this.MapHost);
            this.groupBoxMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMap.ForeColor = System.Drawing.Color.White;
            this.groupBoxMap.Location = new System.Drawing.Point(440, 15);
            this.groupBoxMap.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMap.Size = new System.Drawing.Size(520, 592);
            this.groupBoxMap.TabIndex = 0;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.BackgroundImage")));
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.White;
            this.btnZoomOut.Location = new System.Drawing.Point(4, 538);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(50, 50);
            this.btnZoomOut.TabIndex = 6;
            this.btnZoomOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.BackgroundImage")));
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.ForeColor = System.Drawing.Color.White;
            this.btnZoomIn.Location = new System.Drawing.Point(54, 538);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnZoomIn.Size = new System.Drawing.Size(50, 50);
            this.btnZoomIn.TabIndex = 5;
            this.btnZoomIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // MapHost
            // 
            this.MapHost.AutoSize = true;
            this.MapHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapHost.Location = new System.Drawing.Point(4, 20);
            this.MapHost.Name = "MapHost";
            this.MapHost.Size = new System.Drawing.Size(512, 568);
            this.MapHost.TabIndex = 0;
            this.MapHost.TabStop = false;
            this.MapHost.Text = "elementHost1";
            this.MapHost.Child = this.BuoyMap;
            // 
            // lineChart
            // 
            this.lineChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLogarithmic = true;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.lineChart.ChartAreas.Add(chartArea1);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(4, 19);
            this.lineChart.Margin = new System.Windows.Forms.Padding(4);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Batt";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Temp";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Aqua;
            series3.Legend = "Legend1";
            series3.Name = "pH";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "EC";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Yellow;
            series5.Legend = "Legend1";
            series5.Name = "TDS";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Fuchsia;
            series6.Legend = "Legend1";
            series6.Name = "Turb";
            this.lineChart.Series.Add(series1);
            this.lineChart.Series.Add(series2);
            this.lineChart.Series.Add(series3);
            this.lineChart.Series.Add(series4);
            this.lineChart.Series.Add(series5);
            this.lineChart.Series.Add(series6);
            this.lineChart.Size = new System.Drawing.Size(1880, 202);
            this.lineChart.TabIndex = 0;
            this.lineChart.TabStop = false;
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.lblGet);
            this.groupBoxChart.Controls.Add(this.lineChart);
            this.groupBoxChart.ForeColor = System.Drawing.Color.White;
            this.groupBoxChart.Location = new System.Drawing.Point(16, 610);
            this.groupBoxChart.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxChart.Size = new System.Drawing.Size(1888, 225);
            this.groupBoxChart.TabIndex = 0;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "Charted Data";
            // 
            // groupBoxBattery
            // 
            this.groupBoxBattery.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBattery.Controls.Add(this.gaugeBatt);
            this.groupBoxBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBattery.ForeColor = System.Drawing.Color.White;
            this.groupBoxBattery.Location = new System.Drawing.Point(15, 15);
            this.groupBoxBattery.Name = "groupBoxBattery";
            this.groupBoxBattery.Size = new System.Drawing.Size(198, 195);
            this.groupBoxBattery.TabIndex = 0;
            this.groupBoxBattery.TabStop = false;
            this.groupBoxBattery.Text = "Battery";
            // 
            // groupBoxTemp
            // 
            this.groupBoxTemp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTemp.Controls.Add(this.gaugeTemp);
            this.groupBoxTemp.ForeColor = System.Drawing.Color.White;
            this.groupBoxTemp.Location = new System.Drawing.Point(227, 15);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.Size = new System.Drawing.Size(198, 195);
            this.groupBoxTemp.TabIndex = 0;
            this.groupBoxTemp.TabStop = false;
            this.groupBoxTemp.Text = "Temperature";
            // 
            // gaugeTemp
            // 
            this.gaugeTemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gaugeTemp.AnimationSpeed = 500;
            this.gaugeTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeTemp.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeTemp.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeTemp.InnerMargin = 2;
            this.gaugeTemp.InnerWidth = -1;
            this.gaugeTemp.Location = new System.Drawing.Point(11, 16);
            this.gaugeTemp.Margin = new System.Windows.Forms.Padding(2);
            this.gaugeTemp.MarqueeAnimationSpeed = 2000;
            this.gaugeTemp.Maximum = 1000;
            this.gaugeTemp.Name = "gaugeTemp";
            this.gaugeTemp.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gaugeTemp.OuterMargin = -25;
            this.gaugeTemp.OuterWidth = 26;
            this.gaugeTemp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeTemp.ProgressWidth = 15;
            this.gaugeTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeTemp.Size = new System.Drawing.Size(176, 170);
            this.gaugeTemp.StartAngle = 90;
            this.gaugeTemp.SubscriptColor = System.Drawing.Color.Black;
            this.gaugeTemp.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.gaugeTemp.SubscriptText = "°F";
            this.gaugeTemp.SuperscriptColor = System.Drawing.Color.Black;
            this.gaugeTemp.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.gaugeTemp.SuperscriptText = "";
            this.gaugeTemp.TabIndex = 0;
            this.gaugeTemp.Text = "0.0";
            this.gaugeTemp.TextMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // groupBoxEC
            // 
            this.groupBoxEC.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEC.Controls.Add(this.gaugeEC);
            this.groupBoxEC.ForeColor = System.Drawing.Color.White;
            this.groupBoxEC.Location = new System.Drawing.Point(227, 211);
            this.groupBoxEC.Name = "groupBoxEC";
            this.groupBoxEC.Size = new System.Drawing.Size(198, 195);
            this.groupBoxEC.TabIndex = 0;
            this.groupBoxEC.TabStop = false;
            this.groupBoxEC.Text = "Electrical Conductivity";
            // 
            // gaugeEC
            // 
            this.gaugeEC.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gaugeEC.AnimationSpeed = 500;
            this.gaugeEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeEC.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeEC.ForeColor = System.Drawing.Color.Red;
            this.gaugeEC.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeEC.InnerMargin = 2;
            this.gaugeEC.InnerWidth = -1;
            this.gaugeEC.Location = new System.Drawing.Point(11, 16);
            this.gaugeEC.Margin = new System.Windows.Forms.Padding(2);
            this.gaugeEC.MarqueeAnimationSpeed = 2000;
            this.gaugeEC.Maximum = 2000;
            this.gaugeEC.Name = "gaugeEC";
            this.gaugeEC.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gaugeEC.OuterMargin = -25;
            this.gaugeEC.OuterWidth = 26;
            this.gaugeEC.ProgressColor = System.Drawing.Color.Red;
            this.gaugeEC.ProgressWidth = 15;
            this.gaugeEC.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeEC.Size = new System.Drawing.Size(176, 170);
            this.gaugeEC.StartAngle = 90;
            this.gaugeEC.SubscriptColor = System.Drawing.Color.Black;
            this.gaugeEC.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.gaugeEC.SubscriptText = "uS";
            this.gaugeEC.SuperscriptColor = System.Drawing.Color.Black;
            this.gaugeEC.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.gaugeEC.SuperscriptText = "";
            this.gaugeEC.TabIndex = 0;
            this.gaugeEC.Text = "0.0";
            this.gaugeEC.TextMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // groupBoxpH
            // 
            this.groupBoxpH.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxpH.Controls.Add(this.gaugePH);
            this.groupBoxpH.ForeColor = System.Drawing.Color.White;
            this.groupBoxpH.Location = new System.Drawing.Point(15, 211);
            this.groupBoxpH.Name = "groupBoxpH";
            this.groupBoxpH.Size = new System.Drawing.Size(198, 195);
            this.groupBoxpH.TabIndex = 0;
            this.groupBoxpH.TabStop = false;
            this.groupBoxpH.Text = "pH";
            // 
            // gaugePH
            // 
            this.gaugePH.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gaugePH.AnimationSpeed = 500;
            this.gaugePH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugePH.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugePH.ForeColor = System.Drawing.Color.Aqua;
            this.gaugePH.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugePH.InnerMargin = 2;
            this.gaugePH.InnerWidth = -1;
            this.gaugePH.Location = new System.Drawing.Point(11, 16);
            this.gaugePH.Margin = new System.Windows.Forms.Padding(2);
            this.gaugePH.MarqueeAnimationSpeed = 2000;
            this.gaugePH.Maximum = 140;
            this.gaugePH.Name = "gaugePH";
            this.gaugePH.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gaugePH.OuterMargin = -25;
            this.gaugePH.OuterWidth = 26;
            this.gaugePH.ProgressColor = System.Drawing.Color.Aqua;
            this.gaugePH.ProgressWidth = 15;
            this.gaugePH.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugePH.Size = new System.Drawing.Size(176, 170);
            this.gaugePH.StartAngle = 90;
            this.gaugePH.SubscriptColor = System.Drawing.Color.Black;
            this.gaugePH.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.gaugePH.SubscriptText = "pH";
            this.gaugePH.SuperscriptColor = System.Drawing.Color.Black;
            this.gaugePH.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.gaugePH.SuperscriptText = "";
            this.gaugePH.TabIndex = 0;
            this.gaugePH.Text = "0.0";
            this.gaugePH.TextMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // groupBoxTDS
            // 
            this.groupBoxTDS.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTDS.Controls.Add(this.gaugeTDS);
            this.groupBoxTDS.ForeColor = System.Drawing.Color.White;
            this.groupBoxTDS.Location = new System.Drawing.Point(227, 408);
            this.groupBoxTDS.Name = "groupBoxTDS";
            this.groupBoxTDS.Size = new System.Drawing.Size(198, 195);
            this.groupBoxTDS.TabIndex = 0;
            this.groupBoxTDS.TabStop = false;
            this.groupBoxTDS.Text = "Total Dissolved Solids";
            // 
            // gaugeTDS
            // 
            this.gaugeTDS.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gaugeTDS.AnimationSpeed = 500;
            this.gaugeTDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeTDS.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeTDS.ForeColor = System.Drawing.Color.Yellow;
            this.gaugeTDS.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeTDS.InnerMargin = 2;
            this.gaugeTDS.InnerWidth = -1;
            this.gaugeTDS.Location = new System.Drawing.Point(11, 16);
            this.gaugeTDS.Margin = new System.Windows.Forms.Padding(2);
            this.gaugeTDS.MarqueeAnimationSpeed = 2000;
            this.gaugeTDS.Maximum = 500;
            this.gaugeTDS.Name = "gaugeTDS";
            this.gaugeTDS.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gaugeTDS.OuterMargin = -25;
            this.gaugeTDS.OuterWidth = 26;
            this.gaugeTDS.ProgressColor = System.Drawing.Color.Yellow;
            this.gaugeTDS.ProgressWidth = 15;
            this.gaugeTDS.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeTDS.Size = new System.Drawing.Size(176, 170);
            this.gaugeTDS.StartAngle = 90;
            this.gaugeTDS.SubscriptColor = System.Drawing.Color.Black;
            this.gaugeTDS.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.gaugeTDS.SubscriptText = "ppm";
            this.gaugeTDS.SuperscriptColor = System.Drawing.Color.Black;
            this.gaugeTDS.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.gaugeTDS.SuperscriptText = "";
            this.gaugeTDS.TabIndex = 0;
            this.gaugeTDS.Text = "0.0";
            this.gaugeTDS.TextMargin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            // 
            // groupBoxTurb
            // 
            this.groupBoxTurb.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTurb.Controls.Add(this.gaugeTurb);
            this.groupBoxTurb.ForeColor = System.Drawing.Color.White;
            this.groupBoxTurb.Location = new System.Drawing.Point(15, 408);
            this.groupBoxTurb.Name = "groupBoxTurb";
            this.groupBoxTurb.Size = new System.Drawing.Size(198, 195);
            this.groupBoxTurb.TabIndex = 0;
            this.groupBoxTurb.TabStop = false;
            this.groupBoxTurb.Text = "Turbidity";
            // 
            // gaugeTurb
            // 
            this.gaugeTurb.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gaugeTurb.AnimationSpeed = 500;
            this.gaugeTurb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeTurb.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeTurb.ForeColor = System.Drawing.Color.Fuchsia;
            this.gaugeTurb.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeTurb.InnerMargin = 2;
            this.gaugeTurb.InnerWidth = -1;
            this.gaugeTurb.Location = new System.Drawing.Point(11, 16);
            this.gaugeTurb.Margin = new System.Windows.Forms.Padding(2);
            this.gaugeTurb.MarqueeAnimationSpeed = 2000;
            this.gaugeTurb.Name = "gaugeTurb";
            this.gaugeTurb.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gaugeTurb.OuterMargin = -25;
            this.gaugeTurb.OuterWidth = 26;
            this.gaugeTurb.ProgressColor = System.Drawing.Color.Fuchsia;
            this.gaugeTurb.ProgressWidth = 15;
            this.gaugeTurb.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeTurb.Size = new System.Drawing.Size(176, 170);
            this.gaugeTurb.StartAngle = 90;
            this.gaugeTurb.SubscriptColor = System.Drawing.Color.Black;
            this.gaugeTurb.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.gaugeTurb.SubscriptText = "NTU";
            this.gaugeTurb.SuperscriptColor = System.Drawing.Color.Black;
            this.gaugeTurb.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.gaugeTurb.SuperscriptText = "";
            this.gaugeTurb.TabIndex = 0;
            this.gaugeTurb.Text = "0.0";
            this.gaugeTurb.TextMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // LiveTimer
            // 
            this.LiveTimer.Tick += new System.EventHandler(this.LiveTimer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1917, 987);
            this.Controls.Add(this.groupBoxTDS);
            this.Controls.Add(this.groupBoxTurb);
            this.Controls.Add(this.groupBoxEC);
            this.Controls.Add(this.groupBoxTemp);
            this.Controls.Add(this.groupBoxpH);
            this.Controls.Add(this.groupBoxBattery);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxRange);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "SmartBuoy Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rangeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.groupBoxChart.ResumeLayout(false);
            this.groupBoxChart.PerformLayout();
            this.groupBoxBattery.ResumeLayout(false);
            this.groupBoxTemp.ResumeLayout(false);
            this.groupBoxEC.ResumeLayout(false);
            this.groupBoxpH.ResumeLayout(false);
            this.groupBoxTDS.ResumeLayout(false);
            this.groupBoxTurb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CircularProgressBar.CircularProgressBar gaugeBatt;
        private System.Windows.Forms.TrackBar rangeSlider;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.GroupBox groupBoxRange;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.Label lblEndSlide;
        private System.Windows.Forms.Label lblStartSlide;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblSlider;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.Button btnHistoric;
        private System.Windows.Forms.GroupBox groupBoxBattery;
        private System.Windows.Forms.Integration.ElementHost MapHost;
        private System.Windows.Forms.GroupBox groupBoxTemp;
        private CircularProgressBar.CircularProgressBar gaugeTemp;
        private System.Windows.Forms.GroupBox groupBoxEC;
        private CircularProgressBar.CircularProgressBar gaugeEC;
        private System.Windows.Forms.GroupBox groupBoxpH;
        private CircularProgressBar.CircularProgressBar gaugePH;
        private System.Windows.Forms.GroupBox groupBoxTDS;
        private CircularProgressBar.CircularProgressBar gaugeTDS;
        private System.Windows.Forms.GroupBox groupBoxTurb;
        private CircularProgressBar.CircularProgressBar gaugeTurb;
        private MapUserControl BuoyMap;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Timer LiveTimer;
        private System.Windows.Forms.Label lblGet;
    }
}

