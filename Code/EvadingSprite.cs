﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Zephyr
{
    class EvadingSprite: Sprite
    {
        TrackManager trackManager;
        
        float evasionSpeedModifier;
        int evasionRange;
        bool evade = false;

        public EvadingSprite(Texture2D textureImage, Vector2 position,
        Point frameSize, int collisionOffset, Point currentFrame,
        Point sheetSize, Vector2 speed,
        TrackManager trackManager, float evasionSpeedModifier,
        int evasionRange)
            : base(textureImage, position, frameSize, collisionOffset,
            currentFrame, sheetSize, speed)
        {
            this.trackManager = trackManager;
            this.evasionSpeedModifier = evasionSpeedModifier;
            this.evasionRange = evasionRange;
        }
        public EvadingSprite(Texture2D textureImage, Vector2 position,
        Point frameSize, int collisionOffset, Point currentFrame,
        Point sheetSize, Vector2 speed, int millisecondsPerFrame,
         TrackManager trackManager,
        float evasionSpeedModifier, int evasionRange)
            : base(textureImage, position, frameSize, collisionOffset,
            currentFrame, sheetSize, speed, millisecondsPerFrame)
        {
            this.trackManager = trackManager;
            this.evasionSpeedModifier = evasionSpeedModifier;
            this.evasionRange = evasionRange;
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
            Vector2 player = trackManager.GetPlayerPosition();
            if (evade)
            {
                // Move away from the player horizontally
                if (player.X < position.X)
                    position.X += Math.Abs(speed.Y);
                else if (player.X > position.X)
                    position.X -= Math.Abs(speed.Y);
                // Move away from the player vertically
                if (player.Y < position.Y)
                    position.Y += Math.Abs(speed.X);
                else if (player.Y > position.Y)
                    position.Y -= Math.Abs(speed.X);


            }
            else
            {
                if (Vector2.Distance(position, player) < evasionRange)
                {
                    // Player is within evasion range,
                    // reverse direction and modify speed
                    speed *= -evasionSpeedModifier;
                    evade = true;
                }
            }

  
            base.Update(gameTime, clientBounds);
        }
    }
}
