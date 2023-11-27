using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
	public interface ICalculate
	{
		double CalculateBMI(double height, double weight);

		string WeightIndexCalculation(double weight);
	}
}
