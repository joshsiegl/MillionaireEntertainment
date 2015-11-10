using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework; 

namespace MonoGameSample.MillionaireEntertainment
{
    public class Animation
    {
        private Vector2 TextureLocation;
        private int SpriteWidth;
        private int SpriteHeight;
        private bool IsLooping;
        public int FrameCount;
        private float Interval;
        private float Timer;
        public int CurrentFrame = 0;

        private Rectangle sourcerect;
        public Rectangle SourceRect
        {
            get { return sourcerect; }
        }

        public Animation(Vector2 texturelocation, int spritewidth, int spriteheight, int framecount,
            bool islooping, float fps)
        {
            this.TextureLocation = texturelocation;
            this.SpriteWidth = spritewidth;
            this.SpriteHeight = spriteheight;
            this.FrameCount = framecount;
            this.IsLooping = islooping;
            this.Interval = 1000f / fps;

            sourcerect = new Rectangle((int)TextureLocation.X + SpriteWidth * CurrentFrame, (int)TextureLocation.Y,
                SpriteWidth, SpriteHeight);
        }
        public void UpdateSpriteSheet(GameTime gametime)
        {
            Timer += (float)gametime.ElapsedGameTime.TotalMilliseconds;
            if (Timer > Interval)
            {
                CurrentFrame++;
                if (IsLooping)
                {
                    if (CurrentFrame > FrameCount - 1)
                    {
                        CurrentFrame = 0;
                    }
                }
                if (!IsLooping)
                {
                    if (CurrentFrame > FrameCount - 1)
                    {
                        CurrentFrame = FrameCount - 1;
                    }
                }
                Timer = 0f;

            }
            sourcerect = new Rectangle((int)TextureLocation.X + SpriteWidth * CurrentFrame, (int)TextureLocation.Y,
                SpriteWidth, SpriteHeight);
        }
    }
}
