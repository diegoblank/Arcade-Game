using System;
namespace GXPEngine
{
	public class Dynamite : Sprite
	{
		public Dynamite(float spawnX, float spawnY) : base ("dynamite.png")
		{
			scaleX = 0.1f;
			scaleY = 0.1f;         
			x = spawnX;
			y = spawnY;
		}

		private void Update()
		{
			
		}
	}
}
