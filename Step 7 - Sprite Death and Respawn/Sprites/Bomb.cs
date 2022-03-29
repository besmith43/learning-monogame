﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Step_7___Sprite_Death_and_Respawn
{

	public class Bomb : Sprite
	{
		public Bomb(Texture2D texture) : base(texture)
		{
			Position = new Vector2(Game1.Random.Next(0, Game1.ScreenWidth - _texture.Width), -_texture.Height);
			Speed = Game1.Random.Next(3, 10);
		}

		public override void Update(GameTime gameTime, List<Sprite> sprites)
		{
			Position.Y += Speed;

			if (Rectangle.Bottom >= Game1.ScreenHeight)
			{
				IsRemoved = true;
			}
		}
	}
}
