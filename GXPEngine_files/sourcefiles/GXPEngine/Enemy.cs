using System;
namespace GXPEngine
{
	public class Enemy : Sprite
	{

		private float _gravity;

		public Enemy(float PosX, float PosY) : base ("bandit.png")
		{

			SetXY(PosX, PosY);
			_gravity = 1.05f;
			SetScaleXY(0.5f, 0.5f);

			SetOrigin(width / 2, height*2);

		}

		void Update() 
		{ 

			y = y * _gravity;

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

			}

			if (other is BaseLong)
			{
				BaseLong baselong = other as BaseLong;

				if (y >= baselong.y)
				{
					y = baselong.y;

				}



			}

			if (other is BaseCeiling)
			{
				BaseCeiling baseceiling = other as BaseCeiling;

				if (y >= baseceiling.y)
				{
					y = baseceiling.y;

				}

			}

			if (other is BaseShort)
			{

				BaseShort wagon3 = other as BaseShort;

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

				if (y >= baseintermediateceiling.y)
				{
					y = baseintermediateceiling.y;

				}

			}

			if (other is LongBackgroundLocomotive)
			{

				LongBackgroundLocomotive longbackgroundfront = other as LongBackgroundLocomotive;

				if (y >= longbackgroundfront.y)
				{
					y = longbackgroundfront.y;

				}

			}
		}
	}
}
