using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HW_111023
{
	public class AdditionModel : INotifyPropertyChanged
	{
		private double numberA;
		private double numberB;
		private double result;

		public double NumberA
		{
			get => numberA;
			set
			{
				if (numberA != value) {
					numberA = value;
					OnPropertyChanged();
					CalculateResult();
				}
			}
		}

		public double NumberB
		{
			get => numberB;
			set
			{
				if (numberB != value) {
					numberB = value;
					OnPropertyChanged();
					CalculateResult();
				}
			}
		}

		public double Result
		{
			get => result;
			private set
			{
				if (result != value) {
					result = value;
					OnPropertyChanged();
				}
			}
		}

		private void CalculateResult()
		{
			Result = NumberA + NumberB;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
