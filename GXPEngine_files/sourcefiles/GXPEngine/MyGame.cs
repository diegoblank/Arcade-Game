using System;
using System.Drawing;
using GXPEngine;

public class MyGame : Game //MyGame is a Game
{
	private int _score = 0;

	private int _waveTimer;
	private bool _gameRunning;
	private int _currentLevel;
	private int _currentColumn;
	private Level level;



	//initialize game here
	public MyGame () : base(1280, 960, false, false)
	{

<<<<<<< HEAD
		Level level = new Level();
=======
		_currentLevel = 1;
		_currentColumn = 0;
		_gameRunning = true;
		
		level = new Level();


>>>>>>> bc63df55de70eeffdbc2b607622d3550eaa049ce
		AddChild(level);

		HUD hud;
		hud = new HUD();
		AddChild(hud);

	}


	public void AddScore() 
	{
		_score = _score + 1;
	}

	//update game here
	void Update ()
	{


		_waveTimer = _waveTimer - 1;
		if (_waveTimer <= 0) 
		{
			_waveTimer = 200;
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
		_waveTimer = 600;
	}

	//system starts here
	static void Main() 
	{
		new MyGame().Start();
	}
}
