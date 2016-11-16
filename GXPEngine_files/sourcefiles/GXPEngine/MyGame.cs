using System;
using System.Drawing;
using GXPEngine;

public class MyGame : Game //MyGame is a Game
{


	//initialize game here
	public MyGame () : base(1280, 960, false, false)
	{
		
		Level level = new Level();
		AddChild(level);

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
