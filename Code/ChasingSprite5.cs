﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zephyr
{
    class ChasingSprite5 : Sprite
    {
        TrackManager5 trackManager5;

        public ChasingSprite5(Texture2D textureImage, Vector2 position,
Point frameSize, int collisionOffset, Point currentFrame,
Point sheetSize, Vector2 speed,
TrackManager5 trackManager5)
            : base(textureImage, position, frameSize, collisionOffset,
            currentFrame, sheetSize, speed)
        {
            this.trackManager5 = trackManager5;
        }

        public ChasingSprite5(Texture2D textureImage, Vector2 position,
        Point frameSize, int collisionOffset, Point currentFrame,
        Point sheetSize, Vector2 speed, int millisecondsPerFrame,
      TrackManager5 trackManager5)
            : base(textureImage, position, frameSize, collisionOffset,
            currentFrame, sheetSize, speed, millisecondsPerFrame)
        {
            this.trackManager5 = trackManager5;
        }

        public override Vector2 direction
        {
            get { return speed; }
        }
        public override void Update(GameTime gameTime, Rectangle clientBounds)
        {
            // First, move the sprite along its direction vector
            position += speed;
            // Use the player position to move the sprite closer in
            // the X and/or Y directions
            Vector2 player = trackManager5.GetPlayerPosition();

            // If player is moving vertically, chase horizontally
            if (speed.X == 0)
            {
                if (player.X < position.X)
                    position.X -= Math.Abs(speed.Y);
                else if (player.X > position.X)
                    position.X += Math.Abs(speed.Y);
            }
            // If player is moving horizontally, chase vertically
            if (speed.Y == 0)
            {
                if (player.Y < position.Y)
                    position.Y -= Math.Abs(speed.X);
                else if (player.Y > position.Y)
                    position.Y += Math.Abs(speed.X);
            }

            base.Update(gameTime, clientBounds);
        }

    }
}
