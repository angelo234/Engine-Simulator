using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Engine_Simulator
{
    public partial class Form1 : Form
    {
        private engine.Engine engine;

        private Stopwatch stopwatch;

        private List<double> torque_list = new List<double>();
        private List<double> crank_angle_list = new List<double>();

        public Form1()
        {
            InitializeComponent();  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Setup chart
            Series torque_time_series = new Series("Torque vs Time");
            torque_time_series.ChartType = SeriesChartType.FastLine;

            torque_time_chart.Series.Add(torque_time_series);

            torque_time_chart.ChartAreas[0].AxisX.Minimum = 0;
            torque_time_chart.ChartAreas[0].AxisX.Interval = 1;
            torque_time_chart.ChartAreas[0].AxisY.Maximum = 300;
            torque_time_chart.ChartAreas[0].AxisY.Minimum = 0;


            //Setup chart
            Series torque_crank_angle_series = new Series("Torque vs Crank Angle");
            torque_crank_angle_series.ChartType = SeriesChartType.Point;
            torque_crank_angle_chart.Series.Add(torque_crank_angle_series);

            torque_crank_angle_chart.ChartAreas[0].AxisX.Minimum = 0;
            torque_crank_angle_chart.ChartAreas[0].AxisX.Maximum = 360;
            torque_crank_angle_chart.ChartAreas[0].AxisX.Interval = 45;
            torque_crank_angle_chart.ChartAreas[0].AxisY.Maximum = 300;
            torque_crank_angle_chart.ChartAreas[0].AxisY.Minimum = 0;

           

            engine = Program.physics.engine;

            stopwatch = new Stopwatch();

            stopwatch.Start();

            Timer timer = new Timer();
            timer.Interval = 1000 / 100;
            timer.Tick += new EventHandler(UpdateForm);
            timer.Start();
        }

        private void UpdateForm(object sender, EventArgs e)
        {
            rpm_label.Text = "RPM: " + engine.crankshaft.rpm;

            double last_total_torque = engine.crankshaft.last_total_torque;
            double last_crank_angle = engine.crankshaft.last_crank_angle;


            //Torque vs Time

            Series torque_time_series = torque_time_chart.Series.First();

            DateTime now = DateTime.Now;
            torque_time_series.Points.AddXY(stopwatch.Elapsed.TotalMilliseconds / 1000.0, last_total_torque);

            double time_frame_displayed = 1;

            if (stopwatch.Elapsed.TotalMilliseconds / 1000.0 >= time_frame_displayed)
            {
                //torque_time_chart.ChartAreas[0].RecalculateAxesScale();
                torque_time_chart.ChartAreas[0].AxisX.Minimum = stopwatch.Elapsed.TotalMilliseconds / 1000.0 - time_frame_displayed;

                
                //torque_time_series.Points.RemoveAt(0);

            }

            //Console.WriteLine("x-axis min: " + torque_time_chart.ChartAreas[0].AxisX.Minimum);
            //Console.WriteLine("max x val: " + torque_time_series.Points.Last().XValue);

            //Console.WriteLine(torque_time_series.Points.Count());

            //Torque vs Crank Angle


            torque_list.Add(last_total_torque);
            crank_angle_list.Add(last_crank_angle);

            Series torque_crank_angle_series = torque_crank_angle_chart.Series.First();

            torque_crank_angle_series.Points.DataBindXY(crank_angle_list, torque_list);

            if (crank_angle_list.Last() >= 360.0)
            {
                //torque_crank_angle_series.Points.Clear();

                //torque_list.Clear();
                //crank_angle_list.Clear();

                engine.crankshaft.crank_angle -= 360;
            }

            Refresh();
        }

        private void Paint_Piston(PaintEventArgs e, double crank_angle)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = 100;
            int height = 100;

            float x = 50 + (float)Math.Cos(crank_angle) * 10;
            float y = 50 + (float)Math.Sin(crank_angle) * 10;

            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 0, 0, 0)), x, y, 10, 10);
        }

        private void piston1_picturebox_Paint(object sender, PaintEventArgs e)
        {
            double crank_angle = engine.cylinders[0].piston.crank_angle;

            Paint_Piston(e, crank_angle);
        }

        private void piston2_picturebox_Paint(object sender, PaintEventArgs e)
        {
            double crank_angle = engine.cylinders[1].piston.crank_angle;

            Paint_Piston(e, crank_angle);
        }

        private void piston3_picturebox_Paint(object sender, PaintEventArgs e)
        {
            double crank_angle = engine.cylinders[2].piston.crank_angle;

            Paint_Piston(e, crank_angle);
        }

        private void piston4_picturebox_Paint(object sender, PaintEventArgs e)
        {
            double crank_angle = engine.cylinders[3].piston.crank_angle;

            Paint_Piston(e, crank_angle);
        }

        private void throttle_trackbar_Scroll(object sender, EventArgs e)
        {
            int value = throttle_trackbar.Value;

            engine.throttle_body_position = value / 100.0;
        }
    }
}
