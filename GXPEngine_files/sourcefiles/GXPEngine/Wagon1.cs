using System;
namespace GXPEngine
{
	public class Wagon1 : GameObject
	{
		public Wagon1() : base()
		{

			Wheel wheel1 = new Wheel(-10, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(-80, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(90, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(160, 690);
			AddChild(wheel4);

			BaseShort baseshort = new BaseShort(-160, 600);
			AddChild(baseshort);

			TrainBottomShort trainbottomwagon1 = new TrainBottomShort(-160, 605);
			AddChild(trainbottomwagon1);



		}
	}
}
