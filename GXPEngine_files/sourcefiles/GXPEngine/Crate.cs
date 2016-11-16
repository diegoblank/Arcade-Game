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
	}
}
