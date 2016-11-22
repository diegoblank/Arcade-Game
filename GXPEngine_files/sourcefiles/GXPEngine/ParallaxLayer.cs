using System;
namespace GXPEngine
{
	public class ParallaxLayer : Sprite
	{
		public ParallaxLayer() : base("parallaxscroll.png")
		{
			x = x - 1280;
			y = y - 200;
		
		}

		void Update()
		{
			x = x - 15;

		}

		public void DestroyItself()
		{
			this.Destroy();

		}
	}
}
