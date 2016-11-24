using System;
namespace GXPEngine
{
	public class Wagon5 : GameObject
	{
		public Wagon5() : base()
		{

			Wheel wheel1 = new Wheel(2360, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(2430, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(2930, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(3000, 690);
			AddChild(wheel4);

			TrainBottom trainbottom = new TrainBottom(2280, 620);
			AddChild(trainbottom);

			TallLongCargo talllongcargo = new TallLongCargo(2280, 400);
			AddChild(talllongcargo);
		}
	}
}
