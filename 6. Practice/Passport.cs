using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Practice
{
    internal class Passport
    {
		private string? _fin;
        private DateTime _date;

        public Passport(string? fin, int year,int month,int day)
        {
            Fin = fin;
            Date = new DateTime(year,month,day);
        }

        public string? Fin
		{
			get { return _fin; }
			set
			{
				if (value.Length == 7)
				{
					_fin = value;
				}
				else
				{
					throw new Exception("Invalid fin input");
				}
			}
		}

		public DateTime Date
		{
			get { return _date; }
			set
			{
				if (value > DateTime.Now.AddYears(-10) && value < DateTime.Now)
				{
					_date = value;
				}
				else
				{
					throw new Exception("Invalid date exception...");
				}
			}
		}
		public void Show()
		{
			Console.WriteLine($"Fin: {Fin}");
			Console.WriteLine($"Date: {Date.ToLongDateString()}");
		}
	}
}
