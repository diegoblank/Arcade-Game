using System;
namespace GXPEngine
{
	public class Station : Sprite
	{
		public Station() : base ("stationfinal.png")
		{
			x = 7000;

		}

		void Update() 
		{
			x = x - 40;

			if (x <= -5000) 
			{
				Destroy();
			
			}
		}


	}
}
