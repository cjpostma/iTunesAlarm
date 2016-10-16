using iTunesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITunesAlarm.Entity    
{
    class SimplePlaylist
    {
        public int externalId { get; }
        public string name { get; }
        public SimplePlaylist(IITPlaylist iTunesPlaylist)
        {
            this.externalId = iTunesPlaylist.playlistID;
            this.name = iTunesPlaylist.Name;

        }

        public override string ToString()
        {
            return this.name;
        }
    }

    class Playlist : SimplePlaylist
    {
        private readonly IList<Song> songs = new List<Song>(); 
        public Playlist(IITPlaylist iTunesPlaylist): base(iTunesPlaylist)
        {
            foreach(IITTrack track in iTunesPlaylist.Tracks)
            {
                songs.Add(new Song(track));
            }
        }
    }

    class Song
    {
        private readonly int externalId;
        private readonly string artist;
        private readonly string title;
        public Song(IITTrack track)
        {
            this.externalId = track.trackID;
            this.artist = track.Artist;
            this.title = track.Name;
        }
    }
}
