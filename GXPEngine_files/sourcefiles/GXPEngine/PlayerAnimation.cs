using System;
namespace GXPEngine
{
	public class PlayerAnimation : AnimationSprite
	{

		private int step;
		public int AnimState;


		public PlayerAnimation() : base ("playeranim.png", 6, 4, 16)
		{

			SetOrigin((width/2), height);
			step = 0;

			SetScaleXY(6.0f, 6.0f);

		}

		void Update()
		{

			step = step - 1;

			if (step <= 0) 
			{
				step = 0;
			}

			if (step <= 1  && AnimState == 1)
			{

				Mirror(false, false);

			}

			if (step <= 1  && AnimState == 2)
			{
				
				Mirror(true, false);

			}




			switch (AnimState)
			{
				case 0:
					if (currentFrame < 19 && step <= 0) {currentFrame++;} 
					else currentFrame = 16;
					break;
				case 1:
					if (currentFrame < 12 && step <= 0) { currentFrame++;}
					else currentFrame = 0;
					break;
				case 2:
					if (currentFrame < 12 && step <= 0) { currentFrame++;}
					else currentFrame = 0;
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
				default:
					break;
			}

		}



	}
}
