using System;
namespace GXPEngine
{
	public class Background : Sprite
	{
		public Background() : base ("backgroundgood.png")
		{
			x = x - 1280;
			y = y - 200;
			scaleY = scaleY * 0.9f;
		}

		void Update() 
		{
			x = x - 3;
		}

		public void DestroyItself() 
		{
			this.Destroy();
		
		}
	}
}
