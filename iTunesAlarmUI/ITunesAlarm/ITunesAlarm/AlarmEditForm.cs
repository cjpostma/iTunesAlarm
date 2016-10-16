using ITunesAlarm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITunesAlarm
{
    public partial class EditAlarmForm : Form
    {
        private readonly ITunesService iTunesService = new ITunesService();
        public EditAlarmForm()
        {
            InitializeComponent();
            populateMainForm();
        }

        private void populateMainForm()
        {
            IList<SimplePlaylist> playlists = iTunesService.getAllSimplePlaylists();
            PlaylistDropdown.Items.AddRange(playlists.ToArray());
        }


        private void SaveAlarmButton_Click(object sender, EventArgs e)
        {
            SimplePlaylist sp = (SimplePlaylist)PlaylistDropdown.SelectedItem;
            Console.WriteLine("Selected playlist {0}", sp. name);
        }
    }
}
