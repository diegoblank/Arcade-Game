using System;
namespace GXPEngine
{
	public class Wagon6 : GameObject
	{
		public Wagon6() : base()
		{

			Wheel wheel1 = new Wheel(3170, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(3240, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(3540, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(3610, 690);
			AddChild(wheel4);

			BaseIntermediateCargo baseintermediatecargo = new BaseIntermediateCargo(3090, 600);
			AddChild(baseintermediatecargo);

			TrainBottomIntermediate trainbottomintermediate = new TrainBottomIntermediate(3090, 605);
			AddChild(trainbottomintermediate);

		}
	}
}
