using System;
using System.Drawing;
using GXPEngine;

public class MyGame : Game //MyGame is a Game
{
	private int _score = 0;
	private int _lives;

	//initialize game here
	public MyGame () : base(1280, 960, false, false)
	{


		Level level = new Level();
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
		
	}


	//system starts here
	static void Main() 
	{
		new MyGame().Start();
	}
}
