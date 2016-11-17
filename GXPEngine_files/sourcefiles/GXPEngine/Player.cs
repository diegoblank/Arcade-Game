using System;
namespace GXPEngine
{
	public class Player : Sprite
	{

		public static float PlayerPosX;

		private float _LastY;
		private int _timer;
		private int _crouchTimer;

		private float _gravity;
		private bool _canJump;

		private float speedX;
		private float speedY;

		private int state;

		private Level _level;

		public Player(Level level) : base ("player.png")
		{
			state = 1;
			_crouchTimer = 0;

			SetOrigin(width / 2, height);
			x = 400;
			y = 300;
			_LastY = 0;
			_timer = 0;

			_gravity = 1.05f;
			_canJump = true;


			speedX = 1.0f;
			speedY = 0.95f;

			scaleX = scaleX * 0.2f;
			scaleY = scaleY * 0.2f;

			_level = level;
		}

		void Update() 
		{


			PlayerPosX = this.x;

			_timer = _timer - 1;
			_crouchTimer = _crouchTimer - 1;

			if (_timer <= 0)
			{

				_timer = 0;

			}

			if (_crouchTimer <= 0) 
			{
				_crouchTimer = 0;
				scaleY = 0.2f;
			}

			if (Input.GetKey(Key.D))
				{
					speedX = speedX + 2;
					state = 1;
					Mirror(true, false);
					
				}

			if (Input.GetKeyDown(Key.S) && _crouchTimer == 0)
			{
				
				state = 4;
				scaleY = scaleY *(0.5f);
				_crouchTimer = 50;

			}

			if (Input.GetKey(Key.A))
				{
				speedX = speedX - 2;
					state = 2;
					Mirror(false, false);
				}

			if (Input.GetKeyDown(Key.SPACE) && _canJump == true)
				{
					speedY = speedY - 70;
					_canJump = false;
					_timer = 20;
					state = 3;
				}

			if (Input.GetKeyDown(Key.LEFT_SHIFT))
			{
				Bullet bullet = new Bullet(x, y - height*0.7f, state);
				_level.AddChild(bullet);
			}

				//if (Input.GetKey(Key.SPACE) && _timer >= 0)
				//{
				//speedY = speedY * 1.1f;
				//speedY += 1f;
				//}

				
				speedX = speedX * 0.8f; 
				speedY = speedY * 0.9f;

				_LastY = y;

				y = y + speedY;
				x = x + speedX;

				y = y * _gravity;


				Console.WriteLine(state);

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

				if (_timer == 0) 
				{
					_canJump = true;
				}

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


				if (_timer == 0)
				{
					_canJump = true;
				}

			}

			if (other is BaseShort)
			{

				BaseShort wagon3 = other as BaseShort;

				if (y >= wagon3.y)
				{
					y = wagon3.y;

				}

				if (_timer == 0)
				{
					_canJump = true;
				}

			}

			if (other is BaseIntermediateCargo)
			{

				BaseIntermediateCargo baseintermediatecargo = other as BaseIntermediateCargo;

				if (y >= baseintermediatecargo.y)
				{
					y = baseintermediatecargo.y;

				}

				if (_timer == 0)
				{
					_canJump = true;
				}

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

				if (_timer == 0)
				{
					_canJump = true;
				}

			}

			if (other is LongBackgroundLocomotive)
			{

				LongBackgroundLocomotive longbackgroundfront = other as LongBackgroundLocomotive;

				if (y >= longbackgroundfront.y)
				{
					y = longbackgroundfront.y;

				}

				if (_timer == 0)
				{
					_canJump = true;
				}

			}


			if (other is Crate)
			{

				Crate crate = other as Crate;

				if (y > crate.y) 
				{ 
				
					if (x > crate.x)
						{
							x = crate.x + 65;
							crate.x = crate.x - 4;
						}

					if (x <= crate.x)
						{
							x = crate.x - 65;
							crate.x = crate.x + 4;
						}
				
				}


				if (y <= crate.y + 40)
				{
					y = crate.y -40;
				}


				if (_timer == 0)
				{
					_canJump = true;
				}

			}



		}
	}
}
