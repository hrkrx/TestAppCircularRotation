using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public double radoffset = 0;
		public double radoffset2 = Math.PI;
		public int stepsize = 50;
		public double radius = 100; //px
		public Button bt1;
		public Button bt2;
		Timer t = new Timer();

		public Form1()
		{
			InitializeComponent();
			t.Tick += t_Tick;
			t.Interval = 50;
			bt1 = btCircular;
			bt2 = btCircular2;
		}

		void t_Tick(object sender, EventArgs e)
		{
			radoffset += (2 * Math.PI) / stepsize;
			if (radoffset >= (2 * Math.PI)) {
				radoffset = 0;
			}
			radoffset2 += (2 * Math.PI) / (stepsize * 2);
			if (radoffset2 >= (2 * Math.PI)) {
				radoffset2 = 0;
			}
			Point center = new Point(200, 200);
			Point actualPoint = calculateCircumferencePoint(radoffset, center, radius);
			bt1.Location = actualPoint;
			Point actualPoint2 = calculateCircumferencePoint(radoffset2, bt1.Location, 50);
			bt2.Location = actualPoint2;

			label1.Text = radoffset.ToString();
			label2.Text = (((int)radoffset) % 3).ToString();
		}

		private Point calculateCircumferencePoint(double radoffset, Point center, double radius)
		{
			Point res = new Point();

			double x = center.X +  radius * Math.Cos(radoffset);
			double y = center.Y +  radius * Math.Sin(radoffset);

			res.X = (int)x;
			res.Y = (int)y;

			return res;
		}

		private void btCircular_Click(object sender, EventArgs e)
		{
			t.Start();
		}
	}
}
