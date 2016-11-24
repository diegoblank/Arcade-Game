using System;
namespace GXPEngine
{
	public class Smoke : GameObject
	{

		Random random;
		private int _timer;
		private int _smokeType;

		public Smoke() : base ()
		{
			random = new Random();
			_timer = 100;
			_smokeType = 0;

		}

		void Update() 
		{

			_timer = _timer - 1;
			if (_timer <= 0) 
			{
				CreateNewSmoke();
				_timer = 100;
			}

		}

		private void CreateNewSmoke() 
		{
			_smokeType = random.Next(1, 4);

			if (_smokeType == 1) 
			{
				SmokeCloud1 smoke1 = new SmokeCloud1();
				AddChild(smoke1);
			}

			if (_smokeType == 2)
			{
				SmokeCloud2 smoke2 = new SmokeCloud2();
				AddChild(smoke2);
			}

			if (_smokeType == 3)
			{
				SmokeCloud3 smoke3 = new SmokeCloud3();
				AddChild(smoke3);
			}


		
		}
	}
}
