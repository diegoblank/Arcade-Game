using System;
namespace GXPEngine
{
	public class Wagon7 : GameObject
	{
		public Wagon7() : base()
		{


			Wheel wheel1 = new Wheel(3780, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(3850, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(4350, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(4420, 690);
			AddChild(wheel4);


			TrainBottom trainbottom = new TrainBottom(3700, 620);
			AddChild(trainbottom);

			LongBackground longbackground = new LongBackground(3700, 400);
			AddChild(longbackground);

			BaseLong baselong = new BaseLong(3700, 600);
			AddChild(baselong);

			LongCeiling baselongceiling = new LongCeiling(3700, 400);
			AddChild(baselongceiling);

		}
	}
}
