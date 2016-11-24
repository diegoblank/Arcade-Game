using System;
namespace GXPEngine
{
	public class PlayerAnimation : AnimationSprite
	{

		private int step;
		public int AnimState;


		public PlayerAnimation() : base ("playeranimation.png", 6, 4, 20)
		{

			SetOrigin(width / 2, height);
			step = 0;

			SetScaleXY(6.0f, 6.0f);

		}

		void Update()
		{

			step = step + 1;

			if (step > 2 && AnimState == 1)
			{
				NextFrame();
				step = 0;
				Mirror(false, false);

			}

			if (step > 2 && AnimState == 2)
			{
				NextFrame();
				step = 0;
				Mirror(true, false);

			}

			if (step > 2 && AnimState == 0)
			{
				
				NextFrame();
				step = 0;
			}

	
	

		}



	}
}
