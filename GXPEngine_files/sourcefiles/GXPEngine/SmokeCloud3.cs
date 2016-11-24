using System;
namespace GXPEngine
{
	public class SmokeCloud3 : Sprite
	{

		private int StartPosX;
		private int StartPosY;
		private float NegativeAcc;
		private float Acc;
		private int _timer;

		private float SpeedX;
		private float SpeedY;

		public SmokeCloud3() : base("smokecloud3.png")
		{
			SetOrigin(width / 2, height / 2);

			SpeedY = -3.0f;
			SpeedX = -1.0f;

			StartPosX = 5850;
			StartPosY = 330;

			_timer = 1000;

			NegativeAcc = 0.99f;
			Acc = 1.01f;

			SetScaleXY(2.0f, 2.0f);

			x = StartPosX;
			y = StartPosY;


		}

		void Update()
		{

			x = x + SpeedX;
			y = y + SpeedY;



			_timer = _timer - 1;

			SpeedY = SpeedY * NegativeAcc;

			if (_timer > 850)
			{
				SpeedX = SpeedX * Acc;

			}

			if (_timer <= 400)
			{
				alpha = alpha * 0.99f;

			}


			if (_timer <= 0)
			{
				this.Destroy();

			}

			rotation = rotation + 1;

		}
	}
}