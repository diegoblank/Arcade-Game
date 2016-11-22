using System;
namespace GXPEngine
{
	public class Level : GameObject
	{

		private Sprite scrollTarget;
		const int RightBoundary = 660;
		const int LeftBoundary = 620;
		private float PlayerPosX;
		private int _spawnTimer;
		private Background background;
		private Random random;
		private Explosion explosion;
		private ParallaxLayer parallaxlayer;

		private int[] levelDataPointer = null;

		private int[] level1 = new int[10] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

		private int[] level2 = new int[20] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

		private int[] level3 = new int[20] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

		public Level() //TRAIN SETUP
		{

			random = new Random();
			
			background = new Background();
			AddChild(background);

			parallaxlayer = new ParallaxLayer();
			AddChild(parallaxlayer);

			BaseShort baseshort = new BaseShort(-160, 600);
			AddChild(baseshort);

			BaseLongCargo baselongcargo = new BaseLongCargo(250, 600);
			AddChild(baselongcargo);

			Wheel wheel1 = new Wheel(320, 700);
			AddChild(wheel1);

			Wheel wheel2 = new Wheel(400, 700);
			AddChild(wheel2);

			Wheel wheel3 = new Wheel(980, 700);
			AddChild(wheel3);

			Wheel wheel4 = new Wheel(900, 700);
			AddChild(wheel4);

			TrainBottom trainbottom = new TrainBottom(250, 620);
			AddChild(trainbottom);

			LongBackground longbackground = new LongBackground(1060, 400);
			AddChild(longbackground);

			BaseLong baselong = new BaseLong(1060, 600);
			AddChild(baselong);

			LongCeiling baselongceiling = new LongCeiling(1060, 400);
			AddChild(baselongceiling);

			BaseShort baseshortmiddle = new BaseShort(1870, 600);
			AddChild(baseshortmiddle);

			TallLongCargo talllongcargo = new TallLongCargo(2280, 400);
			AddChild(talllongcargo);

			BaseIntermediateCargo baseintermediatecargo = new BaseIntermediateCargo(3090, 600);
			AddChild(baseintermediatecargo);

			IntermediateBackground intermediatebackground = new IntermediateBackground(3700, 400);
			AddChild(intermediatebackground);

			BaseIntermediate baseintermediate = new BaseIntermediate(3700, 600);
			AddChild(baseintermediate);

			BaseIntermediateCeiling baseintermediateceiling = new BaseIntermediateCeiling(3700, 400);
			AddChild(baseintermediateceiling);

			BaseIntermediateCargo baseintermediatefront = new BaseIntermediateCargo(4310, 600);
			AddChild(baseintermediatefront);

			LongBackgroundLocomotive longlocomotive = new LongBackgroundLocomotive(4920, 400);
			AddChild(longlocomotive);


			Crate crate1 = new Crate(380, 560);
			AddChild(crate1);

			Crate crate2 = new Crate(200, 560);
			AddChild(crate2);

			Player player = new Player();
			AddChild(player);


			scrollTarget = player;



		}

		public void CreateBullet(float pX, float pY, int pState) 
		{ 
			Bullet bullet = new Bullet(pX, pY + 40, pState);
			AddChild(bullet);
		
		
		}

		public void CreateTNT(float pX, float pY)
		{
			Dynamite tnt = new Dynamite(pX, pY + 100);
			AddChild(tnt);


		}

		public void CreateExplosion(float pX, float pY)
		{
			explosion = new Explosion(pX, pY);
			AddChild(explosion);


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
			PlayerPosX = scrollTarget.x;
			scrollToTarget();

			_spawnTimer = _spawnTimer - 1;
			if (_spawnTimer <= 0) 
			{
				_spawnTimer = 60;
			}


			if (background.x < -6400) 
			{
				background.x = -1280;
			
			}

			if (parallaxlayer.x < -6400)
			{
				parallaxlayer.x = -1280;

			}

			if (Input.GetKey(Key.A))
			{
				background.x = background.x - 3;
			}

			if (Input.GetKey(Key.D))
			{
				background.x = background.x + 3;
			}
		}




		public void CreateWave(int pCurrentLevel, int pCurrentColumn) 
		{
			if (pCurrentLevel == 1) 
			{
				levelDataPointer = level1;
			}

			if (pCurrentLevel == 2)
			{
				levelDataPointer = level2;
			}

			if (pCurrentLevel == 3)
			{
				levelDataPointer = level3;
			}

			if (pCurrentLevel == 4)
			{
				levelDataPointer = null;
			}

			if (levelDataPointer != null) 
			{

					int tile = levelDataPointer[pCurrentColumn];
					

					if (pCurrentColumn == levelDataPointer.GetLength(0) - 1) 
					{
						MyGame myGame = game as MyGame;
						myGame.EndOfWave();
					}

					if (pCurrentColumn < levelDataPointer.GetLength(0))
					{
						if (tile == 1)
						{
							Enemy enemy = new Enemy(random.Next(-160, 4310), 0);
							AddChild(enemy);

						}

					}

			}

	
		}

	}
}
