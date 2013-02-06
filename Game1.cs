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

namespace CaptureTheCutes
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D _brownBlockArt;
        private Texture2D _doorTallClosedArt;
        private Texture2D _roofEastArt;
        private Texture2D _roofWestArt;
        private Texture2D _roofNorthArt;
        private Texture2D _roofSouthArt;
        private Texture2D _roofNorthEastArt;
        private Texture2D _roofNorthWestArt;
        private Texture2D _roofSouthEastArt;
        private Texture2D _roofSouthWestArt;
        private Texture2D _stoneBlockArt;
        private Texture2D _wallBlockTallArt;
        private Texture2D _windowTallArt;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Window.Title = "Capture The Cutes!";
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

            _brownBlockArt = Content.Load<Texture2D>("PlanetCute PNG//Brown Block");
            _doorTallClosedArt = Content.Load<Texture2D>("PlanetCute PNG//Door Tall Closed");
            _roofEastArt = Content.Load<Texture2D>("PlanetCute PNG//Roof East");
            _roofWestArt = Content.Load<Texture2D>("PlanetCute PNG//Roof West");
            _roofNorthArt = Content.Load<Texture2D>("PlanetCute PNG//Roof North");
            _roofSouthArt = Content.Load<Texture2D>("PlanetCute PNG//Roof South");
            _roofNorthEastArt = Content.Load<Texture2D>("PlanetCute PNG//Roof North East");
            _roofNorthWestArt = Content.Load<Texture2D>("PlanetCute PNG//Roof North West");
            _roofSouthEastArt = Content.Load<Texture2D>("PlanetCute PNG//Roof South East");
            _roofSouthWestArt = Content.Load<Texture2D>("PlanetCute PNG//Roof South West");
            _stoneBlockArt = Content.Load<Texture2D>("PlanetCute PNG//Stone Block");
            _wallBlockTallArt = Content.Load<Texture2D>("PlanetCute PNG//Wall Block Tall");
            _windowTallArt = Content.Load<Texture2D>("PlanetCute PNG//Window Tall");
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
            drawLine1();
            drawLine2();
            drawLine5();
            drawLine4();
            drawLine3();
            spriteBatch.End();

            base.Draw(gameTime);
         }

        //Line 1
        private void drawLine1()
        {
        int topRoofHeightOffset = Window.ClientBounds.Height - _roofNorthArt.Bounds.Height - _stoneBlockArt.Bounds.Height - _roofSouthArt.Bounds.Height - 22;
        int topRoofWidthOffset = _roofNorthWestArt.Bounds.Width;
        spriteBatch.Draw(_roofNorthWestArt, new Rectangle(0,topRoofHeightOffset, _roofNorthWestArt.Width, _roofNorthWestArt.Height), Color.White);
        for (int i = 1; i <= 5; i++)
        {
            spriteBatch.Draw(_roofNorthArt, new Rectangle(topRoofWidthOffset,topRoofHeightOffset, _roofNorthArt.Width, _roofNorthArt.Height), Color.White);
            topRoofWidthOffset += _roofNorthArt.Bounds.Width;
        }
        spriteBatch.Draw(_roofNorthEastArt, new Rectangle(topRoofWidthOffset,topRoofHeightOffset, _roofNorthEastArt.Width, _roofNorthEastArt.Height), Color.White);
        }

        //Line2
        private void drawLine2()
        {
        int middleRoofHeightOffset = Window.ClientBounds.Height - _brownBlockArt.Bounds.Height - _stoneBlockArt.Bounds.Height - 113;
        int middleRoofWidthOffset = _roofWestArt.Bounds.Width;
        spriteBatch.Draw(_roofWestArt, new Rectangle(0, middleRoofHeightOffset, _roofWestArt.Width, _roofWestArt.Height), Color.White);
        for (int i = 1; i <= 4; i++)
        {
            spriteBatch.Draw(_brownBlockArt, new Rectangle(middleRoofWidthOffset,middleRoofHeightOffset, _brownBlockArt.Bounds.Width, _brownBlockArt.Bounds.Height), Color.White);
            middleRoofWidthOffset += _brownBlockArt.Bounds.Width;
        }
        spriteBatch.Draw(_roofNorthArt, new Rectangle(middleRoofWidthOffset,middleRoofHeightOffset - 40, _roofNorthArt.Width, _roofNorthArt.Height), Color.White);
        spriteBatch.Draw(_roofEastArt, new Rectangle(middleRoofWidthOffset + _roofNorthArt.Bounds.Width,middleRoofHeightOffset, _roofEastArt.Width, _roofEastArt.Height), Color.White);
        }

        //Line 3
        private void drawLine3()
        {
        int lowerRoofHeightOffset = Window.ClientBounds.Height - _roofSouthArt.Bounds.Height - _stoneBlockArt.Bounds.Height - 30;
        int lowerRoofWidthOffset = _roofSouthWestArt.Bounds.Width;
        spriteBatch.Draw(_roofSouthWestArt, new Rectangle(0, lowerRoofHeightOffset, _roofSouthWestArt.Width, _roofSouthWestArt.Height), Color.White);
        for (int i = 1; i <= 4; i++)
        {
            spriteBatch.Draw(_roofSouthArt, new Rectangle(lowerRoofWidthOffset, lowerRoofHeightOffset, _roofSouthArt.Width, _roofSouthArt.Height), Color.White);
            lowerRoofWidthOffset += _roofSouthArt.Bounds.Width;
        }
        spriteBatch.Draw(_windowTallArt, new Rectangle(lowerRoofWidthOffset, lowerRoofHeightOffset, _windowTallArt.Width, _windowTallArt.Height), Color.White);
        spriteBatch.Draw(_roofSouthEastArt, new Rectangle(lowerRoofWidthOffset + _windowTallArt.Bounds.Width, lowerRoofHeightOffset, _roofSouthEastArt.Width, _roofSouthEastArt.Height), Color.White);
        }
            
        //Line 4
        private void drawLine4()
        {
        int wallHeightOffset = Window.ClientBounds.Height - _wallBlockTallArt.Bounds.Height - 117;
        int wallWidthOffset = 0;
        for (int i = 1; i <= 5; i++)
        {
            spriteBatch.Draw(_wallBlockTallArt, new Rectangle(wallWidthOffset,wallHeightOffset, _wallBlockTallArt.Width, _wallBlockTallArt.Height), Color.White);
            wallWidthOffset += _wallBlockTallArt.Bounds.Width;
        }
        spriteBatch.Draw(_doorTallClosedArt, new Rectangle(wallWidthOffset,wallHeightOffset + 20, _doorTallClosedArt.Width, _doorTallClosedArt.Height), Color.White);
        wallWidthOffset += _doorTallClosedArt.Bounds.Width;
        spriteBatch.Draw(_wallBlockTallArt, new Rectangle(wallWidthOffset,wallHeightOffset, _wallBlockTallArt.Width, _wallBlockTallArt.Height), Color.White);
        }

        //Line 5
        private void drawLine5()
        {
        int stoneBlockHeightOffset = Window.ClientBounds.Height - _stoneBlockArt.Bounds.Height;
        int stoneBlockWidthOffset = 0;
        for (int i = 1; i <= 7; i++)
        {
            spriteBatch.Draw(_stoneBlockArt, new Rectangle(stoneBlockWidthOffset, stoneBlockHeightOffset, _stoneBlockArt.Width, _stoneBlockArt.Height), Color.White);
            stoneBlockWidthOffset += _stoneBlockArt.Bounds.Width;
        }
        }
    }
}
