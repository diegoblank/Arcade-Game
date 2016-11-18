using System;
namespace GXPEngine
{
	public class Dynamite : Sprite
	{
		public Dynamite(float spawnX, float spawnY) : base ("dynamite.png")
		{

			x = spawnX;
			y = spawnY;

			SetOrigin(width / 2, height / 2);
			SetScaleXY(0.2f, 0.2f);

		}
	}
}
