using System;
namespace GXPEngine
{
	public class Level : GameObject
	{

		private Sprite scrollTarget;
		const int RightBoundary = 660;
		const int LeftBoundary = 620;

		public Level()
		{
			
			Background background = new Background();
			AddChild(background);

			BaseLongCargo baselongcargo = new BaseLongCargo(250, 600);
			AddChild(baselongcargo);

			LongBackground longbackground = new LongBackground(1060, 400);
			AddChild(longbackground);

			BaseLong baselong = new BaseLong(1060, 600);
			AddChild(baselong);

			BaseCeiling baselongceiling = new BaseCeiling(1060, 400);
			AddChild(baselongceiling);

			BaseShort baseshort = new BaseShort(1870, 600);
			AddChild(baseshort);

			BaseIntermediateCargo baseintermediatecargo = new BaseIntermediateCargo(2280, 600);
			AddChild(baseintermediatecargo);

			IntermediateBackground intermediatebackground = new IntermediateBackground(2890, 400);
			AddChild(intermediatebackground);

			BaseIntermediate baseintermediate = new BaseIntermediate(2890, 600);
			AddChild(baseintermediate);

			BaseIntermediateCeiling baseintermediateceiling = new BaseIntermediateCeiling(2890, 400);
			AddChild(baseintermediateceiling);

			Player player = new Player();
			AddChild(player);

			scrollTarget = player;


		}

		private void scrollToTarget() 
		{
			if (scrollTarget != null) 
			{
				if (this.x + scrollTarget.x > RightBoundary) 
				{
					this.x = RightBoundary - scrollTarget.x;
				
				}

				if (this.x + scrollTarget.x < LeftBoundary)
				{
					this.x = LeftBoundary - scrollTarget.x;

				}
			
			}
		
		}

		void Update() 
		{
			scrollToTarget();
		}
	}
}
