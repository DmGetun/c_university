using labSoundPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSoundPlayer
{
    public partial class Form2 : Form
    {

        private SoundPlayer soundPlayer = new SoundPlayer();
        public Form2()
        {
            InitializeComponent();

            InitializeComponent();

            soundPlayer.SoundLocation = @"C:\Windows\";

            //soundPlayer.Stream = Resources._audiokick;

            buPlay.Click += (s, e) => soundPlayer.Play();
            buStop.Click += (s, e) => soundPlayer.Stop();
            button3.Click += (s, e) => soundPlayer.PlayLooping();

            button4.Click += (s, e) => SystemSounds.Beep.Play();
        }
    }
}
