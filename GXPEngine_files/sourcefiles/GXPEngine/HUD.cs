using System;
using System.Drawing;
namespace GXPEngine
{
	public class HUD : Canvas
	{


		public HUD() : base(600, 300)
		{
		}

		void Update()
		{
			
			graphics.Clear(Color.Empty);
			graphics.DrawString("Score: Lives:", SystemFonts.DefaultFont, Brushes.Black, 0, 0);

		}
	}
}
