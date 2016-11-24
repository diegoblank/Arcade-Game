using System;
namespace GXPEngine
{
	public class Wagon8 : GameObject
	{
		public Wagon8() : base()
		{
			Wheel wheel1 = new Wheel(4590, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(4660, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(4960, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(5030, 690);
			AddChild(wheel4);

			BaseIntermediateCargo baseintermediatecargo = new BaseIntermediateCargo(4510, 600);
			AddChild(baseintermediatecargo);

			TrainBottomIntermediate trainbottomintermediate = new TrainBottomIntermediate(4510, 605);
			AddChild(trainbottomintermediate);

	



		}
	}
}
