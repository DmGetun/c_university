using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSoundPlayer
{
    public partial class Fm : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();

        public Fm()
        {
            InitializeComponent();

            soundPlayer.Stream = Resources._audiokick;

            button1.Click += (s, e) => soundPlayer.Play();
            button2.Click += (s, e) => soundPlayer.Stop();
            button3.Click += (s, e) => soundPlayer.PlayLooping();
        }
    }
}
