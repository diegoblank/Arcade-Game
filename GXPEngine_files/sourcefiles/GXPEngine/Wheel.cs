using System;
namespace GXPEngine
{
	public class Wheel : Sprite
	{
		public Wheel(int PosX, int PosY) : base ("wheel3.png")
		{
			SetOrigin(width / 2, height / 2);
			SetXY(PosX, PosY);
		}

		void Update() 
		{
			rotation = rotation + 20;
		}
	}
}
