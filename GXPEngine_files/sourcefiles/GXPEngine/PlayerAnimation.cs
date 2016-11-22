using System;
namespace GXPEngine
{
	public class PlayerAnimation : AnimationSprite
	{

		private int _timer;
		private int _frameTimer;

		public PlayerAnimation() : base ("playeranimation.png", 6, 4, 15)
		{

			SetOrigin(width / 2, height);
			_timer = 10;
			_frameTimer = 3;

			SetScaleXY(6.0f, 6.0f);

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
				_timer = 0;
			}

		}

	}
}
