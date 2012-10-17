using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Zephyr
{
    class SaviourBrick : Brick
    {
        public SaviourBrick(Texture2D textureImage, Vector2 position, float speed, Point frameSize, Point currentFrame, Point sheetSize)
            : base(textureImage, position, speed, frameSize, currentFrame, sheetSize)
        {
        }

        public SaviourBrick(Texture2D textureImage, Vector2 position, float speed, Point frameSize, Point currentFrame, Point sheetSize, int millisecondsPerFrame)
            : base(textureImage, position, speed, frameSize, currentFrame, sheetSize, millisecondsPerFrame)
        {
        }
        public override float direction
        {
            get { return speed; }
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                if (currentFrame.X == 0)
                {
                    position.X = position.X - 50;
                    keyValue = +1;
                }
                else
                    currentFrame.X = 0;


            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                if (currentFrame.X == 3)
                    position.X = position.X + 50;

                else
                    currentFrame.X = 3;
            }

            else if (keyboardState.IsKeyDown(Keys.Up))
            {
                if (currentFrame.X == 1)

                    position.Y = position.Y - 50;

                else
                    currentFrame.X = 1;
            }

            else if (keyboardState.IsKeyDown(Keys.Down))
            {
                if (currentFrame.X == 2)

                    position.Y = position.Y + 50;

                else
                    currentFrame.X = 2;

            }

            base.Update(gameTime, clientBounds);
        }

    }
}
