using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace Zephyr
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Select : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont text;
        public bool enter = false;
        public int saviourno;
        Texture2D saviour1;
        Texture2D saviour2;
        Texture2D saviour3;
        Texture2D saviour4;
        Texture2D background;

        Rectangle saviour1Rect;
        Rectangle saviour2Rect;
        Rectangle saviour3Rect;
        Rectangle saviour4Rect;

        Rectangle arrowRect;

        Vector2 arr_position;
        MouseState prevMouseState;

        Texture2D arrow;



        public Select(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            background = Game.Content.Load<Texture2D>(@"Images\background1");
            saviour1 = Game.Content.Load<Texture2D>(@"Images\saviour2big");
            saviour2 = Game.Content.Load<Texture2D>(@"Images\saviour3big");
            saviour3 = Game.Content.Load<Texture2D>(@"Images\saviour4big");
            saviour4 = Game.Content.Load<Texture2D>(@"Images\saviour1big");

            arrow = Game.Content.Load<Texture2D>(@"Images\arrow");
            text = Game.Content.Load<SpriteFont>(@"Fonts\Snap");
    
            base.LoadContent();
        }
        
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            saviour1Rect = new Rectangle(100, 70, 200, 300);
            saviour2Rect = new Rectangle(100, 390, 200, 300);
            saviour3Rect = new Rectangle(950, 70, 200, 300);
            saviour4Rect = new Rectangle(950, 390, 200, 300);
            MouseState mouseState = Mouse.GetState();
            if (mouseState.X != prevMouseState.X ||
            mouseState.Y != prevMouseState.Y)
            {
                arr_position = new Vector2(mouseState.X, mouseState.Y);
                prevMouseState = mouseState;
            }
            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);
       
            KeyboardState aKeyboard = Keyboard.GetState();
             if (arrowRect.Intersects(saviour1Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                saviour1Rect.Inflate(5,5);
                enter = true;
                saviourno = 1;

            }
             else if (arrowRect.Intersects(saviour1Rect))
            {
                saviour1Rect.Inflate(5,5);
               
            }
            if (arrowRect.Intersects(saviour2Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                saviour2Rect.Inflate(5,5);
                enter = true;
                saviourno = 2;
 

            }
            else  if (arrowRect.Intersects(saviour2Rect))
            {
               saviour2Rect.Inflate(5,5);

                
            }
            if (arrowRect.Intersects(saviour3Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                saviour3Rect.Inflate(5,5);
                enter = true;
                saviourno = 3;
            }

             else if (arrowRect.Intersects(saviour3Rect))
            {
               saviour3Rect.Inflate(5,5);
               
            }

            if (arrowRect.Intersects(saviour4Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {

                saviour4Rect.Inflate(5,5);
                enter = true;
                saviourno = 4;

            } 
            else if (arrowRect.Intersects(saviour4Rect))
            {
                saviour4Rect.Inflate(5,5);
            }
 

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            // TODO: Add your update code here
            GraphicsDevice.Clear(Color.MidnightBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.DrawString(text, " SELECT YOUR AVATAR",
new Vector2(450, 50), Color.Orange, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, " --------------------------- ",
new Vector2(450, 60), Color.Orange, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);

            spriteBatch.Draw(saviour1, saviour1Rect, Color.White);
            spriteBatch.Draw(saviour2, saviour2Rect, Color.White);
            spriteBatch.Draw(saviour3, saviour3Rect, Color.White);
            spriteBatch.Draw(saviour4, saviour4Rect, Color.White);
             if (arrowRect.Intersects(saviour1Rect))
            {
                saviour1Rect.Inflate(5,5);
                spriteBatch.DrawString(text, " I am Almen from South America ",
new Vector2(500, 300), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                saviour2Rect.Inflate(5, 5);
                spriteBatch.DrawString(text, "Give me a chance to save the world",
new Vector2(500, 350), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            }
            else if (arrowRect.Intersects(saviour2Rect))
            {
                saviour2Rect.Inflate(5,5);
                spriteBatch.DrawString(text, " Hi ! Me Chinipai from North America",
new Vector2(500, 300), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                saviour2Rect.Inflate(5, 5);
                spriteBatch.DrawString(text, "I wanna be Saviour",
new Vector2(550, 350), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            }
            else if (arrowRect.Intersects(saviour3Rect))
            {
                saviour3Rect.Inflate(5,5);
                spriteBatch.DrawString(text, "  Me Kungshi from Asia",
new Vector2(500, 300), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                saviour2Rect.Inflate(5, 5);
                spriteBatch.DrawString(text, " I will save the world for sure.",
new Vector2(500, 350), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            }
            else if (arrowRect.Intersects(saviour4Rect))
            {
                saviour4Rect.Inflate(5,5);
                spriteBatch.DrawString(text, "Hi ! I am Todo from Africa",
new Vector2(500, 300), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                saviour2Rect.Inflate(5, 5);
                spriteBatch.DrawString(text, "I 'll remove darkness from the world.",
new Vector2(480, 350), Color.Black, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            }
           
            spriteBatch.Draw(arrow, arrowRect, Color.White);

            spriteBatch.End();


            base.Draw(gameTime);
        }

    }
}