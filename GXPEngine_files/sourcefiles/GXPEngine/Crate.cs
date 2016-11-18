using System;
namespace GXPEngine
{
	public class Crate : Sprite
	{
		public Crate(int PosX, int PosY) : base ("cratescaled.png")
		{
			SetXY(PosX, PosY);
			SetOrigin(width / 2, height / 2);

		}

		public void OnCollision(GameObject other) 
		{ 
			if (other is Crate)
				{

					Crate crate = other as Crate;


						if (x > crate.x)
						{
							x = crate.x + 78;
							crate.x = crate.x - 2;
						}

						if (x < crate.x)
						{
							x = crate.x - 78;
							crate.x = crate.x + 2;
						}
				}
		
		}
	}
}


