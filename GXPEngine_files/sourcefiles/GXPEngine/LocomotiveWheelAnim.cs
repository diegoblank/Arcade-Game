using System;
namespace GXPEngine
{
	public class LocomotiveWheelAnim : AnimationSprite
	{

		private int _timer;
		private int _frameTimer;
		private int _state;

		public LocomotiveWheelAnim() : base ("wheelanimation2.png", 3, 4, 12)
		{
			
			SetOrigin(width / 2, height);
			_timer = 10;
			_frameTimer = 3;

			x = 5567;
			y = 719;


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


