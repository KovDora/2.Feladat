using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */
		void EKG(double meret, int év)
		{

			if (év == 1)
			{
				Előre(meret);
			}
			else if (év > 1)
			{
				EKG(meret/4, év - 1);
				Balra(90);
				EKG(meret/4, év - 1);
				Jobbra(90);
				
					EKG(meret/4, év - 1);

				
				Jobbra(90);
                for (int i = 0; i < 2; i++)
                {
				EKG(meret/4, év - 1);

                }
				Balra(90);
				EKG(meret/4, év - 1);
				Balra(90);
				EKG(meret/4, év - 1);
				Jobbra(90);
				EKG(meret/4, év - 1);
			}
		}

		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			Jobbra(90);
			EKG(100, 3);
			// Teleport(közép.X, közép.Y+150, észak);
		}
	}
}
