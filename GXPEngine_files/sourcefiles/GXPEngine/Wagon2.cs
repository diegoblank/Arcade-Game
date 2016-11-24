using System;
namespace GXPEngine
{
	public class Wagon2 : GameObject
	{
		public Wagon2() : base ()
		{

			Wheel wheel1 = new Wheel(330, 690);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(400, 690);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(900, 690);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(970, 690);
			AddChild(wheel4);



			TrainBottom trainbottom = new TrainBottom(250, 620);
			AddChild(trainbottom);

			BaseLongCargo baselongcargo = new BaseLongCargo(250, 600);
			AddChild(baselongcargo);




		}
	}
}
