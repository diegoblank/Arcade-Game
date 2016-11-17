using System;
using System.Drawing;
namespace GXPEngine
{
	public class HUD : Canvas
	{


		public HUD() : base(400, 200)
		{
		}

		void Update()
		{
			graphics.Clear(Color.Empty);
			graphics.DrawString("Score:", SystemFonts.DefaultFont, Brushes.Blue, 0, 0);

		}
	}
}
