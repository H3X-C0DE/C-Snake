using System;
using System.Media;

namespace C_Snake
{
    public class Sounds
    {
       
        private SoundPlayer LoadSound(string fileName)
        {
            return new SoundPlayer($"Assets/{fileName}");
        }
        private SoundPlayer pointPlayer;
        private SoundPlayer deathPlayer;
        public Sounds()
        {
            pointPlayer = LoadSound("PointSound.wav");
            deathPlayer = LoadSound("DeathSound.wav");
        }

        

        public void PlayPointSound()
        {
            pointPlayer.Play();
        }

        public void PlayDeathSound()
        {
            deathPlayer.Play();
        }
     

        public void Dispose()
        {
            pointPlayer.Dispose();
            deathPlayer.Dispose();

        }
    }
}
