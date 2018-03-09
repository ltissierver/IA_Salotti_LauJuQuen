using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_IA_Quentin_Juliette_Laurie
{
    class Grille
    {
        public static int[][] matrice = new int[20][];
        static bool dejaCree = false;

        #region Singleton de la grille
        public static Grille InstanceGrille
        {
            get
            {
                if (!dejaCree)
                {
                    InstanceGrille.Initialisation();
                    dejaCree = true;
                }
                return InstanceGrille;
            }
        }
        #endregion

        public void Initialisation()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrice[i][j] = 1;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                matrice[0][i] = 0; // premiere ligne
                matrice[19][i] = 0; // deuxieme ligne
                matrice[i][0] = 0; // première colonne
                matrice[i][19] = 0; // dernière colonne
            }

            matrice[1][9] = 0;
            matrice[1][15] = 0;
            matrice[2][9] = 0;
            matrice[2][15] = 0;
            matrice[3][4] = 0;
            matrice[3][5] = 0;
            matrice[3][9] = 0;
            matrice[3][15] = 0;
            matrice[4][4] = 0;
            matrice[4][5] = 0;
            matrice[4][9] = 0;
            matrice[4][15] = 0;
            matrice[4][16] = 0;
            matrice[4][17] = 0;
            matrice[4][18] = 0;
            matrice[5][4] = 0;
            matrice[5][5] = 0;

            matrice[5][9] = 0;
            matrice[6][4] = 0;
            matrice[6][5] = 0;
            matrice[6][9] = 0;
            matrice[7][4] = 0;
            matrice[7][5] = 0;
            matrice[7][9] = 0;
            matrice[8][4] = 0;
            matrice[8][5] = 0;
            matrice[8][9] = 0;
            matrice[9][9] = 0;
            matrice[10][9] = 0;
            matrice[11][1] = 0;
            matrice[11][2] = 0;
            matrice[11][3] = 0;
            matrice[11][4] = 0;
            matrice[11][5] = 0;
            matrice[11][6] = 0;
            matrice[11][8] = 0;
            matrice[11][9] = 0;
            matrice[12][5] = 0;
            matrice[12][6] = 0;
            matrice[12][15] = 0;
            matrice[12][16] = 0;
            matrice[13][5] = 0;
            matrice[13][6] = 0;
            matrice[13][15] = 0;
            matrice[13][16] = 0;
            matrice[14][5] = 0;
            matrice[14][6] = 0;
            matrice[14][10] = 0;
            matrice[14][11] = 0;
            matrice[14][15] = 0;
            matrice[14][16] = 0;
            matrice[15][5] = 0;
            matrice[15][6] = 0;
            matrice[15][10] = 0;
            matrice[15][11] = 0;
            matrice[15][15] = 0;
            matrice[15][16] = 0;
            matrice[16][10] = 0;
            matrice[16][11] = 0;
            matrice[16][15] = 0;
            matrice[16][16] = 0;
            matrice[17][10] = 0;
            matrice[17][11] = 0;
            matrice[18][10] = 0;
            matrice[18][11] = 0;

        }
    }
}
