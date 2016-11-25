using System;
namespace GXPEngine
{
	public class Bullet : Sprite
	{
		public int _direction = -1;
		public int _score = 0;
		Sound _bullitsound;

		public Bullet(float spawnX, float spawnY, int direction) : base("bulletgrey.png")
		{
			scaleX = 0.8f;
			scaleY = 0.8f;

			SetOrigin(width, height / 2);
			x = spawnX;
			y = spawnY;
			_direction = direction;

			_bullitsound = new Sound("gunshot.wav", false, false);
			_bullitsound.Play();

			//Check direction
			if (_direction == 2)
			{
				Mirror(false, false);
				x -= 80;
			}
			else if (_direction == 1)
			{
				Mirror(true, false);
				x += 80;
			}

		}

		private void Update()
		{

			if (x <= -1000) 
			{
				Destroy();
			}

			if (x >= 7000) 
			{
				Destroy();
			}

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

			if (other is Enemy)
			{

				Player.AddScore();
				Enemy enemy = other as Enemy;
				enemy.Destroy();
				this.Destroy();

			}

			if (other is LongBackgroundLocomotive)
			{
				this.Destroy();

			}

			else if (other is Crate)
			{
				Destroy();
			}

			if (other is Enemy2)
			{
				Player.AddScore();
				Enemy2 enemy2 = other as Enemy2;
				enemy2.Destroy();
				this.Destroy();
			}

			if (other is TallLongCargo)
			{
				this.Destroy();
			}


			if (other is Station)
			{
				this.Destroy();
			}
		}
	}
}

