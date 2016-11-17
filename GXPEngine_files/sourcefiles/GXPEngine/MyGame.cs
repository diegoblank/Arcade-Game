using System;
using System.Drawing;
using GXPEngine;

public class MyGame : Game //MyGame is a Game
{
	private int _score = 0;
	private int _lives;

	private int _waveTimer;
	private bool _gameRunning;
	private int _currentLevel;
	private int _currentColumn;
	private Level level;
	private Station station;



	//initialize game here
	public MyGame () : base(1280, 960, false, false)
	{
		_lives = 5;
		_currentLevel = 1;
		_currentColumn = 0;
		_gameRunning = true;
		
		level = new Level();


		AddChild(level);

		HUD hud;
		hud = new HUD();
		AddChild(hud);


	}


	public void CallBulletSpawn(float pX, float pY, int pState) 
	{
		level.CreateBullet(pX, pY, pState);
	
	}

	//update game here
	void Update ()
	{


		_waveTimer = _waveTimer - 1;
		if (_waveTimer <= 0) 
		{
			_waveTimer = 100;
		}

		if (_gameRunning == true && _waveTimer == 1)
		{
			level.CreateWave(_currentLevel, _currentColumn);
			_currentColumn = _currentColumn + 1;
		
		}

		Console.WriteLine(_waveTimer);

	}

	public void EndOfWave() 
	{
		_currentColumn = 0;
		_currentLevel = _currentLevel + 1;

		station = new Station();
		level.AddChild(station);

		_waveTimer = 300;
	}

	//system starts here
	static void Main() 
	{
		new MyGame().Start();
	}
}
