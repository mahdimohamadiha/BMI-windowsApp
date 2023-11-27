using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
	public class Calculator : ICalculate
	{
		public double CalculateBMI (double height, double weight)
		{

			double output = (weight / ((height / 100) * (height / 100)));
			return output;
		}

		public string WeightIndexCalculation (double weight)
		{
			string title;
			if (weight < 18.5)
			{
				title = "Underweight";
			}
			else if (weight < 25)
			{
				title = "Normal";
			}
			else if (weight < 30)
			{
				title = "Overweight";
			}
			else if (weight < 35)
			{
				title = "Obese";
			}
			else
			{
				title = "Extremely obese";
			}
			return title;
		}
	}
}
