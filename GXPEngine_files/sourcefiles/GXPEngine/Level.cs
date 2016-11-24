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
		private ParallaxLayer2 parallaxlayer2;
		private Rails rails;

		public static int EnemiesLeft;

		private int[] levelDataPointer = null;


		private int[] level1 = new int[10] {1, 1, 1, 2, 1, 2, 1, 1, 1, 2};

		private int[] level2 = new int[20] { 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1};

		private int[] level3 = new int[20] { 1, 1, 2, 1, 1, 2, 1, 1, 1, 2, 1, 2, 1, 1, 1, 2, 1, 2, 1, 1 };

		public Level() //TRAIN SETUP
		{

			random = new Random();
			
			background = new Background();
			AddChild(background);

			parallaxlayer2 = new ParallaxLayer2();
			AddChild(parallaxlayer2);

			parallaxlayer = new ParallaxLayer();
			AddChild(parallaxlayer);

			//train
		
			Wagon1 wagon1 = new Wagon1();
			AddChild(wagon1);

			Wagon2 wagon2 = new Wagon2();
			AddChild(wagon2);

			Wagon3 wagon3 = new Wagon3();
			AddChild(wagon3);

			Wagon4 wagon4 = new Wagon4();
			AddChild(wagon4);

			Wagon5 wagon5 = new Wagon5();
			AddChild(wagon5);

			Wagon6 wagon6 = new Wagon6();
			AddChild(wagon6);

			Wagon7 wagon7 = new Wagon7();
			AddChild(wagon7);

			Wagon8 wagon8 = new Wagon8();
			AddChild(wagon8);

			//locomotive

			LongBackgroundLocomotive longlocomotive = new LongBackgroundLocomotive(5120, 400);
			AddChild(longlocomotive);

			LocomotiveWheelAnim wheelanim = new LocomotiveWheelAnim();
			AddChild(wheelanim);

			//smoke

			Smoke smoke = new Smoke();
			AddChild(smoke);

<<<<<<< HEAD
=======
			//train objects


>>>>>>> 19e908bf2c323b253f005dcc37cfc8fd6827ee88
			Crate crate1 = new Crate(380, 560);
			AddChild(crate1);

			Crate crate2 = new Crate(200, 560);
			AddChild(crate2);

			Player player = new Player(400, -100);
			AddChild(player);

			rails = new Rails();
			AddChild(rails);

			scrollTarget = player;

		}

		public void CreateBullet(float pX, float pY, int pState) 
		{ 
			Bullet bullet = new Bullet(pX + 20, pY + 55, pState);
			AddChild(bullet);
		
		
		}

		public void CreateBullet2(float pX, float pY, int pState)
		{
			Bullet2 bullet2 = new Bullet2(pX, pY + 40, pState);
			AddChild(bullet2);
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
				_spawnTimer = 100;
			}

			if (background.x < -6400)
			{
				background.x = -1280;

			}

			if (parallaxlayer.x < -6400)
			{
				parallaxlayer.x = -1280;

			}

			if (parallaxlayer2.x < -6400)
			{
				parallaxlayer2.x = -1280;

			}

			if (rails.x < -6400)
			{
				rails.x = -1280;

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


						if (tile == 2)
						{
							Enemy2 enemy2 = new Enemy2(random.Next(-160, 4310), 0);
							AddChild(enemy2);

						}


					}

			}

		}

	}
}
