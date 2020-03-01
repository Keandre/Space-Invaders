using WMPLib;

namespace SpaceInvaders
{
    public class Sound
    {
        //create variables with sound
        public static WindowsMediaPlayer Music = new WindowsMediaPlayer(), SoundEffect = new WindowsMediaPlayer(), SoundEffect2 = new WindowsMediaPlayer();
        public static void ChangeMusicVolume(int Change)
        {
            //change music volume
            Music.settings.volume += Change;
        }
        public static void ChangeSoundVolume(int Change)
        {
            //change both sound volumes
            SoundEffect.settings.volume += Change;
            SoundEffect2.settings.volume += Change;
        }
        public static void ChangeMusicURL(string URL)
        {
            //change music
            Music.URL = URL;
        }
        public static void ChangeSoundURL(string URL)
        {
            //change sound
            SoundEffect.URL = URL;
        }
        public static int MusicVolume()
        {
            //store music volume
            return Music.settings.volume;
        }
        public static int SoundVolume()
        {
            //store sound volume
            return SoundEffect.settings.volume;
        }
        public static void PlayMusic()
        {
            //play music
            Music.controls.play();
        }
        public static void StopMusic()
        {
            //stop music
            Music.controls.stop();
        }
        public static void PlaySound()
        {
            //play sound effect
            SoundEffect.controls.play();
        }
        public static void StopSound()
        {
            //stop sound effect
            SoundEffect.controls.play();
        }
        public static void PlaySound2()
        {
            //play second sound effect
            SoundEffect2.controls.play();
        }
        public static void StopSound2()
        {
            //stop second sound effect
            SoundEffect2.controls.play();
        }
        public static void ChangeSound2URL(string URL)
        {
            //change sound
            SoundEffect2.URL = URL;
        }
    }
}
