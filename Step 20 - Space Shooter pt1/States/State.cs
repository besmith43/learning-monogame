﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Step_20___Space_Shooter_pt1.States
{
    public abstract class State
    {
        protected Game1 _game;

        protected ContentManager _content;

        public State(Game1 game, ContentManager content)
        {
            _game = game;

            _content = content;
        }

        public abstract void LoadContent();

        public abstract void Update(GameTime gameTime);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
