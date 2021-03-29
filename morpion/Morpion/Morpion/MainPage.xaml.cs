using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Morpion
{
    public partial class MainPage : ContentPage
    {
        private Button[] boutons = new Button[9];
        private MoteurMorpion _jeu = new MoteurMorpion();

        public MainPage()
        {
            InitializeComponent();
            boutons[0] = Button10;
            boutons[1] = Button11;
            boutons[2] = Button12;
            boutons[3] = Button20;
            boutons[4] = Button21;
            boutons[5] = Button22;
            boutons[6] = Button30;
            boutons[7] = Button31;
            boutons[8] = Button32;
            
        }

        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            _jeu.SetButton((Button)sender);
            if (_jeu.CheckWinner(boutons))
            {
                if (_jeu.Case != 0 ) 
                lblEtatPartie.Text = string.Format("{0} a gagné la partie", _jeu.PlayerTurn == 1 ? "joueur 1" : "joueur 2");
                else
                    lblEtatPartie.Text = "Match nul !";
            }
        }
        // bouton de reset
        public void boutonResetclicked (object sender, EventArgs e)
            {
                _jeu.ResetGame (boutons);
            lblEtatPartie.Text = "";

            }

        private void ButtonF_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
