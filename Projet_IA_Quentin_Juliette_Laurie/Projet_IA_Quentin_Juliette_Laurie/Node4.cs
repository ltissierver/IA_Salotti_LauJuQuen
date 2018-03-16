using System;
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

        public override double CalculeHCost()
        {
            throw new NotImplementedException();
        }

        public override bool EndState()
        {
            throw new NotImplementedException();
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
            if (y + 1 < 20 && Formulaire.matrice[x, y + 1] == 1)
            {
                lsucc.Add(new Node4(x, y + 1));
            }
            // Regarder à Gauche
            if (y - 1 > -1 && Formulaire.matrice[x, y - 1] == 1)
            {
                lsucc.Add(new Node4(x, y - 1));
            }
            // Regarder en haut
            if (x - 1 > -1 && Formulaire.matrice[x - 1, y] == 1)
            {
                lsucc.Add(new Node4(x - 1, y));
            }
            // Regarder en Bas
            if (x + 1 < 20 && Formulaire.matrice[x + 1, y] == 1)
            {
                lsucc.Add(new Node4(x + 1, y));
            }
            // Regarder en diagonale haut gauche
            if (x - 1 > -1 && y - 1 > -1 && Formulaire.matrice[x - 1, y - 1] == 1)
            {
                lsucc.Add(new Node4(x - 1, y - 1));
            }
            // Regarder en diagonale haut droit
            if (x - 1 > -1 && y + 1 < 20 && Formulaire.matrice[x - 1, y + 1] == 1)
            {
                lsucc.Add(new Node4(x - 1, y + 1));
            }
            // Regarder en diagonale Bas gauche
            if (x + 1 < 20 && y - 1 > -1 && Formulaire.matrice[x + 1, y - 1] == 1)
            {
                lsucc.Add(new Node4(x + 1, y - 1));
            }
            // Regarder en diagonale Bas droit
            if (x + 1 < 20 && y + 1 < 20 && Formulaire.matrice[x + 1, y + 1] == 1)
            {
                lsucc.Add(new Node4(x + 1, y + 1));
            }
            return lsucc;
        }

        public override bool IsEqual(GenericNode N2)
        {
            throw new NotImplementedException();
        }

        //ToString
        public override string ToString()
        {
            return (x + 1) + " " + (y + 1);
        }
    }
}
