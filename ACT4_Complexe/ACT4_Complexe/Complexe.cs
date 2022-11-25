using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT4_Complexe
{
    internal class Complexe
    {
		private float _reelle1;

		public float Reelle1
		{
			get { return _reelle1; }
			set { _reelle1 = value; }
		}

		private float _reelle2;

		public float Reelle2
		{
			get { return _reelle2; }
			set { _reelle2 = value; }
		}

		public Complexe(float reelle1, float reelle2)
		{
			this._reelle1 = reelle1;
			this._reelle2 = reelle2;
		}

		public string AfficheComplexe()
		{
			string complexe ="";
			complexe = $"({_reelle1.ToString("f2")}, {_reelle2.ToString("f2")})";
			return complexe;

		}

		public double CalculeModule()
		{
			double moduleComplexe = Math.Sqrt(Math.Pow(_reelle1, 2) + Math.Pow(_reelle2, 2));
			return moduleComplexe;
		}

		public void Ajout(float AjtReelle1, float AjtReelle2)
		{
			Reelle1 += AjtReelle1;
			Reelle2 += AjtReelle2;
		}


	}
}
