using System;
namespace GXPEngine
{
	public class BaseIntermediateCargo : Sprite
	{
		public BaseIntermediateCargo(int PosX, int PosY) : base("wagonplatform600.png")
		{
			SetXY(PosX, PosY);
		}
	}
}
