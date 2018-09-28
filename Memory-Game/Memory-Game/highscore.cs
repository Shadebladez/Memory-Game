using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class highscore : Form
    {
        public highscore()
        {
            InitializeComponent();
        }

        private void highscore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'memoryDataSet.Highscores' table. You can move, or remove it, as needed.
            this.highscoresTableAdapter.Fill(this.memoryDataSet.Highscores);

        }
    }
}
