using System;
namespace GXPEngine
{
	public class Background : Sprite
	{
		public Background() : base ("backgrid.png")
		{

			scaleY = scaleY * 2.0f;
			scaleX = scaleX * 2.0f;
		}
	}
}
