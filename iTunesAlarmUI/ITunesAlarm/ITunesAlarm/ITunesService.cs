using iTunesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITunesAlarm.Entity;

namespace ITunesAlarm
{
    class ITunesService
    {
        private readonly iTunesLib.IiTunes iTunesApp = new iTunesLib.iTunesApp();

        public IList<Playlist> getAllPlaylists()
        {
            IList<Playlist> playlists = new List<Playlist>();
            getAllITunesPlaylists().ForEach(pl => playlists.Add(new Playlist(pl)));
            return playlists;
        }

        public IList<SimplePlaylist> getAllSimplePlaylists()
        {
            IList<SimplePlaylist> playlists = new List<SimplePlaylist>();
            getAllITunesPlaylists().ForEach(pl => playlists.Add(new SimplePlaylist(pl)));
            return playlists;
        }

        private List<IITPlaylist> getAllITunesPlaylists()
        {
            List<IITPlaylist> playlists = new List<IITPlaylist>();
            foreach (IITSource source in iTunesApp.Sources)
            {
                IITPlaylistCollection coll = source.Playlists;
                foreach (IITPlaylist pl in coll)
                {
                    if (pl.Tracks.Count > 0)
                    {
                        playlists.Add(pl);
                    }

                }
            }
            return playlists;
        }
    }



}
