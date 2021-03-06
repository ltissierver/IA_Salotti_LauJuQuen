﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_IA_Quentin_Juliette_Laurie
{
    class Node4 : GenericNode
    {
        public int x; // Lignes
        public int y; // Colonnes

        public Node4(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void pointVisite(int x, int y)
        {
            if (x == Formulaire.check1[0] && y == Formulaire.check1[1])
            {
                Formulaire.CheckPoint1 = true;
            }
            else if (x == Formulaire.check2[0] && y == Formulaire.check2[1])
            {
                Formulaire.CheckPoint2 = true;
            }
            else if (x == Formulaire.check3[0] && y == Formulaire.check3[1])
            {
                Formulaire.CheckPoint3 = true;
            }
            else if (x == Formulaire.check4[0] && y == Formulaire.check4[1])
            {
                Formulaire.CheckPoint4 = true;
            }
        }

        public double CalculeHCostLocal(int[] cell)
        {
            double cout = 0;
            int ecartX = Math.Abs(cell[0] - x);
            int ecartY = Math.Abs(cell[0] - y);
            int min = Math.Min(ecartX, ecartY);
            cout += Math.Sqrt(2) * min;
            ecartX -= min;
            ecartY -= min;
            cout += ecartX + ecartY; // sachant que un des deux écarts = 0
            return cout;
        }

        public override double CalculeHCost()
        {
            double cout = 0;
            if (Formulaire.CheckPoint1 == true && Formulaire.CheckPoint2 == true && Formulaire.CheckPoint3 == true && Formulaire.CheckPoint4 == true)
            {
                cout = CalculeHCostLocal(Formulaire.celluleDepartCheck);
                /*int ecartX = Math.Abs(Formulaire.celluleDepartCheck[0] - x);
                int ecartY = Math.Abs(Formulaire.celluleDepartCheck[1] - y);
                int min = Math.Min(ecartX, ecartY);
                cout += Math.Sqrt(2) * min;
                ecartX -= min;
                ecartY -= min;
                cout += ecartX + ecartY; // sachant que un des deux écarts = 0*/
            }
            else
            {
                List<bool> listeCheck = new List<bool> { Formulaire.CheckPoint1, Formulaire.CheckPoint2, Formulaire.CheckPoint3, Formulaire.CheckPoint4 };
                List<int[]> mesCheck = new List<int[]> { Formulaire.check1, Formulaire.check2, Formulaire.check3, Formulaire.check4 };
                List<double> listeCout = new List<double> { };
                for (int i = 3; i >= 0; i--)
                {
                    if (listeCheck[i])
                    {
                        mesCheck.RemoveAt(i);
                    }
                    else
                    {
                        double coutLocal = CalculeHCostLocal(mesCheck[i]);
                        listeCout.Add(coutLocal);
                    }
                }
                double demiCout = listeCout.Max(); // Renvoie valeur du demiCout
                int indice = 0;
                for (int i = 0; i < listeCout.Count(); i++)
                {
                    if (listeCout[i] == demiCout) { indice = i; } // Récupère l'indice de la liste où la valeur est maximale
                }
                // Puis ajouter le cout vers le point initial (= coutRetour)
                x = mesCheck[indice - 1][0];
                y = mesCheck[indice - 1][1];
                double coutRetour = CalculeHCostLocal(Formulaire.celluleDepartCheck);
                cout = demiCout + coutRetour;
            }
            return (cout);
        }

        public override bool EndState()
        {
            bool testPosition = this.x == Formulaire.celluleDepartCheck[0] && this.y == Formulaire.celluleDepartCheck[1];
            return (testPosition && Formulaire.CheckPoint1 && Formulaire.CheckPoint2 && Formulaire.CheckPoint3 && Formulaire.CheckPoint4);
        }

        public override double GetArcCost(GenericNode N)
        {
            double distance = Math.Sqrt(2);
            Node4 N2 = (Node4)N;
            if ((N2.x == this.x + 1 || N2.x == this.x - 1) && N2.y == this.y)
            {
                distance = 1;
            }
            if ((N2.y == this.y + 1 || N2.y == this.y - 1) && N2.x == this.x)
            {
                distance = 1;
            }
            return distance;
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            // Regarder à droite
            if (y + 1 < 20 && Formulaire.matrice[x, y + 1] != 0)
            {
                lsucc.Add(new Node4(x, y + 1));
            }
            // Regarder à Gauche
            if (y - 1 > -1 && Formulaire.matrice[x, y - 1] != 0)
            {
                lsucc.Add(new Node4(x, y - 1));
            }
            // Regarder en haut
            if (x - 1 > -1 && Formulaire.matrice[x - 1, y] != 0)
            {
                lsucc.Add(new Node4(x - 1, y));
            }
            // Regarder en Bas
            if (x + 1 < 20 && Formulaire.matrice[x + 1, y] != 0)
            {
                lsucc.Add(new Node4(x + 1, y));
            }
            // Regarder en diagonale haut gauche
            if (x - 1 > -1 && y - 1 > -1 && Formulaire.matrice[x - 1, y - 1] != 0)
            {
                lsucc.Add(new Node4(x - 1, y - 1));
            }
            // Regarder en diagonale haut droit
            if (x - 1 > -1 && y + 1 < 20 && Formulaire.matrice[x - 1, y + 1] != 0)
            {
                lsucc.Add(new Node4(x - 1, y + 1));
            }
            // Regarder en diagonale Bas gauche
            if (x + 1 < 20 && y - 1 > -1 && Formulaire.matrice[x + 1, y - 1] != 0)
            {
                lsucc.Add(new Node4(x + 1, y - 1));
            }
            // Regarder en diagonale Bas droit
            if (x + 1 < 20 && y + 1 < 20 && Formulaire.matrice[x + 1, y + 1] != 0)
            {
                lsucc.Add(new Node4(x + 1, y + 1));
            }
            return lsucc;
        }

        public override bool IsEqual(GenericNode N)
        {
            Node N2 = (Node)N;
            return (this.x == N2.x && this.y == N2.y);
        }

        //ToString
        public override string ToString()
        {
            return (x + 1) + " " + (y + 1);
        }
    }
}
