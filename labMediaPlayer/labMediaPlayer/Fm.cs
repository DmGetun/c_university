using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace labMediaPlayer
{
    public partial class Fm : Form
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public Fm()
        {
            InitializeComponent();

            mediaPlayer.Open( new Uri(@"C:\Users\Дмитрий\Downloads\САМЕДЛИ - Она в моем Тик Ток.mp3"));

            buPlay.Click += (s, e) => mediaPlayer.Play();
            buPause.Click += (s, e) => mediaPlayer.Pause();
            buStop.Click += (s, e) => mediaPlayer.Stop();

            trVolume.Maximum = 100;
            trVolume.Value = (int)Math.Round(mediaPlayer.Volume * 100);
            trVolume.ValueChanged += (s, e) => mediaPlayer.Volume = trVolume.Value / 100.0;

        }
    }
}
