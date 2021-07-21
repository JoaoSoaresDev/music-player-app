using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayerApp : Form
    {

        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code to close the app
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play music
            WindowsMediaPlayerMusic.URL = paths[Songs.SelectedIndex];

        }

        // Create Global variables of strings to save the titles or names of tracks and paths of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            // Code to select multiple files
            ofd.Multiselect = true;

            // Code to only select music files
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;   // Save the names of the track in files array
                paths = ofd.FileNames;       // Save the path of the track in paths array
                // Display the music files in listbox
            }

            for(int i = 0; i < files.Length; i++)
            {
                Songs.Items.Add(files[i]); // Display songs in listbox
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
