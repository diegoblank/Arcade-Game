using System;

namespace GXPEngine
{
	public class Explosion : AnimationSprite
	{

		private int _timer;
		private int _frameTimer;
		Sound _explosionSound;


		public Explosion(float spawnX, float spawnY) : base("explosionred.png", 15, 1)
		{

			SetOrigin(height / 2, width / 2);

			x = spawnX;
			y = spawnY - 150;

			SetScaleXY(2.0f, 2.0f);

			_timer = 20;
			_frameTimer = 3;
			_explosionSound = new Sound("explosion.wav", false, false);
			                            
		}



		void Update()
		{

			if (_frameTimer <= 0)
			{
				NextFrame();
				_frameTimer = 2;

			}


			_timer = _timer - 1;
			_frameTimer = _frameTimer - 1;

			if (_timer <= 0)
			{
				this.Destroy();
				_timer = 0;
				_explosionSound.Play();
			}

		}

	}
}

