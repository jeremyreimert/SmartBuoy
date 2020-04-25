/**************************************************************************************
 * NAME:        Jeremy Reimert
 * DATE:        April 25, 2020
 * PROJECT:     SmartBuoy Simulator
 * DESCRIPTION: This program simulates the operation of SmartBuoy. 
 *              SmartBuoy was built to measure and transmit water quaity data.
 *              Data is live streamed and stored in a database.
 * 
 *              The application has three main functions:
 *              1. Generate random numbers for each measurement
 *              2. Transmit streaming data via Dweet.io 
 *              3. Transmit data to a database
 **************************************************************************************/

namespace SmartBuoySimulator
{
    partial class Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulator));
            this.lblPower = new System.Windows.Forms.Label();
            this.indicatorPower = new System.Windows.Forms.PictureBox();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.indicatorSQL = new System.Windows.Forms.PictureBox();
            this.indicatorGPS = new System.Windows.Forms.PictureBox();
            this.indicatorTDS = new System.Windows.Forms.PictureBox();
            this.indicatorEC = new System.Windows.Forms.PictureBox();
            this.indicatorTURB = new System.Windows.Forms.PictureBox();
            this.indicatorTEMP = new System.Windows.Forms.PictureBox();
            this.indicatorPH = new System.Windows.Forms.PictureBox();
            this.indicatorLIVE = new System.Windows.Forms.PictureBox();
            this.indicatorBATT = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.ReadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.indicatorPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorGPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorTURB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorTEMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorLIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorBATT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.White;
            this.lblPower.Location = new System.Drawing.Point(75, 156);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(114, 39);
            this.lblPower.TabIndex = 0;
            this.lblPower.Text = "Power";
            // 
            // indicatorPower
            // 
            this.indicatorPower.Image = SmartBuoySimulator.Properties.Resources.LED_RedOff;
            this.indicatorPower.Location = new System.Drawing.Point(84, 47);
            this.indicatorPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorPower.Name = "indicatorPower";
            this.indicatorPower.Size = new System.Drawing.Size(100, 92);
            this.indicatorPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorPower.TabIndex = 2;
            this.indicatorPower.TabStop = false;
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Enabled = true;
            this.btnPowerOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPowerOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOn.BackgroundImage")));
            this.btnPowerOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPowerOn.FlatAppearance.BorderSize = 0;
            this.btnPowerOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPowerOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPowerOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOn.Location = new System.Drawing.Point(35, 212);
            this.btnPowerOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(200, 185);
            this.btnPowerOn.TabIndex = 1;
            this.btnPowerOn.UseVisualStyleBackColor = false;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Live";
            // 
            // indicatorSQL
            // 
            this.indicatorSQL.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorSQL.Location = new System.Drawing.Point(285, 66);
            this.indicatorSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorSQL.Name = "indicatorSQL";
            this.indicatorSQL.Size = new System.Drawing.Size(40, 37);
            this.indicatorSQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorSQL.TabIndex = 4;
            this.indicatorSQL.TabStop = false;
            // 
            // indicatorGPS
            // 
            this.indicatorGPS.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorGPS.Location = new System.Drawing.Point(285, 318);
            this.indicatorGPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorGPS.Name = "indicatorGPS";
            this.indicatorGPS.Size = new System.Drawing.Size(40, 37);
            this.indicatorGPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorGPS.TabIndex = 7;
            this.indicatorGPS.TabStop = false;
            // 
            // indicatorTDS
            // 
            this.indicatorTDS.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorTDS.Location = new System.Drawing.Point(285, 276);
            this.indicatorTDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorTDS.Name = "indicatorTDS";
            this.indicatorTDS.Size = new System.Drawing.Size(40, 37);
            this.indicatorTDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorTDS.TabIndex = 8;
            this.indicatorTDS.TabStop = false;
            // 
            // indicatorEC
            // 
            this.indicatorEC.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorEC.Location = new System.Drawing.Point(285, 234);
            this.indicatorEC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorEC.Name = "indicatorEC";
            this.indicatorEC.Size = new System.Drawing.Size(40, 37);
            this.indicatorEC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorEC.TabIndex = 9;
            this.indicatorEC.TabStop = false;
            // 
            // indicatorTURB
            // 
            this.indicatorTURB.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorTURB.Location = new System.Drawing.Point(285, 192);
            this.indicatorTURB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorTURB.Name = "indicatorTURB";
            this.indicatorTURB.Size = new System.Drawing.Size(40, 37);
            this.indicatorTURB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorTURB.TabIndex = 10;
            this.indicatorTURB.TabStop = false;
            // 
            // indicatorTEMP
            // 
            this.indicatorTEMP.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorTEMP.Location = new System.Drawing.Point(285, 150);
            this.indicatorTEMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorTEMP.Name = "indicatorTEMP";
            this.indicatorTEMP.Size = new System.Drawing.Size(40, 37);
            this.indicatorTEMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorTEMP.TabIndex = 11;
            this.indicatorTEMP.TabStop = false;
            // 
            // indicatorPH
            // 
            this.indicatorPH.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorPH.Location = new System.Drawing.Point(285, 108);
            this.indicatorPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorPH.Name = "indicatorPH";
            this.indicatorPH.Size = new System.Drawing.Size(40, 37);
            this.indicatorPH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorPH.TabIndex = 12;
            this.indicatorPH.TabStop = false;
            // 
            // indicatorLIVE
            // 
            this.indicatorLIVE.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorLIVE.Location = new System.Drawing.Point(285, 25);
            this.indicatorLIVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorLIVE.Name = "indicatorLIVE";
            this.indicatorLIVE.Size = new System.Drawing.Size(40, 37);
            this.indicatorLIVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorLIVE.TabIndex = 13;
            this.indicatorLIVE.TabStop = false;
            // 
            // indicatorBATT
            // 
            this.indicatorBATT.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
            this.indicatorBATT.Location = new System.Drawing.Point(285, 359);
            this.indicatorBATT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.indicatorBATT.Name = "indicatorBATT";
            this.indicatorBATT.Size = new System.Drawing.Size(40, 37);
            this.indicatorBATT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.indicatorBATT.TabIndex = 14;
            this.indicatorBATT.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(339, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "pH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "GPS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(339, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Turbidity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(339, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Dissolved Solids";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(339, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Electrical Conductivity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(339, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Battery";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Enabled = false;
            this.btnPowerOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPowerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOff.BackgroundImage")));
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOff.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            this.btnPowerOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPowerOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOff.Location = new System.Drawing.Point(35, 212);
            this.btnPowerOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(200, 185);
            this.btnPowerOff.TabIndex = 15;
            this.btnPowerOff.UseVisualStyleBackColor = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // ReadingTimer
            // 
            this.ReadingTimer.Tick += new System.EventHandler(this.ReadingTimer_TickAsync);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnPowerOff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indicatorBATT);
            this.Controls.Add(this.indicatorLIVE);
            this.Controls.Add(this.indicatorPH);
            this.Controls.Add(this.indicatorTEMP);
            this.Controls.Add(this.indicatorTURB);
            this.Controls.Add(this.indicatorEC);
            this.Controls.Add(this.indicatorTDS);
            this.Controls.Add(this.indicatorGPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indicatorSQL);
            this.Controls.Add(this.indicatorPower);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.btnPowerOn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Simulator";
            this.Text = "SmartBuoy Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.indicatorPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorGPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorTURB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorTEMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorLIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicatorBATT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.PictureBox indicatorPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox indicatorSQL;
        private System.Windows.Forms.PictureBox indicatorGPS;
        private System.Windows.Forms.PictureBox indicatorTDS;
        private System.Windows.Forms.PictureBox indicatorEC;
        private System.Windows.Forms.PictureBox indicatorTURB;
        private System.Windows.Forms.PictureBox indicatorTEMP;
        private System.Windows.Forms.PictureBox indicatorPH;
        private System.Windows.Forms.PictureBox indicatorLIVE;
        private System.Windows.Forms.PictureBox indicatorBATT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Timer ReadingTimer;
    }
}

