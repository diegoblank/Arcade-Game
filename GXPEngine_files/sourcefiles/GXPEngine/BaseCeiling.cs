using System;
namespace GXPEngine
{
	public class BaseCeiling : Sprite
	{
		public BaseCeiling(int PosX, int PosY): base("baseceiling.png")
		{
			SetXY(PosX, PosY);
		}
	}
}
