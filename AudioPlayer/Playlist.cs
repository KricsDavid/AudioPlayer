using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

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
            using (var writer = new StreamWriter("Playlist"))
            {
                var xaml = XamlWriter.Save(Tracks);
                writer.Write(xaml);
            }
        }

        public void LoadPlaylist(string fileName)
        {
            using (var reader = new StreamReader("Playlist"))
            {
                var xaml = reader.ReadToEnd();
                //var tracks = (ObservableCollection<Track>)XamlReader.Load("alma");
                Tracks.Clear();
               // foreach (var track in tracks)
                {
                    //Tracks.Add(track);
                }
            }
        }
    }
}
