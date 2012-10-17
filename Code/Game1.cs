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
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
       public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public Random rnd { get; private set; }
        AudioEngine audioEngine;
        WaveBank waveBank;
        SoundBank soundBank;
        Cue trackCue;
        Cue trackCue1;
        public int chances{ get; set;}
        public int chances1 { get; set; }
        public int chances2 { get; set; }
        public int chances3 { get; set; }
        public int chances4 { get; set; }
        public int chances5 { get; set; }
        public int chances6 { get; set; }
        public int avataar { get; set; }
        
      
       
        enum GameState
        {
            Start,
            Menu,
            MenuEnter,
            MenuType,
            MenuGoal,
            Credits,
            Help,
            InGame1,
            InGame11,
            InGame2,
            InGame21,
            InGame3,
            InGame31,
            InGame4,
            InGame41,
            InGame5,
            InGame51,
            InGame6,
            InGame61,
            InGame7,
            InGame71,
            InGame8,
            InGame81,
            InGame9,
            InGame91,
            InGameTen,
            InGameTen1,
            InGameEleven,
            InGameEleven1,
            GameOver
        };
        GameState currentGameState = GameState.Start;

        SpriteManager spriteManager;
        SpriteManager1 spriteManager1;
        SpriteManager2 spriteManager2;
        SpriteManager3 spriteManager3;
        SpriteManager4 spriteManager4;
        SpriteManager5 spriteManager5;
        SpriteManager6 spriteManager6;
        SpriteManager7 spriteManager7;
        SpriteManager8 spriteManager8;
        SpriteManager9 spriteManager9;
        SpriteManager10 spriteManager10;
        TitleMenu titleMenu;
        SelectMenu selectMenu;
        CreditsMenu creditsMenu;
        TrackManager trackManager;
        TrackManager1 trackManager1;
        TrackManager2 trackManager2;
        TrackManager3 trackManager3;
        TrackManager4 trackManager4;
        TrackManager5 trackManager5;
        TrackManager6 trackManager6;
        TrackManager7 trackManager7;
        TrackManager8 trackManager8;
        TrackManager9 trackManager9;
        TrackManager10 trackManager10;
        LooseMenu looseMenu;
        Select enter;
        SelectType selectType;
        SelectGoal selectGoal;
        HelpMenu helpMenu;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 700;
            TargetElapsedTime = new TimeSpan(0, 0, 0, 0, 150);
            rnd = new Random();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
           
            spriteManager = new SpriteManager(this);
            Components.Add(spriteManager);
            spriteManager1 = new SpriteManager1(this);
            Components.Add(spriteManager1);
            spriteManager2 = new SpriteManager2(this);
            Components.Add(spriteManager2);
            spriteManager3 = new SpriteManager3(this);
            Components.Add(spriteManager3);
            spriteManager4 = new SpriteManager4(this);
            Components.Add(spriteManager4);
            spriteManager5 = new SpriteManager5(this);
            Components.Add(spriteManager5);
            spriteManager6 = new SpriteManager6(this);
            Components.Add(spriteManager6);
            spriteManager7 = new SpriteManager7(this);
            Components.Add(spriteManager7);
            spriteManager8 = new SpriteManager8(this);
            Components.Add(spriteManager8);
            spriteManager9 = new SpriteManager9(this);
            Components.Add(spriteManager9);
            spriteManager10 = new SpriteManager10(this);
            Components.Add(spriteManager10);

            titleMenu = new TitleMenu(this);
            Components.Add(titleMenu);
            selectMenu = new SelectMenu(this);
            Components.Add(selectMenu);
           creditsMenu = new CreditsMenu(this);
           Components.Add(creditsMenu);

           trackManager = new TrackManager(this);
           Components.Add(trackManager);
           trackManager1 = new TrackManager1(this);
           Components.Add(trackManager1);
           trackManager2 = new TrackManager2(this);
           Components.Add(trackManager2);
           trackManager3 = new TrackManager3(this);
           Components.Add(trackManager3);
           trackManager4 = new TrackManager4(this);
           Components.Add(trackManager4);
           trackManager5 = new TrackManager5(this);
           Components.Add(trackManager5);
           trackManager6 = new TrackManager6(this);
           Components.Add(trackManager6);
           trackManager7 = new TrackManager7(this);
           Components.Add(trackManager7);
           trackManager8 = new TrackManager8(this);
           Components.Add(trackManager8);
           trackManager9 = new TrackManager9(this);
           Components.Add(trackManager9);
           trackManager10 = new TrackManager10(this);
           Components.Add(trackManager10);

           looseMenu = new LooseMenu(this);
           Components.Add(looseMenu);
           enter = new Select(this);
           Components.Add(enter);
           selectType = new SelectType(this);
           Components.Add(selectType);
           selectGoal = new SelectGoal(this);
           Components.Add(selectGoal);
           helpMenu = new HelpMenu(this);
           Components.Add(helpMenu);
 
 

           selectMenu.Enabled = false;
            selectMenu.Visible = false;
            titleMenu.Enabled = false;
            titleMenu.Visible = false;
            //------------------------------
            spriteManager.Enabled = false;
            spriteManager.Visible = false;
            spriteManager1.Enabled = false;
            spriteManager1.Visible = false;
            spriteManager2.Enabled = false;
            spriteManager2.Visible = false;
            spriteManager3.Enabled = false;
            spriteManager3.Visible = false;
            spriteManager4.Enabled = false;
            spriteManager4.Visible = false;
            spriteManager5.Enabled = false;
            spriteManager5.Visible = false;
            spriteManager6.Enabled = false;
            spriteManager6.Visible = false;
            spriteManager7.Enabled = false;
            spriteManager7.Visible = false;
            spriteManager8.Enabled = false;
            spriteManager8.Visible = false;
            spriteManager9.Enabled = false;
            spriteManager9.Visible = false;
            spriteManager10.Enabled = false;
            spriteManager10.Visible = false;
            //----------------------
            creditsMenu.Enabled = false;
            creditsMenu.Visible = false;
            //--------------------------------
            trackManager.Enabled = false;
            trackManager.Visible = false;
            trackManager1.Enabled = false;
            trackManager1.Visible = false;
            trackManager2.Enabled = false;
            trackManager2.Visible = false;
            trackManager3.Enabled = false;
            trackManager3.Visible = false;
            trackManager4.Enabled = false;
            trackManager4.Visible = false;
            trackManager5.Enabled = false;
            trackManager5.Visible = false;
            trackManager6.Enabled = false;
            trackManager6.Visible = false;
            trackManager7.Enabled = false;
            trackManager7.Visible = false;
            trackManager8.Enabled = false;
            trackManager8.Visible = false;
            trackManager9.Enabled = false;
            trackManager9.Visible = false;
            trackManager10.Enabled = false;
            trackManager10.Visible = false;
            //----------------------------------
            looseMenu.Visible = false;
            looseMenu.Enabled = false;
            helpMenu.Visible = false;
            helpMenu.Enabled = false;
            enter.Visible = false;
            enter.Enabled = false;
            selectType.Enabled = false;
            selectType.Visible = false;
            selectGoal.Enabled = false;
            selectGoal.Visible = false;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            audioEngine = new AudioEngine(@"Content\Audio\GameAudio.xgs");
            waveBank = new WaveBank(audioEngine, @"Content\Audio\Wave Bank.xwb");
            soundBank = new SoundBank(audioEngine, @"Content\Audio\Sound Bank.xsb");
            trackCue1 = soundBank.GetCue("track");
            trackCue = soundBank.GetCue("start");
            trackCue.Play();
            trackCue1.Play();
            
           


            
            
          
          
            //saviour = Content.Load<Texture2D>(@"Images\saviour");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            switch (currentGameState)
            {
                case GameState.Start:
                    break;
                case GameState.Menu:
                    break;
                case GameState.MenuEnter:
                    break;
                case GameState.MenuType:
                    break;
                case GameState.MenuGoal:
                    break;
                case GameState.Credits:
                    break;
                case GameState.Help:
                    break;
                case GameState.InGame1:
                    break;
                case GameState.InGame11:
                    break;
                case GameState.InGame2:
                    break;
                case GameState.InGame21:
                    break;
                case GameState.InGame3:
                    break;
                case GameState.InGame31:
                    break;
                case GameState.InGame4:
                    break;
                case GameState.InGame41:
                    break;
                case GameState.InGame5:
                    break;
                case GameState.InGame51:
                    break;
                case GameState.InGame6:
                    break;
                case GameState.InGame61:
                    break;
                case GameState.InGame7:
                    break;
                case GameState.InGame71:
                    break;
                case GameState.InGame8:
                    break;
                case GameState.InGame81:
                    break;
                case GameState.InGame9:
                    break;
                case GameState.InGame91:
                    break;
                case GameState.InGameTen:
                    break;
                case GameState.InGameTen1:
                    break;
                case GameState.InGameEleven:
                    break;
                case GameState.InGameEleven1:
                    break;
                case GameState.GameOver:
                    break;
            }
            chances = trackManager.mdg8_rep + trackManager1.mdg8_rep;
            chances1 = trackManager2.mdg8_rep ;
            chances2 = trackManager3.mdg8_rep + trackManager4.mdg8_rep;
            chances3 = trackManager5.mdg8_rep;
            chances4 = trackManager6.mdg8_rep + trackManager7.mdg8_rep;
            chances5 = trackManager8.mdg8_rep;
            chances6 = trackManager9.mdg8_rep + trackManager10.mdg8_rep;
            avataar = enter.saviourno;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            

            //If the Fade delays has dropped below zero, then it is time to 
            //fade in/fade out the image a little bit more.
           
           
         
           

          
           
            // TODO: Add your update logic here
            audioEngine.Update();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            switch (currentGameState)
            {
                case GameState.Start:

                    titleMenu.Enabled = true;
                    titleMenu.Visible = true;
                    if (titleMenu.g1state == true)
                    {
                        currentGameState = GameState.Menu;
                        selectMenu.Enabled = true;
                        selectMenu.Visible = true;
                        titleMenu.Enabled = false;
                        titleMenu.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                        
                        trackCue1.Pause();
                       
                       
                    }
                    break;

                case GameState.Menu:
                    
                    if (selectMenu.g2state == true)
                    {
                     currentGameState = GameState.MenuEnter;
                    
                     selectMenu.Enabled = false;
                     selectMenu.Visible = false;
                     creditsMenu.Enabled = false;
                     creditsMenu.Visible = false;
                     selectMenu.g2state = false;
                     spriteManager.Enabled = false;
                     spriteManager.Visible = false;
                     spriteManager1.Enabled = false;
                     spriteManager1.Visible = false;
                     spriteManager2.Enabled = false;
                     spriteManager2.Visible = false;
                     spriteManager3.Enabled = false;
                     spriteManager3.Visible = false;
                     spriteManager4.Enabled = false;
                     spriteManager4.Visible = false;
                     spriteManager5.Enabled = false;
                     spriteManager5.Visible = false;
                     spriteManager6.Enabled = false;
                     spriteManager6.Visible = false;
                     spriteManager7.Enabled = false;
                     spriteManager7.Visible = false;
                     spriteManager8.Enabled = false;
                     spriteManager8.Visible = false;
                     spriteManager9.Enabled = false;
                     spriteManager9.Visible = false;
                     spriteManager10.Enabled = false;
                     spriteManager10.Visible = false;
                     trackManager.Enabled = false;
                     trackManager.Visible = false;
                     trackManager1.Enabled = false;
                     trackManager1.Visible = false;
                     trackManager2.Enabled = false;
                     trackManager2.Visible = false;
                     trackManager3.Enabled = false;
                     trackManager3.Visible = false;
                     trackManager4.Enabled = false;
                     trackManager4.Visible = false;
                     trackManager5.Enabled = false;
                     trackManager5.Visible = false;
                     trackManager6.Enabled = false;
                     trackManager6.Visible = false;
                     trackManager7.Enabled = false;
                     trackManager7.Visible = false;
                     trackManager8.Enabled = false;
                     trackManager8.Visible = false;
                     trackManager9.Enabled = false;
                     trackManager9.Visible = false;
                     trackManager10.Enabled = false;
                     trackManager10.Visible = false;
           
                     looseMenu.Visible = false;
                     looseMenu.Enabled = false;
                     enter.Visible = true;
                     enter.Enabled = true;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                     trackCue.Pause();
                     trackCue1.Resume();
                   
                     
                       
            
                    }
                    else if (selectMenu.g4state == true)
                    {
                        currentGameState = GameState.Credits;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        selectMenu.g4state = false;
                        creditsMenu.Enabled = true;
                        creditsMenu.Visible = true;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        
                    }
                    else if (selectMenu.helpstate == true)
                    {
                        currentGameState = GameState.Help;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        selectMenu.g4state = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        helpMenu.Visible = true;
                        helpMenu.Enabled = true;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }


                    else if (selectMenu.g3state == true)

                        Exit();
                    break;
                case GameState.MenuEnter:
                    if (enter.enter)
                    {
                        currentGameState = GameState.MenuType;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        selectType.Enabled = true;
                        selectType.Visible = true;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    
                    break;
                case GameState.MenuType:
                    if (selectType.typechampionship)
                    {
                        currentGameState = GameState.InGame1;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Visible = true;
                        trackManager.Enabled = true;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled =false;
                        selectGoal.Visible =false;
                    }
                    else if (selectType.typetry)
                    {
                        currentGameState = GameState.MenuGoal;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = true;
                        selectGoal.Visible = true;
                    }

                    break;
                case GameState.MenuGoal:
                    if (selectGoal.level1)
                    {
                        currentGameState = GameState.InGame1;
                        trackManager.Visible = true;
                        trackManager.Enabled = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    else if (selectGoal.level2)
                    {
                        currentGameState = GameState.InGame3;
                        //-------------------------------
                        trackManager2.Visible = true;
                        trackManager2.Enabled = true;
                        //-------------------------------
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                   
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible =false;
                    }
                    else if (selectGoal.level3)
                    {
                        currentGameState = GameState.InGame4;
                        trackManager3.Visible = true;
                        trackManager3.Enabled = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    else if (selectGoal.level4)
                    {
                        currentGameState = GameState.InGame6;
                        trackManager5.Enabled = true;
                        trackManager5.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                   
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    else if (selectGoal.level5)
                    {
                        currentGameState = GameState.InGame7;
                        trackManager6.Enabled = true;
                        trackManager6.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;

                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    else if (selectGoal.level6)
                    {
                        currentGameState = GameState.InGame9;
                        trackManager8.Enabled = true;
                        trackManager8.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;

                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    else if (selectGoal.level7)
                    {
                        currentGameState = GameState.InGameTen;
                        trackManager9.Enabled = true;
                        trackManager9.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;

                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        enter.Visible = false;
                        enter.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;
                        selectType.Enabled = false;
                        selectType.Visible = false;
                        selectGoal.Enabled = false;
                        selectGoal.Visible = false;
                    }
                    break;
                case GameState.InGame1:
                    if (trackManager.isOver)
                    {
                        currentGameState = GameState.InGame11;
                        trackManager1.Visible = true;
                        trackManager1.Enabled = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                       
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        
                        trackCue.Pause();
                        trackCue1.Resume();
                       
                    }
                    else if (trackManager.loose)
                    {
                        currentGameState = GameState.GameOver;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;

                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager2.Visible = false;
                        spriteManager2.Enabled = false;

                    }
                    break;
                case GameState.InGame11:
                    if (trackManager1.isOver)
                    {
                        currentGameState = GameState.InGame2;
                        spriteManager.Enabled = true;
                        spriteManager.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    else if (trackManager1.loose)
                    {
                        currentGameState = GameState.GameOver;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;

                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;

                    }
                    break;
                case GameState.InGame2:
                    if (spriteManager.go == true)
                    {
                        currentGameState = GameState.InGame21;
                        spriteManager1.Enabled = true;
                        spriteManager1.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                    }
                    else if (spriteManager.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                    }
                    break;
                case GameState.InGame21:
                 if (spriteManager1.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                    }
                    else if (spriteManager1.level2)
                    {
                        currentGameState = GameState.InGame3;
                        trackManager2.Enabled = true;
                        trackManager2.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        
                    }
                        break;
                case GameState.InGame3:
                        if (trackManager2.isOver)
                        {
                            currentGameState = GameState.InGame31;
                            spriteManager2.Enabled = true;
                            spriteManager2.Visible = true;
                            spriteManager.Enabled = false;
                            spriteManager.Visible = false;
                            spriteManager1.Enabled = false;
                            spriteManager1.Visible = false;
                            spriteManager3.Enabled = false;
                            spriteManager3.Visible = false;
                            spriteManager4.Enabled = false;
                            spriteManager4.Visible = false;
                            spriteManager5.Enabled = false;
                            spriteManager5.Visible = false;
                            spriteManager6.Enabled = false;
                            spriteManager6.Visible = false;
                            spriteManager7.Enabled = false;
                            spriteManager7.Visible = false;
                            spriteManager8.Enabled = false;
                            spriteManager8.Visible = false;
                            spriteManager9.Enabled = false;
                            spriteManager9.Visible = false;
                            spriteManager10.Enabled = false;
                            spriteManager10.Visible = false;
                            selectMenu.Enabled = false;
                            selectMenu.Visible = false;
                            creditsMenu.Enabled = false;
                            creditsMenu.Visible = false;
                            helpMenu.Enabled = false;
                            helpMenu.Visible = false;
                            selectMenu.g2state = false;
                            looseMenu.Visible = false;
                            looseMenu.Enabled = false;
                            trackManager.Enabled = false;
                            trackManager.Visible = false;
                            trackManager1.Enabled = false;
                            trackManager1.Visible = false;
                            trackManager2.Enabled = false;
                            trackManager2.Visible = false;
                            trackManager3.Enabled = false;
                            trackManager3.Visible = false;
                            trackManager4.Enabled = false;
                            trackManager4.Visible = false;
                            trackManager5.Enabled = false;
                            trackManager5.Visible = false;
                            trackManager6.Enabled = false;
                            trackManager6.Visible = false;
                            trackManager7.Enabled = false;
                            trackManager7.Visible = false;
                            trackManager8.Enabled = false;
                            trackManager8.Visible = false;
                            trackManager9.Enabled = false;
                            trackManager9.Visible = false;
                            trackManager10.Enabled = false;
                            trackManager10.Visible = false;
                            
                            trackCue.Resume();
                            trackCue1.Pause();

                        }
                else if (trackManager2.loose)
                    {
                        currentGameState = GameState.GameOver;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        selectMenu.g2state = false;

                        trackManager.Visible = false;
                        trackManager.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;

                    }
                    break;

                case GameState.InGame31:

                 if (spriteManager2.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager2.level3)
                    {
                        currentGameState = GameState.InGame4;
                        trackManager3.Visible = true;
                        trackManager3.Enabled = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        
  
                    }
                    break;
                case GameState.InGame4:
                    
                 if (trackManager3.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                 else if (trackManager3.isOver)
                 {
                     currentGameState = GameState.InGame41;
                     trackManager4.Enabled = true;
                     trackManager4.Visible = true;
                     selectMenu.Enabled = false;
                     selectMenu.Visible = false;
                     creditsMenu.Enabled = false;
                     creditsMenu.Visible = false;
                     helpMenu.Enabled = false;
                     helpMenu.Visible = false;
                     selectMenu.g2state = false;
                     looseMenu.Visible = false;
                     looseMenu.Enabled = false;
                     trackManager.Enabled = false;
                     trackManager.Visible = false;
                     trackManager1.Enabled = false;
                     trackManager1.Visible = false;
                     trackManager2.Enabled = false;
                     trackManager2.Visible = false;
                     trackManager3.Enabled = false;
                     trackManager3.Visible = false;

                     trackManager5.Enabled = false;
                     trackManager5.Visible = false;
                     trackManager6.Enabled = false;
                     trackManager6.Visible = false;
                     trackManager7.Enabled = false;
                     trackManager7.Visible = false;
                     trackManager8.Enabled = false;
                     trackManager8.Visible = false;
                     trackManager9.Enabled = false;
                     trackManager9.Visible = false;
                     trackManager10.Enabled = false;
                     trackManager10.Visible = false;
                     spriteManager.Enabled = false;
                     spriteManager.Visible = false;
                     spriteManager1.Enabled = false;
                     spriteManager1.Visible = false;
                     spriteManager2.Enabled = false;
                     spriteManager2.Visible = false;
                     spriteManager3.Enabled = false;
                     spriteManager3.Visible = false;
                     spriteManager4.Enabled = false;
                     spriteManager4.Visible = false;
                     spriteManager5.Enabled = false;
                     spriteManager5.Visible = false;
                     spriteManager6.Enabled = false;
                     spriteManager6.Visible = false;
                     spriteManager7.Enabled = false;
                     spriteManager7.Visible = false;
                     spriteManager8.Enabled = false;
                     spriteManager8.Visible = false;
                     spriteManager9.Enabled = false;
                     spriteManager9.Visible = false;
                     spriteManager10.Enabled = false;
                     spriteManager10.Visible = false;
                     trackCue.Resume();
                     trackCue1.Pause();

                 }
                    break;
                case GameState.InGame41:

                    if (trackManager4.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager4.isOver)
                    {
                        currentGameState = GameState.InGame5;
                        spriteManager3.Enabled = true;
                        spriteManager3.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;

                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;
                case GameState.InGame5:

                    if (spriteManager3.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager3.go)
                    {
                        currentGameState = GameState.InGame51;
                        spriteManager4.Enabled = true;
                        spriteManager4.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;

                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
    

                case GameState.InGame51:

                    if (spriteManager4.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager4.go)
                    {
                        currentGameState = GameState.InGame6;
                        trackManager5.Enabled = true;
                        trackManager5.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;

                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
              
                case GameState.InGame6:

                    if (trackManager5.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager5.isOver)
                    {
                        currentGameState = GameState.InGame61;
                        spriteManager5.Enabled = true;
                        spriteManager5.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;

                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;
               

                case GameState.InGame61:

                    if (spriteManager5.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager5.go)
                    {
                        currentGameState = GameState.InGame7;
                        trackManager6.Enabled = true;
                        trackManager6.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;

                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
                //track
                case GameState.InGame7:

                    if (trackManager6.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager6.isOver)
                    {
                        currentGameState = GameState.InGame71;
                        trackManager7.Enabled = true;
                        trackManager7.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;

                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;
             
                case GameState.InGame71:

                    if (trackManager7.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager7.isOver)
                    {
                        currentGameState = GameState.InGame8;
                        spriteManager6.Enabled = true;
                        spriteManager6.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;

                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;

                case GameState.InGame8:

                    if (spriteManager6.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager6.go)
                    {
                        currentGameState = GameState.InGame81;
                        spriteManager7.Enabled = true;
                        spriteManager7.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;

                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
                //sprite

                case GameState.InGame81:

                    if (spriteManager7.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager7.go)
                    {
                        currentGameState = GameState.InGame9;
                        trackManager8.Enabled = true;
                        trackManager8.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;

                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
                //track
                case GameState.InGame9:

                    if (trackManager8.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager8.isOver)
                    {
                        currentGameState = GameState.InGame91;
                        spriteManager8.Enabled = true;
                        spriteManager8.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;

                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;
                //sprite

                case GameState.InGame91:

                    if (spriteManager8.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager8.go)
                    {
                        currentGameState = GameState.InGameTen;
                        trackManager9.Enabled = true;
                        trackManager9.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;

                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
                //track
                case GameState.InGameTen:

                    if (trackManager9.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager9.isOver)
                    {
                        currentGameState = GameState.InGameTen1;
                        trackManager10.Enabled = true;
                        trackManager10.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;

                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;
                //track
                case GameState.InGameTen1:

                    if (trackManager10.loose)
                    {
                        currentGameState = GameState.GameOver;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (trackManager10.isOver)
                    {
                        currentGameState = GameState.InGameEleven;
                        spriteManager9.Enabled = true;
                        spriteManager9.Visible = true;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        selectMenu.g2state = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;

                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        trackCue.Resume();
                        trackCue1.Pause();

                    }
                    break;
                //sprite

                case GameState.InGameEleven:

                    if (spriteManager9.loose)
                    {
                        currentGameState = GameState.GameOver;

                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager9.go)
                    {
                        currentGameState = GameState.InGameEleven1;
                        spriteManager10.Enabled = true;
                        spriteManager10.Visible = true;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;

                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;


                    }
                    break;
                //sprite

                case GameState.InGameEleven1:

                    if (spriteManager10.loose)
                    {
                        currentGameState = GameState.GameOver;

                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        spriteManager2.Enabled = false;
                        spriteManager2.Visible = false;
                        spriteManager3.Enabled = false;
                        spriteManager3.Visible = false;
                        spriteManager4.Enabled = false;
                        spriteManager4.Visible = false;
                        spriteManager5.Enabled = false;
                        spriteManager5.Visible = false;
                        spriteManager6.Enabled = false;
                        spriteManager6.Visible = false;
                        spriteManager7.Enabled = false;
                        spriteManager7.Visible = false;
                        spriteManager8.Enabled = false;
                        spriteManager8.Visible = false;
                        spriteManager9.Enabled = false;
                        spriteManager9.Visible = false;
                        spriteManager10.Enabled = false;
                        spriteManager10.Visible = false;
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        helpMenu.Enabled = false;
                        helpMenu.Visible = false;
                        looseMenu.Visible = true;
                        looseMenu.Enabled = true;
                        spriteManager.gstate = false;
                        selectMenu.Enabled = false;
                        selectMenu.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        trackManager2.Enabled = false;
                        trackManager2.Visible = false;
                        trackManager3.Enabled = false;
                        trackManager3.Visible = false;
                        trackManager4.Enabled = false;
                        trackManager4.Visible = false;
                        trackManager5.Enabled = false;
                        trackManager5.Visible = false;
                        trackManager6.Enabled = false;
                        trackManager6.Visible = false;
                        trackManager7.Enabled = false;
                        trackManager7.Visible = false;
                        trackManager8.Enabled = false;
                        trackManager8.Visible = false;
                        trackManager9.Enabled = false;
                        trackManager9.Visible = false;
                        trackManager10.Enabled = false;
                        trackManager10.Visible = false;
                    }
                    else if (spriteManager10.go)
                    {



                    }
                    break;
                case GameState.Credits:
                    
                    if (creditsMenu.cstate == true)
                    {
                        currentGameState = GameState.Menu;
                    
                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        creditsMenu.cstate = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        selectMenu.Enabled = true;
                        selectMenu.Visible = true;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                       
                        
                    }
                    break;
                case GameState.Help:

                    if (helpMenu.back == true)
                    {
                        currentGameState = GameState.Menu;

                        creditsMenu.Enabled = false;
                        creditsMenu.Visible = false;
                        spriteManager.Enabled = false;
                        spriteManager.Visible = false;
                        spriteManager1.Enabled = false;
                        spriteManager1.Visible = false;
                        trackManager.Enabled = false;
                        trackManager.Visible = false;
                        trackManager1.Enabled = false;
                        trackManager1.Visible = false;
                        helpMenu.back = false;
                        selectMenu.helpstate = false;
                        looseMenu.Visible = false;
                        looseMenu.Enabled = false;
                        selectMenu.Enabled = true;
                        selectMenu.Visible = true;
                        helpMenu.Visible = false;
                        helpMenu.Enabled = false;
                     
                     

                    }
                    break;
                
                // TODO: Add your drawing code here
                case GameState.GameOver:
                    looseMenu.Visible = true;
                    looseMenu.Enabled = true;
                    break;
            }
            base.Draw(gameTime);
        }

    }
}
