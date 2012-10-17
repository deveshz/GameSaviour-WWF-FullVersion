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
    public class SelectGoal : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont text;
        public bool level1 = false;
        public bool level2 = false;
        public bool level3 = false;
        public bool level4 = false;
        public bool level5 = false;
        public bool level6 = false;
        public bool level7 = false;

        
        Texture2D goal1;
        Texture2D goal2;
        Texture2D goal3;
        Texture2D goal4;
        Texture2D goal5;
        Texture2D goal6;
        Texture2D goal7;

        Texture2D background;

        Rectangle goal1Rect;
        Rectangle goal2Rect;
        Rectangle goal3Rect;
        Rectangle goal4Rect;
        Rectangle goal5Rect;
        Rectangle goal6Rect;
        Rectangle goal7Rect;

        Rectangle arrowRect;

        Vector2 arr_position;
        MouseState prevMouseState;

        Texture2D arrow;



        public SelectGoal(Game game)
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
            goal1 = Game.Content.Load<Texture2D>(@"Images\mdg1big");
            goal2 = Game.Content.Load<Texture2D>(@"Images\mdg2big");
            goal3 = Game.Content.Load<Texture2D>(@"Images\mdg3big");
            goal4 = Game.Content.Load<Texture2D>(@"Images\mdg4big");
            goal5 = Game.Content.Load<Texture2D>(@"Images\mdg5big");
            goal6 = Game.Content.Load<Texture2D>(@"Images\mdg6big");
            goal7 = Game.Content.Load<Texture2D>(@"Images\mdg7big");

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
            goal1Rect = new Rectangle(180, 200, 150, 150);
            goal2Rect = new Rectangle(510, 200, 150,150);
            goal3Rect = new Rectangle(840, 200, 150,150);
            goal4Rect = new Rectangle(120, 450, 150,150);
            goal5Rect = new Rectangle(390, 450, 150, 150);
            goal6Rect = new Rectangle(660, 450, 150, 150);
            goal7Rect = new Rectangle(930, 450, 150, 150);
            MouseState mouseState = Mouse.GetState();
            if (mouseState.X != prevMouseState.X ||
            mouseState.Y != prevMouseState.Y)
            {
                arr_position = new Vector2(mouseState.X, mouseState.Y);
                prevMouseState = mouseState;
            }
            arrowRect = new Rectangle((int)arr_position.X, (int)arr_position.Y, 32, 32);

            KeyboardState aKeyboard = Keyboard.GetState();
            if (arrowRect.Intersects(goal1Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                goal1Rect.Inflate(5, 5);
                level1 = true;
                

            }
            else if (arrowRect.Intersects(goal1Rect))
            {
                goal1Rect.Inflate(5, 5);

            }
            if (arrowRect.Intersects(goal2Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                goal2Rect.Inflate(5, 5);
                level2 = true;

            }
            else if (arrowRect.Intersects(goal2Rect))
            {
                goal2Rect.Inflate(5, 5);


            }
            if (arrowRect.Intersects(goal3Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {
                goal3Rect.Inflate(5, 5);
                level3 = true;
                
            }

            else if (arrowRect.Intersects(goal3Rect))
            {
                goal3Rect.Inflate(5, 5);

            }

            if (arrowRect.Intersects(goal4Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {

                goal4Rect.Inflate(5, 5);
                level4 = true;
                

            }
            else if (arrowRect.Intersects(goal4Rect))
            {
                goal4Rect.Inflate(5, 5);
            }
          
            if (arrowRect.Intersects(goal5Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {

                goal5Rect.Inflate(5, 5);
                level5 = true;


            }
            else if (arrowRect.Intersects(goal5Rect))
            {
                goal5Rect.Inflate(5, 5);

            }
            if (arrowRect.Intersects(goal6Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {

                goal6Rect.Inflate(5, 5);
                level6 = true;


            }
            else if (arrowRect.Intersects(goal6Rect))
            {
                goal6Rect.Inflate(5, 5);
            }
            if (arrowRect.Intersects(goal7Rect) && mouseState.LeftButton == ButtonState.Pressed)
            {

                goal7Rect.Inflate(5, 5);
                level7 = true;


            }
            else if (arrowRect.Intersects(goal7Rect))
            {
                goal7Rect.Inflate(5, 5);
            }


            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            // TODO: Add your update code here
            GraphicsDevice.Clear(Color.MidnightBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.DrawString(text, " SELECT THE GOAL",
new Vector2(450, 50), Color.Orange, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text, " ------------------------------ ",
new Vector2(450, 60), Color.Orange, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);

            spriteBatch.Draw(goal1, goal1Rect, Color.White);
            spriteBatch.Draw(goal2, goal2Rect, Color.White);
            spriteBatch.Draw(goal3, goal3Rect, Color.White);
            spriteBatch.Draw(goal4, goal4Rect, Color.White);
            spriteBatch.Draw(goal5, goal5Rect, Color.White);
            spriteBatch.Draw(goal6, goal6Rect, Color.White);
            spriteBatch.Draw(goal7, goal7Rect, Color.White);
            spriteBatch.Draw(arrow, arrowRect, Color.White);

            spriteBatch.End();


            base.Draw(gameTime);
        }

    }
}