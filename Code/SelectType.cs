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
    public class SelectType : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont text;
   
     
        Texture2D background;
        Texture2D type1;
        Texture2D type2;
        public bool typetry = false;
        public bool typechampionship = false;


        Rectangle arrowRect;
        Rectangle type1Rect;
        Rectangle type2Rect;

        Vector2 arr_position;
        MouseState prevMouseState;

        Texture2D arrow;



        public SelectType(Game game)
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
            background = Game.Content.Load<Texture2D>(@"Images\background2");
            type1 = Game.Content.Load<Texture2D>(@"Images\try");

            type2 = Game.Content.Load<Texture2D>(@"Images\championship");
    

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
            type1Rect = new Rectangle(100, 85, 300, 250);
            type2Rect = new Rectangle(800, 380, 300,250);
  
            MouseState mouseState = Mouse.GetState();
            if (mouseState.X != prevMouseState.X ||
            mouseState.Y != prevMouseState.Y)
            {
                arr_position = new Vector2(mouseState.X, mouseState.Y);
                prevMouseState = mouseState;
            }
            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);

            KeyboardState aKeyboard = Keyboard.GetState();
            if (arrowRect.Intersects(type1Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                type1Rect.Inflate(5, 5);
                typetry = true;
               

            }
            else if (arrowRect.Intersects(type1Rect))
            {
                type1Rect.Inflate(5, 5);

            }
            if (arrowRect.Intersects(type2Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                type2Rect.Inflate(5, 5);
                typechampionship = true;
               

            }
            else if (arrowRect.Intersects(type2Rect))
            {
                type2Rect.Inflate(5, 5);


            }

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            // TODO: Add your update code here
            GraphicsDevice.Clear(Color.MidnightBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.DrawString(text, " SELECT YOUR GAME TYPE",
new Vector2(450, 50), Color.Orange, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, " ------------------------------ ",
new Vector2(450, 60), Color.Orange, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);

            spriteBatch.Draw(type1,type1Rect, Color.White);
            spriteBatch.Draw(type2,type2Rect, Color.White);
           if (arrowRect.Intersects(type1Rect))
            {
                type1Rect.Inflate(5, 5);
                spriteBatch.DrawString(text, " FOR BEGINNERS ",
 new Vector2(660, 120), Color.LimeGreen, 0, new Vector2(0, 0),
 1, SpriteEffects.None, 1);
                spriteBatch.DrawString(text, " Select a goal,you want to achieve and hold complete",
  new Vector2(500, 145), Color.White, 0, new Vector2(0, 0),
  1, SpriteEffects.None, 1);
                spriteBatch.DrawString(text, " proficiency before trying the champinship mode",
  new Vector2(500, 170), Color.White, 0, new Vector2(0, 0),
  1, SpriteEffects.None, 1);


            }
                 else if (arrowRect.Intersects(type2Rect))
            {
                type2Rect.Inflate(5, 5);
                spriteBatch.DrawString(text, " FOR EXPERTS ",
new Vector2(250, 420), Color.LightSeaGreen, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
                spriteBatch.DrawString(text, " Ready to save the world in a single go!",
  new Vector2(160, 445), Color.White, 0, new Vector2(0, 0),
  1, SpriteEffects.None, 1);
                spriteBatch.DrawString(text, "Hold your Breadth & get ready to save the world.",
  new Vector2(100, 470), Color.White, 0, new Vector2(0, 0),
  1, SpriteEffects.None, 1);


            }

            spriteBatch.Draw(arrow, arrowRect, Color.White);

            spriteBatch.End();


            base.Draw(gameTime);
        }

    }
}