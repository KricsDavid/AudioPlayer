using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace AudioPlayer
{
    public class Playlist
    {
        private ObservableCollection<Track> _tracks;
        private int _currentTrackIndex;

        public Playlist()
        {
            _tracks = new ObservableCollection<Track>();
            _currentTrackIndex = -1;
        }

        public ObservableCollection<Track> Tracks
        {
            get { return _tracks; }
        }

        public Track CurrentTrack
        {
            get { return _tracks[_currentTrackIndex]; }
        }

        public int CurrentTrackIndex
        {
            get { return _currentTrackIndex; }
            set { _currentTrackIndex = value; }
        }

        public void AddTrack(Track track)
        {
            _tracks.Add(track);
        }

        public void DeleteTrack(Track track)
        {
            _tracks.Remove(track);
        }

        public void PlayTrack(Track track)
        {
            _currentTrackIndex = _tracks.IndexOf(track);
            Player.Start();
        }

        public void SavePlaylist(string fileName)
        {
            // implement saving playlist to file
        }

        public void LoadPlaylist(string fileName)
        {
            // implement loading playlist from file
        }
    }
}
