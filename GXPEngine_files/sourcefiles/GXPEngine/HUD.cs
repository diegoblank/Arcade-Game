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
			MyGame myGame = game as MyGame;

			graphics.Clear(Color.Empty);
			graphics.DrawString("Score:" + Player.Score, SystemFonts.DefaultFont, Brushes.Blue, 0, 0);
			graphics.DrawString("                      Lives:" + Player.Lives, SystemFonts.DefaultFont, Brushes.Blue, 0, 0);
			graphics.DrawString("                                              Ammo:" + Player.Ammo, SystemFonts.DefaultFont, Brushes.Blue, 0, 0);

		}
	}
}
