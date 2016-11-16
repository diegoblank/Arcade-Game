using System;
namespace GXPEngine
{
	public class Crate : Sprite
	{
		public Crate(int PosX, int PosY) : base ("crate.png")
		{
			SetXY(PosX, PosY);


			SetScaleXY(0.3f, 0.3f);

		}
	}
}
