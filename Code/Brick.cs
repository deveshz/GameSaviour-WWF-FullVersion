using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Zephyr
{
    abstract class Brick
    {
        Texture2D textureImage;
        public Vector2 position;
        int millisecondsPerFrame;
        public float speed;
        public Point currentFrame;
        public Point sheetSize;
        public Point frameSize;
        const int defaultMillisecondsPerFrame = 100;
        public int keyValue { get; protected set; }


        public Rectangle collisionRect
        {
            get
            {
                return new Rectangle(
                    (int)position.X,
                    (int)position.Y, 50, 50
                   );
            }
        }

        public Brick(Texture2D textureImage, Vector2 position, float speed, Point frameSize, Point currentFrame, Point sheetSize)
            : this(textureImage, position, speed, frameSize, currentFrame,
            sheetSize, defaultMillisecondsPerFrame)
        {
        }

        public Brick(Texture2D textureImage, Vector2 position, float speed, Point frameSize, Point currentFrame, Point sheetSize,
        int millisecondsPerFrame)
        {
            this.textureImage = textureImage;
            this.position = position;
            this.speed = speed;
            this.frameSize = frameSize;
            this.currentFrame = currentFrame;
            this.sheetSize = sheetSize;
            this.millisecondsPerFrame = millisecondsPerFrame;

        }
        public abstract float direction
        {
            get;
        }


        public virtual void Update(GameTime gameTime, Rectangle clientBounds)
        {
            if (position.X < 350)
                position.X = 350;
            if (position.X > 750)
                position.X = 750;
            if (position.Y < 150)
                position.Y = 150;
            if (position.Y > 550)
                position.Y = 550;


        }
 public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draw the sprite
            spriteBatch.Draw(textureImage,
              
       position,
              new Rectangle(currentFrame.X * frameSize.X,
                  currentFrame.Y * frameSize.Y,
                  frameSize.X, frameSize.Y),
              Color.White, 0, Vector2.Zero,
              1f, SpriteEffects.None, 0);
        }
    }
}
