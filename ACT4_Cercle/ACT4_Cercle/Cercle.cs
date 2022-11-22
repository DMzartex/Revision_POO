using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ACT4_Cercle
{
    internal class Cercle
    {
		private float _rayon;

		public float Rayon
		{
			get { return _rayon; }
			set { _rayon = value; }
		}

		public Cercle(float rayon)
		{
			this._rayon = rayon;
		
		}

		public double CalculePerimetre()
		{
			double peri = 0;
			peri = 2 * Math.PI * _rayon;
			return peri;
		}

		public double CalculeAire()
		{
			double air = 0;
			air = Math.PI * _rayon * _rayon;
			return air;
		}
	}
}
