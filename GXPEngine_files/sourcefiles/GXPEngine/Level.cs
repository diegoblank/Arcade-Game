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

			Enemy enemy = new Enemy(300, 300);
			AddChild(enemy);

			BaseShort baseshort = new BaseShort(-160, 600);
			AddChild(baseshort);

			BaseLongCargo baselongcargo = new BaseLongCargo(250, 600);
			AddChild(baselongcargo);

			LongBackground longbackground = new LongBackground(1060, 400);
			AddChild(longbackground);

			BaseLong baselong = new BaseLong(1060, 600);
			AddChild(baselong);

			BaseCeiling baselongceiling = new BaseCeiling(1060, 400);
			AddChild(baselongceiling);

			BaseShort baseshortmiddle = new BaseShort(1870, 600);
			AddChild(baseshortmiddle);

			BaseIntermediateCargo baseintermediatecargo = new BaseIntermediateCargo(2280, 600);
			AddChild(baseintermediatecargo);

			IntermediateBackground intermediatebackground = new IntermediateBackground(2890, 400);
			AddChild(intermediatebackground);

			BaseIntermediate baseintermediate = new BaseIntermediate(2890, 600);
			AddChild(baseintermediate);

			BaseIntermediateCeiling baseintermediateceiling = new BaseIntermediateCeiling(2890, 400);
			AddChild(baseintermediateceiling);

			BaseIntermediateCargo baseintermediatefront = new BaseIntermediateCargo(3500, 600);
			AddChild(baseintermediatefront);

			LongBackground longlocomotive = new LongBackground(4110, 400);
			AddChild(longlocomotive);

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

		public float GetPlayerCoords()
		{
			float PlayerPosX = scrollTarget.x;
			return PlayerPosX;


		}

		void Update() 
		{
			scrollToTarget();
		}
	}
}
