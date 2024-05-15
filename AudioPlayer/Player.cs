using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace AudioPlayer
{
    public class Player
    {

        private MediaPlayer _mediaPlayer;
        private Playlist _playlist;

        public Player(Playlist playlist)
        {
            _mediaPlayer = new MediaPlayer();
            _playlist = playlist;
        }

        public void Start()
        {
            if (_playlist.CurrentTrack != null)
            {
                _mediaPlayer.Open(new Uri(_playlist.CurrentTrack.FileName));
                _mediaPlayer.Play();
            }
        }

        public void Stop()
        {
            _mediaPlayer.Stop();
        }

        public void Resume()
        {
            _mediaPlayer.Play();
        }

        public void PreviousTrack()
        {
            if (_playlist.CurrentTrackIndex > 0)
            {
                _playlist.CurrentTrackIndex--;
                Start();
            }
        }

        public void NextTrack()
        {
            if (_playlist.CurrentTrackIndex < _playlist.Tracks.Count - 1)
            {
                _playlist.CurrentTrackIndex++;
                Start();
            }
        }

        public void Rewind()
        {
            _mediaPlayer.Position = TimeSpan.Zero;
        }

        public void SetVolume(double volume)
        {
            _mediaPlayer.Volume = volume;
        }

        public Track GetCurrentTrack()
        {
            return _playlist.CurrentTrack;
        }

        public TimeSpan GetCurrentPosition()
        {
            return _mediaPlayer.Position;
        }

        public TimeSpan GetTrackLength()
        {
            return _mediaPlayer.NaturalDuration.TimeSpan;
        }
    }
}

