using System;
namespace GXPEngine
{
	public class Wagon3 : GameObject
	{
		public Wagon3() : base()
		{

			Wheel wheel1 = new Wheel(1140, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(1210, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(1710, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(1780, 690);
			AddChild(wheel4);

			TrainBottom trainbottom = new TrainBottom(1060, 620);
			AddChild(trainbottom);

			LongBackground longbackground = new LongBackground(1060, 400);
			AddChild(longbackground);

			BaseLong baselong = new BaseLong(1060, 600);
			AddChild(baselong);

			LongCeiling baselongceiling = new LongCeiling(1060, 400);
			AddChild(baselongceiling);
		}
	}
}
