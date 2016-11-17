using System;
namespace GXPEngine
{
	public class Background : Sprite
	{
		public Background() : base ("backgroundscroll.png")
		{
			x = x - 1280;
		}

		void Update() 
		{
			x = x - 15;
		
		}

	}
}
