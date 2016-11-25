using System;
namespace GXPEngine
{
	public class WinScreen : Sprite
	{

		private int _timer;
		public WinScreen() : base("winscreen.png")
		{
			scaleX = scaleX * 1.1f;
			_timer = 300;
		}

		void Update()
		{
			_timer = _timer - 1;
			if (_timer <= 0)
			{
				MyGame myGame = game as MyGame;
				myGame.SetMenu();
				myGame.SetLeveltoOne();
				Destroy();

			}
		}
	}
}
