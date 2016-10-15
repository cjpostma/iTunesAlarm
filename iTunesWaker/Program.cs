using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTunesLib;

namespace iTunesWaker
{
    class PlaylistStarter
    {
        private iTunesLib.IiTunes iTunesApp = new iTunesLib.iTunesApp();
        private int finalVolume = 50;
        private int secs = 30;
        static void Main(string[] args)
        {
            PlaylistStarter ps = new PlaylistStarter();
            ps.doIt();

        }

        private void doIt()
        {
            foreach (IITSource s in iTunesApp.Sources)
            {
                IITPlaylistCollection coll = s.Playlists;
                foreach (IITPlaylist pl in coll)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}", pl.GetType().ToString(), pl.Kind, pl.Name, pl.Tracks.Count);

                    if (pl.Tracks.Count > 0)
                    {
                        iTunesApp.SoundVolume = 0;
                        pl.Shuffle = true;
                        pl.PlayFirstTrack();
                        TurnUpVolume();
                    }

                }
            }

        }
        private void TurnUpVolume()
        {
            int numInterVal = secs / 2;
            int secondsDelay = 0;
            float increment = finalVolume / numInterVal;
            float volume = 0;
            while (volume < finalVolume)
            {
                volume = volume + increment;
                secondsDelay += 2;
                SetVolumeWithDelay(secondsDelay, (int)volume);
            }
            System.Threading.Thread.Sleep(35000);
        }

        private void SetVolumeWithDelay(int seconds, int volume)
        {
            Console.WriteLine("Seconds {0} - Volume {1}", seconds, volume);

            Task.Delay(seconds * 1000).ContinueWith(t =>      iTunesApp.SoundVolume = volume );

        }

    }
}
