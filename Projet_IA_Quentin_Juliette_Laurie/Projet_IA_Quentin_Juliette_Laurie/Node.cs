﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_IA_Quentin_Juliette_Laurie
{
    class Node : GenericNode
    {
        public int x; // Lignes
        public int y; // Colonnes

        public Node (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        

        public override double CalculeHCost()
        {
            double cout = 0;
            
             int ecartX = Math.Abs(Formulaire.celluleArrivee[0] - x);
             int ecartY = Math.Abs(Formulaire.celluleArrivee[1] - y);
             int min = minimum(ecartX, ecartY);
             cout += Math.Sqrt(2) * min;
             ecartX -= min;
             ecartY -= min;

            cout += ecartX + ecartY; // sachant que un des deux écarts = 0 

            return cout;
        }

        public int minimum (int nbr1, int nbr2)
        {
            if (nbr1 < nbr2) return nbr1;
            else return nbr2;
        }

        public override bool EndState()
        {
            return (this.x == Formulaire.celluleArrivee[0] && this.y == Formulaire.celluleArrivee[1]);
        }

        public override double GetArcCost(GenericNode N)
        {
            double distance = Math.Sqrt(2);
            Node N2 = (Node)N;
            if ((this.x == N2.x + 1 || this.x == N2.x - 1) && this.y == N2.y)
            {
                distance = 1;
            }
            if ((this.y == N2.y + 1 || this.y == N2.y - 1) && this.x == N2.x)
            {
                distance = 1;
            }
            return distance;
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();
            
            // Regarder à droite
            if ( y+1 < 20 && Formulaire.matrice[x,y+1] == 1)
            {
                lsucc.Add(new Node(x, y + 1));
            }
            // Regarder à Gauche
            if (y-1 > -1 && Formulaire.matrice[x, y - 1] == 1)
            {
                lsucc.Add(new Node(x, y-1));
            }
            // Regarder en haut
            if (x-1 > -1  && Formulaire.matrice[x-1, y ] == 1)
            {
                lsucc.Add(new Node(x-1, y));
            }
            // Regarder en Bas
            if (x+1 < 20 && Formulaire.matrice[x+1, y ] == 1)
            {
                lsucc.Add(new Node(x+1, y));
            }
            // Regarder en diagonale haut gauche
            if (x - 1 >-1 && y-1 > -1 && Formulaire.matrice[x - 1, y - 1] == 1)
            {
                lsucc.Add(new Node(x - 1, y - 1));
            }
            // Regarder en diagonale haut droit
            if (x - 1 > -1 && y + 1 < 20 && Formulaire.matrice[x - 1, y + 1] == 1)
            {
                lsucc.Add(new Node(x - 1, y + 1));
            }
            // Regarder en diagonale Bas gauche
            if (x + 1 < 20 && y - 1 > -1 && Formulaire.matrice[x + 1, y - 1] == 1)
            {
                lsucc.Add(new Node(x + 1, y - 1));
            }
            // Regarder en diagonale Bas droit
            if (x + 1 < 20 && y + 1 < 20 && Formulaire.matrice[x + 1, y + 1] == 1)
            {
                lsucc.Add(new Node(x + 1, y + 1));
            }
            return lsucc;
        }

        public override bool IsEqual(GenericNode N)
        {
            Node N2 = (Node)N;
            return (this.x == N2.x && this.y == N2.y);
        }
    }
}
