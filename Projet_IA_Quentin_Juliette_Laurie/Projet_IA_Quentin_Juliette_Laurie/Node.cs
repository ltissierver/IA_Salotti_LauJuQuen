using System;
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
            throw new NotImplementedException();
        }

        public override bool EndState()
        {
            throw new NotImplementedException();
        }

        public override double GetArcCost(GenericNode N2)
        {
            throw new NotImplementedException();
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();
            // Regarder à droite
            if ( Form1.matrice[x,y+1] == 1)
            {
                lsucc.Add(new Node(x, y + 1));
            }
            // Regarder à Gauche
            // Regarder en haut
            // Regarder à gauche
            // Regarder en diagonale
            throw new NotImplementedException();
        }

        public override bool IsEqual(GenericNode N2)
        {
            throw new NotImplementedException();
        }
    }
}
