using System;
namespace GXPEngine
{
	public class Player : Sprite
	{

		public static float PlayerPosX;

		private float _LastY;
		private int _timer;
		private int _crouchTimer;
		private int _wagonNumber;
		private int _animState;

		private int _TNTcooldown;

		private bool _blink;
		private int _blinkTimer;

		public static int Lives;
		public static int Score;
		public static int Ammo;
		public static int DynamiteCount;

		private PlayerAnimation playeranimation;

		private float _gravity;
		private bool _canJump;

		private float speedX;
		private float speedY;


		private int _gunReloadTimer;

		private int state;


		public Player() : base ("playerhitbox.png")
		{
			playeranimation = new PlayerAnimation();
			AddChild(playeranimation);

			state = 1;
			_animState = 0;
			_crouchTimer = 0;
			_gunReloadTimer = 0;

			_blinkTimer = 0;
			_blink = false;

			Lives = 5;
			Score = 0;

			Ammo = 6;
			DynamiteCount = 8;

			SetOrigin(width / 2, height);
			x = 400;
			y = 300;
			_LastY = 0;
			_timer = 0;

			_gravity = 1.05f;
			_canJump = true;


			speedX = 1.0f;
			speedY = 1.0f;

			scaleX = scaleX * 0.2f;
			scaleY = scaleY * 0.2f;


		}

		public static void AddScore() 
		{
			Score = Score + 10;
		
		}

		public static void AddLife()
		{
			Lives = Lives + 1;

		}

		public static void LoseLife()
		{
			Lives = Lives - 1;

		}


		private void SetBlinkTrue() 
		{
			_blink = true;
		}

		void Update() 
		{

			if (speedX < 0.1f) 
			{
				playeranimation.SetFrame(17);

			}

			if (Lives <= 0)
			{
				this.Destroy();
				//MyGame myGame = game as MyGame;
				//myGame.DestroyLevel();
				//myGame.ShowMenu();
			}

			if (y <= 100) 
			{
				speedY = speedY + 2;
			}

			if (y >= 800)
			{
				LoseLife();
			}

			_TNTcooldown = _TNTcooldown - 1;

			if (_TNTcooldown <= 0) 
			{
				_TNTcooldown = 0;
			
			}

			if (DynamiteCount <= 0) 
			{
				DynamiteCount = 0;
			}

			_blinkTimer = _blinkTimer - 1;
			if (_blinkTimer <= 0) 
			{
				playeranimation.alpha = 1;
				_blinkTimer = 0;
				_blink = false;
			}

			if (_blink == true) 
			{
				playeranimation.alpha = _blinkTimer / 10.0f;;
			
			}

			PlayerPosX = this.x;

			_gunReloadTimer =_gunReloadTimer - 1;
			_timer = _timer - 1;
			_crouchTimer = _crouchTimer - 1;

			if (_timer <= 0)
			{

				_timer = 0;

			}

			if (_gunReloadTimer <= 0)
			{
				
				_gunReloadTimer = 0;

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
					_animState = 1;
					playeranimation.Mirror(false, false);
					
				}

			if (Input.GetKeyDown(Key.S) && _crouchTimer == 0)
			{
				scaleY = scaleY *(0.5f);
				_crouchTimer = 50;

			}

			if (Input.GetKey(Key.A))
				{
					speedX = speedX - 2;
					state = 2;
					_animState = 2;
					playeranimation.Mirror(true, false);
				}

			if (Input.GetKeyDown(Key.SPACE) && _canJump == true)
				{
					speedY = speedY - 70;
					_canJump = false;
					_timer = 20;
					
				}

			if (Input.GetKeyDown(Key.LEFT_SHIFT) && _gunReloadTimer <= 0)
			{

				MyGame myGame = game as MyGame;
				myGame.CallBulletSpawn(x, y - height, state);
				Ammo = Ammo - 1;

				if (Ammo <= 0) 
				{
					_gunReloadTimer = 100;
					Ammo = 6;
				}

			}

			if (Input.GetKeyDown(Key.LEFT_CTRL) && _TNTcooldown <= 0 && DynamiteCount >= 1)
			{

				MyGame myGame = game as MyGame;
				myGame.CallTNTSpawn(x, y - height);
				DynamiteCount = DynamiteCount - 1;
				_TNTcooldown = 200;


			}

				speedX = speedX * 0.8f; 
				speedY = speedY * 0.9f;

				_LastY = y;

				y = y + speedY;
				x = x + speedX;

				y = y * _gravity;

		}


		public void OnCollision(GameObject other)
		{

			if (other is Enemy && _blinkTimer <= 0) 
			{
				LoseLife();
				_blinkTimer = 100;
				SetBlinkTrue();
			}

			if (other is Bullet2 && _blinkTimer <= 0)
			{
				Bullet2 bullet2 = other as Bullet2;
				bullet2.Destroy();
				LoseLife();
				_blinkTimer = 100;
				SetBlinkTrue();
			}
				
			if (other is BaseShort)
			{
				_wagonNumber = 1;
				BaseShort baseshort = other as BaseShort;

				if (y >= baseshort.y)
				{
					y = baseshort.y;

				}

				if (_timer == 0)
				{
					_canJump = true;
				}

			}

			if (other is BaseLongCargo)
			{
				_wagonNumber = 2;
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
				_wagonNumber = 3;
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

			if (other is BaseIntermediateCargo)
			{
				_wagonNumber = 4;

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

			if (other is TallLongCargo)
			{
				_wagonNumber = 2;
				TallLongCargo talllongcargo = other as TallLongCargo;

				if (y < talllongcargo.y + 20 || y <= talllongcargo.y + 50)
				{
					y = talllongcargo.y;

				}

				if (_timer == 0)
				{
					_canJump = true;
				}

				if (y > talllongcargo.y)
				{

					if (x > talllongcargo.x)
					{
						x = talllongcargo.x + 820;

					}

					if (x <= talllongcargo.x)
					{
						x = talllongcargo.x - 20;
					
					}

				}

			}

			if (other is BaseIntermediate)
			{
				_wagonNumber = 5;

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
				_wagonNumber = 2;
				LongBackgroundLocomotive longbackloco = other as LongBackgroundLocomotive;

				if (y < longbackloco.y + 20 || y <= longbackloco.y + 50)
				{
					y = longbackloco.y;

				}

				if (_timer == 0)
				{
					_canJump = true;
				}

				if (y > longbackloco.y)
				{

					if (x > longbackloco.x)
					{
						x = longbackloco.x + 820;

					}

					if (x <= longbackloco.x)
					{
						x = longbackloco.x - 20;

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
