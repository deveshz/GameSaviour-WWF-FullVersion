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
    public class CreditsMenu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont text1;
        public bool cstate = false;
        public CreditsMenu(Game game)
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
            text1 = Game.Content.Load<SpriteFont>(@"Fonts\Snap");
            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.B) || ks.IsKeyDown(Keys.Escape))
            {
                cstate = true;
            }

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MidnightBlue);
            spriteBatch.Begin();
            spriteBatch.DrawString(text1, "  TEAM ZEPHYR",
new Vector2(570,  50), Color.LimeGreen, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, " CONCEPT",
new Vector2(150, 100), Color.GreenYellow, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "Vikas Kumar",
new Vector2(150, 130), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, " PROGRAMMERS : ",
new Vector2(150, 180), Color.GreenYellow, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "1. Anamika - Team Leader ",
new Vector2(150, 210), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "2. Devesh Kumar",
new Vector2(150, 240), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "3. Abhishek Azad",
new Vector2(150, 270), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, " DESIGNERS : ",
new Vector2(150, 320), Color.GreenYellow, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "1. Shruti Aryani  ",
new Vector2(150, 350), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "2. Manomita Mishra ",
new Vector2(150, 380), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "3. Prerana ",
new Vector2(150, 410), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, " TEAM MENTOR ",
new Vector2(150, 460), Color.GreenYellow, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, "Professor Niloy Bhattacharya and Devesh Kumar",
new Vector2(150, 490), Color.LightSteelBlue, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, " THIS WORK IS DEDICATED TO OUR PARENTS WHO UNDERSTAND US ",
new Vector2(130, 520), Color.GreenYellow, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.DrawString(text1, " Visit Us at : www.zephyr.tk ",
new Vector2(450, 600), Color.LimeGreen, 0, new Vector2(0, 0),
1, SpriteEffects.None, 1);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}