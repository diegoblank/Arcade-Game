using System;
namespace GXPEngine
{
	public class ParallaxLayer2 : Sprite
	{
		public ParallaxLayer2() : base("parralax2scroll.png")
		{
			x = x - 1280;
			y = y - 100;

		}

		void Update()
		{
			x = x - 10;

		}

		public void DestroyItself()
		{
			this.Destroy();

		}
	}
}
