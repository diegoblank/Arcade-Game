using System;
namespace GXPEngine
{
	public class Dynamite : Sprite

	{

		private float _gravity;
		private int _detonationTimer;

		public Dynamite(float spawnX, float spawnY) : base("dynamite.png")
		{

			_gravity = 1.05f;
			_detonationTimer = 200;

			x = spawnX;
			y = spawnY;

			SetOrigin(width / 2, height / 2);
			SetScaleXY(0.2f, 0.2f);

		}

		void Update()
		{
			_detonationTimer = _detonationTimer - 1;
			if (_detonationTimer <= 0)
			{
				_detonationTimer = 0;
				Destroy();

			}

			y = y * _gravity;


		}

		public void OnCollision(GameObject other)
		{
			if (other is BaseShort)
			{
				
				BaseShort baseshort = other as BaseShort;

				if (y >= baseshort.y)
				{
					y = baseshort.y;

				}


			}

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

			if (other is LongCeiling)
			{
				LongCeiling baseceiling = other as LongCeiling;

				if (y <= baseceiling.y + 120)
				{
					y = baseceiling.y;

				}

				if (other is BaseIntermediateCargo)
				{

					BaseIntermediateCargo baseintermediatecargo = other as BaseIntermediateCargo;

					if (y >= baseintermediatecargo.y)
					{
						y = baseintermediatecargo.y;

					}
				}

				if (other is TallLongCargo)
				{

					TallLongCargo talllongcargo = other as TallLongCargo;

					if (y < talllongcargo.y + 20)
					{
						y = talllongcargo.y;


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

						BaseIntermediate baseintermediate = other as BaseIntermediate;

						if (y >= baseintermediate.y)
						{
							y = baseintermediate.y;

						}


					}

					if (other is BaseIntermediateCeiling)
					{

						BaseIntermediateCeiling baseintermediateceiling = other as BaseIntermediateCeiling;

						if (y <= baseintermediateceiling.y + 120)
						{
							y = baseintermediateceiling.y;

						}


					}

					if (other is LongBackgroundLocomotive)
					{

						LongBackgroundLocomotive longbackloco = other as LongBackgroundLocomotive;

						if (y < longbackloco.y + 20)
						{
							y = longbackloco.y;

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


				}
			}
		}
	}
}
