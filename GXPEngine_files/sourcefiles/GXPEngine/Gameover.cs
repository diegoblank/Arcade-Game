using System;
namespace GXPEngine
{
	public class Gameover : Sprite
	{

		private int _timer;
		public Gameover() : base ("gameover.png")
		{
			scaleX = scaleX * 1.1f;
			_timer = 200;
		}

		void Update() 
		{
			_timer = _timer - 1;
			if (_timer <= 0)
			{
				MyGame myGame = game as MyGame;
				myGame.SetMenu();
				Destroy();

			}
		}
	}
}
