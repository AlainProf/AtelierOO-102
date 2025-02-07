//---------------------------------------------
//   Fichier : 
//   Créateur: Alain Martel
//   Date    : 
//---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class TicTacToe
    {
        Util u=new Util();
        char[] _cases = new char[] { ' ',' ',' ',' ',' ',' ',' ',' ', ' ' }; 
        char joueurCourant = 'X';
        bool partieEnCours = true;
        //---------------------------------------------
        //
        //---------------------------------------------
        public void Jouer()
        {
            while (partieEnCours)
            {
                AfficherGrille();
                prochainCoup();
                if (CoupGagnant())
                {
                    AfficherGrille();
                    Console.WriteLine("BRAVO Vous avez gagné!!");
                    partieEnCours = false;
                }
                u.Pause();
            }
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        private bool CoupGagnant()
        {

            // Vérification d'un tictactoe horizontal
            if (_cases[0] != ' ')
            {
                if (_cases[0] == _cases[1] && _cases[1] == _cases[2])
                {
                    return true;
                }
            }
            if (_cases[3] != ' ')
            {
                if (_cases[3] == _cases[4] && _cases[4] == _cases[5])
                {
                    return true;
                }
            }
            if (_cases[6] != ' ')
            {
                if (_cases[6] == _cases[7] && _cases[7] == _cases[8])
                {
                    return true;
                }
            }


            // Vérification d'un tictactoe vertical
            if (_cases[0] != ' ')
            {
                if (_cases[0] == _cases[3] && _cases[3] == _cases[6])
                {
                    return true;
                }
            }
            if (_cases[1] != ' ')
            {
                if (_cases[1] == _cases[4] && _cases[4] == _cases[7])
                {
                    return true;
                }
            }
            if (_cases[2] != ' ')
            {
                if (_cases[2] == _cases[5] && _cases[5] == _cases[8])
                {
                    return true;
                }
            }


            // Vérification d'un tictactoe diagonal
            if (_cases[0] != ' ')
            {
                if (_cases[0] == _cases[4] && _cases[4] == _cases[8])
                {
                    return true;
                }
            }

            if (_cases[2] != ' ')
            {
                if (_cases[2] == _cases[4] && _cases[4] == _cases[6])
                {
                    return true;
                }
            }
            return false;
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        private void prochainCoup()
        {
            Console.Write("\n\n Au " + joueurCourant + " de jouer\nQuelle case? (0,8)");
            char coup = 'Q';

            while (!CoupLegal(coup))
            {
                coup = u.SaisirChar();

            }
            int idxCoup = int.Parse(coup.ToString());
            _cases[idxCoup] = joueurCourant;
            if (joueurCourant == 'X')
            {
                joueurCourant = 'O';
            }
            else
            {
                joueurCourant = 'X';
            }
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private bool CoupLegal(char coup)
        {
            if (coup != '0' &&
                coup != '1' &&
                coup != '2' &&
                coup != '3' &&
                coup != '4' &&
                coup != '5' &&
                coup != '6' &&
                coup != '7' &&
                coup != '8')
            {
                return false;
            }

            int idxCoup = int.Parse(coup.ToString());
            if (_cases[idxCoup] != ' ')
            {
                return false;
            }
            return true;    
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private void AfficherGrille()
        {
            u.Titre("Tic Tac Toe");
            Console.Write("_" + _cases[0] + "_|");
            Console.Write("_" + _cases[1] + "_|");
            Console.WriteLine("_" + _cases[2] + "_");

            Console.Write("_" + _cases[3] + "_|");
            Console.Write("_" + _cases[4] + "_|");
            Console.WriteLine("_" + _cases[5] + "_");

            Console.Write(" " + _cases[6] + " |");
            Console.Write(" " + _cases[7] + " |");
            Console.WriteLine(" " + _cases[8] + " ");
        }
    }
}
