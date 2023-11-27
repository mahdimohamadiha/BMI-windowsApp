using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
	public partial class Form1 : Form
	{
		Calculator calculator;
		public Form1()
		{
			InitializeComponent();
			calculator = new Calculator();
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			double bmi = calculator.CalculateBMI(Convert.ToDouble(inputHeight.Text), Convert.ToDouble(inputWeight.Text));

			bmi = Math.Round(bmi, 2);

			string title = calculator.WeightIndexCalculation(bmi); 

			this.output.Text = Convert.ToString(bmi) + " " + title;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
