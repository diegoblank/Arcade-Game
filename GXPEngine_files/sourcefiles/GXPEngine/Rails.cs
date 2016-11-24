using System;
namespace GXPEngine
{
	public class Rails : Sprite
	{
		public Rails() : base("railsscroll2.png")
		{
			x = x - 1280;


		}

		void Update() 
		{ 
		
			x = x - 40;
		
		}
	}
}
