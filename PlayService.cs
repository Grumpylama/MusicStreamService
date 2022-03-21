using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace MusicStreamService
{
    class PlayService
    {
        //List of tracks
        public List<Track> tracks { get; private set; }

        public PlayService(string[] paths)
        {
            for(int i = 0; i < paths.Length; i++)
            {
                this.InitlizeTracksInFolder(paths[i]);
            }
        }
        public PlayService(string path)
        {
            this.InitlizeTracksInFolder(path);
        }

        private void InitlizeTracksInFolder(string path)
        {

        }

        private void InitlizeTrack()
        {

        }

        public void PlayTrack(int TrackID)
        {

        }
        public void PlaySong(Track track)
        {

        }
    }
}
