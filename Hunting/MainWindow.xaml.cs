using System;
using System.Windows;
using System.Windows.Media;


namespace Hunting
{
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
            PlayMusic();
        }
        private void PlayMusic()
        {

            mediaPlayer.Open(new Uri("C:\\Users\\HP\\source\\repos\\Hunting\\Lily+Collins+psnya+z+fl+mu+Blosnzhka+pom+I+Belive+in+Love_muzlishko.ru_.mp3"));
            mediaPlayer.Play();
        }
    }
}
