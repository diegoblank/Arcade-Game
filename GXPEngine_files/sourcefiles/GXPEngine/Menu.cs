using System;
namespace GXPEngine
{
	public class Menu : GameObject
	{
		private Button _button;


		public Menu() : base ()
		{

			Startscreen startscreen = new Startscreen();
			AddChild(startscreen);


			_button = new Button();
			AddChild(_button);
			_button.x = (game.width - _button.width) / 2;
			_button.y = (game.height - _button.height) / 2;
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (_button.HitTestPoint (Input.mouseX, Input.mouseY))
				{
					MyGame myGame = game as MyGame;
					myGame.CreateLevel();
					myGame.CreateHud();
					this.Destroy();
				}
			}

		}
	}
}
