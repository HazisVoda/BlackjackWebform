﻿using System;
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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        public void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();

            gameWindow.Show();

        }

        private void LoadRules(object sender, EventArgs e)
        {
            Menu menuScreen = new Menu();

            menuScreen.Show();
        }
    }
}
