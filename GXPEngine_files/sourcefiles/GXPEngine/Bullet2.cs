using System;
namespace GXPEngine
{
	public class Bullet2 : Sprite
	{
		public int _direction = -1;
		Sound _hitsound;
		Sound _bullitsound;

		public Bullet2(float spawnX, float spawnY, int direction) : base ("bulletred.png")
		{

			scaleX = 0.8f;
			scaleY = 0.8f;

			SetOrigin(width, height / 2);
			x = spawnX;
			y = spawnY;
			_direction = direction;
			_hitsound = new Sound("hit.ogg", false, false);
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

			if (other is TallLongCargo)
			{
				this.Destroy();
			}

			if (other is Station)
			{
				this.Destroy();
			}
			if (other is Player)
			{
				Player.LoseLife();
				this.Destroy();
				_hitsound.Play();
			}


		}
	}
}
