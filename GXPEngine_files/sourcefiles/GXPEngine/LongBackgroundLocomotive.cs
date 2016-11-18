using System;
namespace GXPEngine
{
	public class LongBackgroundLocomotive : Sprite
	{
		public LongBackgroundLocomotive(int PosX, int PosY) : base("locomotive.png")
		{
			SetXY(PosX, PosY);
			SetScaleXY(1.4f, 1.3f);
		}
	}
}
