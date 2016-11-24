using System;
namespace GXPEngine
{
	public class Enemy : Sprite
	{

		private float _gravity;
		private float speedY;
		private float speedX;
		private int _walkSpeed;

		public int Enemy1AnimState;

		private EnemyAnimationType1 enemyAnim1; 

		private bool _canJump;

		private Random random;

		public Enemy(float PosX, float PosY) : base ("playerhitbox.png")
		{
			speedY = 1.0f;
			SetXY(PosX, PosY);
			_gravity = 1.05f;
			scaleX = scaleX * 0.2f;
			scaleY = scaleY * 0.2f;
			Enemy1AnimState = 0;

			random = new Random();
			_walkSpeed = random.Next(2, 6);

			_canJump = true;

			speedX = 1.0f;
			speedY = 0.95f;

			SetOrigin(width / 2, height* 5);

			enemyAnim1 = new EnemyAnimationType1();
			AddChild(enemyAnim1);

		}

		void Update() 
		{
			
			if (this.x < Player.PlayerPosX) 
			{
				x = x + _walkSpeed;
				enemyAnim1.Enemy1AnimState = 1;

			}

			if (this.x > Player.PlayerPosX)
			{
				x = x - _walkSpeed;
				enemyAnim1.Enemy1AnimState = 2;

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

				BaseLongCargo baselongcargo = other as BaseLongCargo;

				if (y >= baselongcargo.y)
				{
					y = baselongcargo.y;

				}

				_canJump = true;

			}


				if (other is BaseLong)
				{

					BaseLong baselong = other as BaseLong;


					if (y >= baselong.y)
					{
						y = baselong.y;

					}

					_canJump = false;

				}


				if (other is TallLongCargo)
				{

					TallLongCargo talllongcargo = other as TallLongCargo;

					if (y < talllongcargo.y + 20 || y <= talllongcargo.y + 50)
					{
						y = talllongcargo.y;

					}

					_canJump = true;


					if (y > talllongcargo.y)
					{

						if (x > talllongcargo.x)
						{
							x = talllongcargo.x + 800;
							Jump();
						}

						if (x <= talllongcargo.x)
						{
							x = talllongcargo.x - 50;
							Jump();

						}

					}

				}

				if (other is LongBackground)
				{
					LongBackground longback = other as LongBackground;

					_canJump = false;

				}


				if (other is LongCeiling)
				{
					LongCeiling baseceiling = other as LongCeiling;

					if (y <= baseceiling.y + 120)
					{
						y = baseceiling.y;

					}

					if (y > baseceiling.y)
					{
						y = baseceiling.y + 170;

					}

					_canJump = true;

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


					BaseIntermediateCargo baseintermediatecargo = other as BaseIntermediateCargo;

					if (y >= baseintermediatecargo.y)
					{
						y = baseintermediatecargo.y;

					}


					_canJump = true;


				}

				if (other is BaseIntermediate)
				{

					BaseIntermediate baseintermediate = other as BaseIntermediate;

					if (y >= baseintermediate.y)
					{
						y = baseintermediate.y;

					}

					_canJump = false;

				}

				if (other is BaseIntermediateCeiling)
				{

					BaseIntermediateCeiling baseintermediateceiling = other as BaseIntermediateCeiling;

					if (y <= baseintermediateceiling.y + 120)
					{
						y = baseintermediateceiling.y;

					}

					if (y > baseintermediateceiling.y)
					{
						y = baseintermediateceiling.y + 170;

					}

					_canJump = true;


				}

				if (other is LongBackgroundLocomotive)
				{

					LongBackgroundLocomotive longbackloco = other as LongBackgroundLocomotive;

					if (y < longbackloco.y - 20 || y <= longbackloco.y + 50)
					{
						y = longbackloco.y;

					}

					_canJump = true;


					if (y > longbackloco.y)
					{

						if (x > longbackloco.x)
						{
							x = longbackloco.x + 820;

						}

						if (x <= longbackloco.x)
						{
							x = longbackloco.x - 50;
							Jump();
						}

					}

				}

				if (other is Crate)
				{

					Crate crate = other as Crate;

					if (y > crate.y)
					{

						if (x > crate.x)
						{
							x = crate.x + 40;
							crate.x = crate.x - 4;
							Jump();
						}

						if (x <= crate.x)
						{
							x = crate.x - 80;
							crate.x = crate.x + 4;
							Jump();
						}

					}


					if (y <= crate.y + 40)
					{
						y = crate.y - 40;
					}


				}

				if (other is Explosion)
				{

					Explosion explosion = other as Explosion;
					this.Destroy();
					Player.AddScore();

				}

			
		}
	}
}
