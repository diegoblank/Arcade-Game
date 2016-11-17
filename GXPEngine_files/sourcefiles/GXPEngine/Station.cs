using System;
namespace GXPEngine
{
	public class Station : Sprite
	{
		public Station() : base ("station.png")
		{
			x = 7000;

		}

		void Update() 
		{
			x = x - 25;

			if (x <= -5000) 
			{
				Destroy();
			
			}
		}


	}
}
