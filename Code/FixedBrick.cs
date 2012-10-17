using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Zephyr
{
    class FixedBrick : Brick
    {
        public FixedBrick(Texture2D textureImage, Vector2 position, float speed, Point frameSize, Point currentFrame, Point sheetSize)
            : base(textureImage, position, speed, frameSize, currentFrame, sheetSize)
        {
        }

        public FixedBrick(Texture2D textureImage, Vector2 position, float speed, Point frameSize, Point currentFrame, Point sheetSize, int millisecondsPerFrame)
            : base(textureImage, position, speed, frameSize, currentFrame, sheetSize, millisecondsPerFrame)
        {
        }
        public override float direction
        {
            get { return speed; }
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds)
        {


            base.Update(gameTime, clientBounds);
        }

    }
}
