using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayer2
{
    public partial class musicPlayerApp : Form
    {
        public musicPlayerApp()
        {
            InitializeComponent();
        }

        //create global variable of string array for titles and path to tracks
        String[] paths, files;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; //allows to select multiple tracks


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save names of the track in file array
                paths = ofd.FileNames; //save path to track in path array

                for (int i = 0; i < files.Length; i++)
                {
                    listSongs.Items.Add(files[i]); //display song name
                }
            }
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play music in player
            playerTrack.URL = paths[listSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
