using System;
namespace GXPEngine
{
	public class Bullet2 : Sprite
	{
		public int _direction = -1;

		public Bullet2(float spawnX, float spawnY, int direction) : base ("bullet.png")
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
		}

		private void Update()
		{
			if (_direction == -1) //wrong, no direction
				return;
			if (_direction == 2) //left
			{
				x -= 20;
			}
			else if (_direction == 1) //right
			{
				x += 20;
			}
		}
		public void OnCollision(GameObject other)

		{
			if (other is Crate)
			{
				Destroy();
			}

			if (other is Player)
			{
				Player.LoseLife();
				this.Destroy();
			}
		}
	}
}
