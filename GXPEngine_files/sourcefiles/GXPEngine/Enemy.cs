using System;
namespace GXPEngine
{
	public class Enemy : Sprite
	{

		private float _gravity;
		private float speedY;
		private float speedX;

		private bool _canJump;

		public Enemy(float PosX, float PosY) : base ("bandit.png")
		{
			speedY = 1.0f;
			SetXY(PosX, PosY);
			_gravity = 1.05f;
			SetScaleXY(0.5f, 0.5f);


			_canJump = true;

			speedX = 1.0f;
			speedY = 0.95f;

			SetOrigin(width / 2, height*2);

		}

		void Update() 
		{ 


			if (this.x < Player.PlayerPosX) 
			{
				x = x + 5;
				Mirror(false, false);
			}

			if (this.x > Player.PlayerPosX)
			{
				x = x - 5;
				Mirror(true, false);

			}

			speedX = speedX * 0.8f;
			speedY = speedY * 0.8f;

			y = y + speedY;
			x = x + speedX;

			y = y * _gravity;
		
		}


		private void Jump() 
		{
			if (_canJump == true)
			{
				speedY = speedY - 40;
			}
		}

		public void OnCollision(GameObject other)
		{
			if (other is BaseLongCargo)
			{
				_canJump = true;
				BaseLongCargo baselongcargo = other as BaseLongCargo;

				if (y >= baselongcargo.y)
				{
					y = baselongcargo.y;

				}

			}

			if (other is BaseLong)
			{
				BaseLong baselong = other as BaseLong;

				if (y >= baselong.y)
				{
					y = baselong.y;

				}

			}

			if (other is LongBackground)
			{
				LongBackground longback = other as LongBackground;

				_canJump = false;

			}


			if (other is LongCeiling)
			{
				LongCeiling longceiling = other as LongCeiling;
				_canJump = true;
				if (y >= longceiling.y)
				{
					y = longceiling.y;

				}

			}

			if (other is BaseShort)
			{
				
				BaseShort wagon3 = other as BaseShort;
				_canJump = true;
				if (y >= wagon3.y)
				{
					y = wagon3.y;

				}


			}

			if (other is BaseIntermediateCargo)
			{
				_canJump = true;
				BaseIntermediateCargo baseintermediatecargo = other as BaseIntermediateCargo;

				if (y >= baseintermediatecargo.y)
				{
					y = baseintermediatecargo.y;

				}


			}

			if (other is BaseIntermediate)
			{

				BaseIntermediate baseintermediate = other as BaseIntermediate;

				if (y >= baseintermediate.y)
				{
					y = baseintermediate.y;

				}


			}

			if (other is BaseIntermediateCeiling)
			{

				BaseIntermediateCeiling baseintermediateceiling = other as BaseIntermediateCeiling;
				_canJump = true;
				if (y >= baseintermediateceiling.y)
				{
					y = baseintermediateceiling.y;

				}

			}

			if (other is LongBackgroundLocomotive)
			{
				_canJump = true;
				LongBackgroundLocomotive longbackgroundfront = other as LongBackgroundLocomotive;

				if (y >= longbackgroundfront.y)
				{
					y = longbackgroundfront.y;

				}

			}

			if (other is Crate)
			{

				Crate crate = other as Crate;

				if (y > crate.y)
				{

					if (x > crate.x)
					{
						x = crate.x + 70;
						crate.x = crate.x - 1;
						Jump();

					}

					if (x < crate.x)
					{
						x = crate.x - 130;
						crate.x = crate.x + 1;
						Jump();
					}

				}


				if (y <= crate.y + 40)
				{
					y = crate.y - 40;
				}



			}
		}
	}
}
