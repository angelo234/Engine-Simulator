namespace Engine_Simulator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.piston1_picturebox = new System.Windows.Forms.PictureBox();
            this.piston2_picturebox = new System.Windows.Forms.PictureBox();
            this.piston3_picturebox = new System.Windows.Forms.PictureBox();
            this.piston4_picturebox = new System.Windows.Forms.PictureBox();
            this.rpm_label = new System.Windows.Forms.Label();
            this.torque_time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.torque_crank_angle_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.throttle_trackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.piston1_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piston2_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piston3_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piston4_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torque_time_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torque_crank_angle_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttle_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // piston1_picturebox
            // 
            this.piston1_picturebox.Location = new System.Drawing.Point(12, 161);
            this.piston1_picturebox.Name = "piston1_picturebox";
            this.piston1_picturebox.Size = new System.Drawing.Size(100, 100);
            this.piston1_picturebox.TabIndex = 0;
            this.piston1_picturebox.TabStop = false;
            this.piston1_picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.piston1_picturebox_Paint);
            // 
            // piston2_picturebox
            // 
            this.piston2_picturebox.Location = new System.Drawing.Point(118, 161);
            this.piston2_picturebox.Name = "piston2_picturebox";
            this.piston2_picturebox.Size = new System.Drawing.Size(100, 100);
            this.piston2_picturebox.TabIndex = 1;
            this.piston2_picturebox.TabStop = false;
            this.piston2_picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.piston2_picturebox_Paint);
            // 
            // piston3_picturebox
            // 
            this.piston3_picturebox.Location = new System.Drawing.Point(224, 161);
            this.piston3_picturebox.Name = "piston3_picturebox";
            this.piston3_picturebox.Size = new System.Drawing.Size(100, 100);
            this.piston3_picturebox.TabIndex = 2;
            this.piston3_picturebox.TabStop = false;
            this.piston3_picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.piston3_picturebox_Paint);
            // 
            // piston4_picturebox
            // 
            this.piston4_picturebox.Location = new System.Drawing.Point(330, 161);
            this.piston4_picturebox.Name = "piston4_picturebox";
            this.piston4_picturebox.Size = new System.Drawing.Size(100, 100);
            this.piston4_picturebox.TabIndex = 3;
            this.piston4_picturebox.TabStop = false;
            this.piston4_picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.piston4_picturebox_Paint);
            // 
            // rpm_label
            // 
            this.rpm_label.AutoSize = true;
            this.rpm_label.Location = new System.Drawing.Point(234, 62);
            this.rpm_label.Name = "rpm_label";
            this.rpm_label.Size = new System.Drawing.Size(0, 13);
            this.rpm_label.TabIndex = 4;
            // 
            // torque_time_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.torque_time_chart.ChartAreas.Add(chartArea3);
            this.torque_time_chart.Location = new System.Drawing.Point(452, 12);
            this.torque_time_chart.Name = "torque_time_chart";
            this.torque_time_chart.Size = new System.Drawing.Size(336, 199);
            this.torque_time_chart.TabIndex = 5;
            this.torque_time_chart.Text = "chart1";
            title3.Name = "title1";
            title3.Text = "Torque vs Time";
            this.torque_time_chart.Titles.Add(title3);
            // 
            // torque_crank_angle_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.torque_crank_angle_chart.ChartAreas.Add(chartArea4);
            this.torque_crank_angle_chart.Location = new System.Drawing.Point(452, 239);
            this.torque_crank_angle_chart.Name = "torque_crank_angle_chart";
            this.torque_crank_angle_chart.Size = new System.Drawing.Size(336, 199);
            this.torque_crank_angle_chart.TabIndex = 6;
            this.torque_crank_angle_chart.Text = "chart1";
            title4.Name = "title1";
            title4.Text = "Torque vs Crank Angle";
            this.torque_crank_angle_chart.Titles.Add(title4);
            // 
            // throttle_trackbar
            // 
            this.throttle_trackbar.LargeChange = 50;
            this.throttle_trackbar.Location = new System.Drawing.Point(185, 345);
            this.throttle_trackbar.Maximum = 100;
            this.throttle_trackbar.Name = "throttle_trackbar";
            this.throttle_trackbar.Size = new System.Drawing.Size(104, 45);
            this.throttle_trackbar.SmallChange = 10;
            this.throttle_trackbar.TabIndex = 7;
            this.throttle_trackbar.TickFrequency = 10;
            this.throttle_trackbar.Scroll += new System.EventHandler(this.throttle_trackbar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.throttle_trackbar);
            this.Controls.Add(this.torque_crank_angle_chart);
            this.Controls.Add(this.torque_time_chart);
            this.Controls.Add(this.rpm_label);
            this.Controls.Add(this.piston4_picturebox);
            this.Controls.Add(this.piston3_picturebox);
            this.Controls.Add(this.piston2_picturebox);
            this.Controls.Add(this.piston1_picturebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piston1_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piston2_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piston3_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piston4_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torque_time_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torque_crank_angle_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttle_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piston1_picturebox;
        private System.Windows.Forms.PictureBox piston2_picturebox;
        private System.Windows.Forms.PictureBox piston3_picturebox;
        private System.Windows.Forms.PictureBox piston4_picturebox;
        private System.Windows.Forms.Label rpm_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart torque_time_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart torque_crank_angle_chart;
        private System.Windows.Forms.TrackBar throttle_trackbar;
    }
}

