using System;
namespace GXPEngine
{
	public class Bullet : Sprite
	{
		int _direction = -1;
		public Bullet(float spawnX, float spawnY, int direction) : base ("bullet.png")
		{
			scaleX = 0.1f;
			scaleY = 0.1f;
			SetOrigin(width, height / 2);
			x = spawnX;
			y = spawnY;
			_direction = direction;

			//Check direction
			if (_direction == 2)
			{
				Mirror(true, false);
				x -= 80;
			}
			else if (_direction == 1)
			{
				x += 50;
			}


			//Mirror wanneer nodig
		}

		private void Update()
		{
			if (_direction == -1) //wrong, no direction
				return;
			if (_direction == 2) //left
			{
				x -= 10;
			}
			else if (_direction == 1) //right
			{
				x += 10;
			}
		}
	}
}
