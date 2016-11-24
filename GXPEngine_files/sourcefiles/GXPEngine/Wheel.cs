using System;
namespace GXPEngine
{
	public class Wheel : Sprite
	{
		private int _randomRot;
		public Wheel(int PosX, int PosY) : base ("steelwheels.png")
		{
			SetOrigin(width / 2, height / 2);
			SetXY(PosX, PosY);
			SetScaleXY(0.9f, 0.9f);
		}

		void Update() 
		{
			rotation = rotation + 20;
		}
	}
}
