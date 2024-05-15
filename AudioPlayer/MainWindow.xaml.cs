using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AudioPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player _player;
        private Playlist _playlist;

        public MainWindow()
        {
            InitializeComponent();
            _playlist = new Playlist();
            _player = new Player(_playlist);
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            _player.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _player.Stop();
        }

        private void ResumeButton_Click(object sender, RoutedEventArgs e)
        {
            _player.Resume();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            _player.PreviousTrack();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            _player.NextTrack();
        }

        private void RewindButton_Click(object sender, RoutedEventArgs e)
        {
            _player.Rewind();
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _player.SetVolume(e.NewValue);
        }

        private void TrackListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Track track = e.AddedItems[0] as Track;
                _playlist.PlayTrack(track);
            }
        }

        private void AddFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio files (*.wav, *.mp3, *.wma, *.ogg, *.flac) | *.wav; *.mp3; *.wma; *.ogg; *.flac";
            if (ofd.ShowDialog() == true)
            {
                Track track = new Track(ofd.FileName, ofd.SafeFileName.Remove(ofd.SafeFileName.Length - 4), "", "", TimeSpan.Zero);
                _playlist.AddTrack(track);
            }
        }

        private void RemoveFileButton_Click(object sender, RoutedEventArgs e)
        {
            Track track = TrackListBox.SelectedItem as Track;
            _playlist.DeleteTrack(track);
        }
    }
}