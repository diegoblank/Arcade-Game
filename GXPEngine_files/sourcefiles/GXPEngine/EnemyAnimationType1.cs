using System;
namespace GXPEngine
{
	public class EnemyAnimationType1 : AnimationSprite
	{

		public int Enemy1AnimState;


		public EnemyAnimationType1() : base("MexicanSprites.png", 6, 4, 21)
		{

			SetOrigin((width / 2), height);

			SetScaleXY(6.0f, 6.0f);

		}

		void Update()
		{


			if (Enemy1AnimState == 1)
			{

				Mirror(false, false);

			}

			if (Enemy1AnimState == 2)
			{

				Mirror(true, false);

			}


			switch (Enemy1AnimState)
			{
				case 0:
					currentFrame++;
					break;
				case 1:
					if (currentFrame < 12) { currentFrame++; }
					else currentFrame = 0;
					break;
				case 2:
					if (currentFrame < 12) { currentFrame++; }
					else currentFrame = 0;
					break;
				case 3:
					currentFrame = 18;
					break;

				default:
					break;
			}




		}

		public void switchAnimState(int state)
		{
			switch (state)
			{
				case 0:
					currentFrame = 15;
					break;
				case 1:
					currentFrame = 0;
					break;
				case 2:
					currentFrame = 0;
					break;
				case 3:
					currentFrame = 0;
					break;
				case 4:
					currentFrame = 0;
					break;
				case 5:
					currentFrame = 0;
					break;
				default:
					break;
			}

		}



	}
}
