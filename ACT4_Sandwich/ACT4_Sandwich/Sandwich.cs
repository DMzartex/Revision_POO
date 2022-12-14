using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT4_Sandwich
{
	

	internal class Sandwich
    {
        private string[] _proteine = new string[4] {"jambon","roast-beef","steak","salami"};

		public string[] Proteine
		{
			get { return _proteine; }
			set { _proteine = value; }
		}

		private string[] _condiments = new string[4] {"guacamole","moutarde","pesto","boursin"};

		public string[] Condiments
		{
			get { return _condiments; }
			set { _condiments = value; }
		}

		private string[] _pain = new string[4] {"pain gris","pain blanc","pain au noix","pain au céréales"};

		public string[] Pain
		{
			get { return _pain; }
			set { _pain = value; }
		}

		private string[] _crudites = new string[4] {"salade","tomate","oignon","carotte"};

		public string[] Crudites
		{
			get { return _crudites; }
			set { _crudites = value; }
		}

		public string composeSandwich() {

			string proteine = "";
			string condiments = "";
			string pain = "";
			string crudites = "";
			string sandwich = "";

			for (int i = 0; i < 4;i++ )
			{
                Random aleatoire = new Random();
                int entier = aleatoire.Next(4);

                switch (i)
				{
					case 0:
						proteine = Proteine[entier];
						break;
					case 1:
						condiments = Condiments[entier];
						break;
					case 2:
						pain= Pain[entier];
						break;
					case 3:
						crudites= Crudites[entier];
						break;
				}
			}

			return sandwich = "Voici votre sandich " + proteine + ", " + condiments + ", " + pain + ", " + crudites;
            
        }

	}
}
