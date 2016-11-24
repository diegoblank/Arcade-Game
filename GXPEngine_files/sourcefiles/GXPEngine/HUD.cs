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
			graphics.DrawString("Lives:" + Player.Lives, SystemFonts.DefaultFont, Brushes.Blue, 80, 0);
			graphics.DrawString("Enemies left to spawn:" + Level.EnemiesLeft, SystemFonts.DefaultFont, Brushes.Blue, 0, 80);

			graphics.DrawString("Ammo:" + Player.Ammo, SystemFonts.DefaultFont, Brushes.Blue, 0, 40);
			graphics.DrawString("TNT Ammo:" + Player.DynamiteCount, SystemFonts.DefaultFont, Brushes.Blue, 0, 60);


		}
	}
}
