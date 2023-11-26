using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			int height = Convert.ToInt32(inputHeight.Text);
			int weight = Convert.ToInt32(inputWeight.Text);
			double output = (weight / (((double) height / 100) * ((double)height / 100)));
			output = Math.Round(output, 2);
			MessageBox.Show(Convert.ToString(output));
		}
	}
}
