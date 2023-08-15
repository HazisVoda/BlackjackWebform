using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGame
{
public partial class GameScreen : Form
{
        Game newGame = new Game();
        public GameScreen()
        {
            InitializeComponent();

            newGame.Start();
            pictureBox1.Image = imageList1.Images[0];

        }

        public void ImageShow(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
        }

        public void draw_click(object sender, EventArgs e)
        {
            newGame.DrawBtn();

        }

        public void fold_click(object sender, EventArgs e)
        {
            newGame.NextBtn();
            this.Close();
        }


    }
}
