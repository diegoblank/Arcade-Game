using System;
namespace GXPEngine
{
	public class Wagon4 : GameObject
	{
		public Wagon4() : base ()
		{

			Wheel wheel1 = new Wheel(1950, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(2020, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(2120, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(2190, 690);
			AddChild(wheel4);

			TrainBottomShort trainbottomshort = new TrainBottomShort(1870, 605);
			AddChild(trainbottomshort);

			BaseShort baseshortmiddle = new BaseShort(1870, 600);
			AddChild(baseshortmiddle);


		}
	}
}
