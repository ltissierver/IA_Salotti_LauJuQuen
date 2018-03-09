using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Projet_IA_Quentin_Juliette_Laurie
{
    public partial class Formulaire : Form
    {

        public static int[,] matrice = new int[20,20];
        public static int[] celluleDepart = new int[2];
        public static int[] celluleArrivee = new int[2];
        public static int[] celluleDepartCheck = new int[2];
        public static int[] check1 = new int[2];
        public static int[] check2 = new int[2];
        public static int[] check3 = new int[2];
        public static int[] check4 = new int[2];

        private Graph graph;

        public Formulaire()
        {
            InitializeComponent();
            initialisationGrille();
            initialisationGraphique(3,3);
            coloriageGraphique();
            graph = new Graph();
        }

        /// <summary>
        /// initalise la grille dans le form
        /// </summary>
        /// <param name="positioni"></param>
        /// <param name="positionj"></param>
        void initialisationGraphique(int positioni, int positionj)
        {
            this.dataGridView.ColumnCount = 20;
            this.dataGridView.RowCount = 20;
            //Mettre les bons titres
            int k = 1;
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.Width = 30;
                col.HeaderText = k.ToString();
                k++;
            }
            for (int i = 0; i < 20; i++)
            {
                this.dataGridView.RowHeadersWidth = 60;
                this.dataGridView.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
        }

        private void coloriageGraphique()
        {
            //Parcourir la grille
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (matrice[i,j]==1)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                    //Obstacles
                    else if (matrice[i,j] == 0)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    //Robot
                    else if (matrice[i,j] == 2)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                    //Passe par
                    else if (matrice[i,j] == 3)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    //Arrivée
                    else if (matrice[i,j] == 4)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    //chemin
                    else if (matrice[i, j] == 5)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Cyan;
                }
            }
        }

        private void BoutonChercherChemin_Click(object sender, EventArgs e)
        {
            //vérifier valeurs remplies
            if (textBoxPositionDepart.Text=="" || textBoxPositionArrivee.Text=="" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Entrez 2 nombres dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }

            if (!int.TryParse(textBoxPositionDepart.Text, out celluleDepart[0]))
            { 
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox1.Text, out celluleDepart[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBoxPositionArrivee.Text, out celluleArrivee[0]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox2.Text, out celluleArrivee[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            celluleArrivee[0] --;
            celluleArrivee[1]--;
            celluleDepart[0] --;
            celluleDepart[1]--;
            if (!dansLaGrille(celluleDepart[0],celluleDepart[1]) || !dansLaGrille(celluleArrivee[0],celluleArrivee[1]))
            {
                MessageBox.Show("Entrez un nombre valable : pas hors limite et pas sur un obstacle");
                return;
            }
            //changer les valeurs
            matrice[celluleDepart[0],celluleDepart[1]] = 2;
            matrice[celluleArrivee[0], celluleArrivee[1]] = 4;
            //trouver les chemins
            //  1. donner les valeurs aux noeuds correspondant au noeud final
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // convertir le point de la matrice en node matrice[i,j]
                    // calculer son cout
                    // node.CalculeHCost()
                }
            }


            //montrer différents chemins ?
            //montrer chemin fini
            coloriageGraphique();
        }

        private void buttonCheckpoint_Click(object sender, EventArgs e)
        {
            //vérifier valeurs remplies
            if (textBoxDepartCheckpoint.Text == "" || textBoxCheckpoint1.Text == "" || textBoxCheckpoint2.Text == "" || textBoxCheckpoint3.Text == "" || textBoxCheckpoint4.Text == "")
            {
                MessageBox.Show("Entrez 2 nombres dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Entrez 2 nombres dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBoxDepartCheckpoint.Text, out celluleDepartCheck[0]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBoxCheckpoint1.Text, out check1[0]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBoxCheckpoint2.Text, out check2[0]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBoxCheckpoint3.Text, out check3[0]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBoxCheckpoint4.Text, out check4[0]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox3.Text, out celluleDepartCheck[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox4.Text, out check1[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox5.Text, out check2[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox6.Text, out check3[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            if (!int.TryParse(textBox7.Text, out check4[1]))
            {
                MessageBox.Show("Entrez un nombre dont les 2 chiffres sont respectivement la colonne puis la ligne.");
                return;
            }
            celluleDepartCheck[0] --;
            check1[0] --;
            check2[0] --;
            check3[0] --;
            check4[0] --;
            celluleDepartCheck[1]--;
            check1[1]--;
            check2[1]--;
            check3[1]--;
            check4[1]--;
            if (!dansLaGrille(celluleDepartCheck[0], celluleDepartCheck[1]) || !dansLaGrille(check1[0], check1[1]) || !dansLaGrille(check2[0], check2[1]) || !dansLaGrille(check3[0],check3[1]) || !dansLaGrille(check4[0],check4[1]))
            {
                MessageBox.Show("Entrez un nombre valable : pas hors limite et pas sur un obstacle");
                return;
            }
            //changer les valeurs
            matrice[celluleDepartCheck[0], celluleDepartCheck[1]] = 2;
            matrice[check1[0], check1[1]] = 3;
            matrice[check2[0], check2[1]] = 3;
            matrice[check3[0], check3[1]] = 3;
            matrice[check4[0], check4[1]] = 3;

            //montrer différents chemins ?
            //montrer chemin fini
            coloriageGraphique();
        }

        public bool dansLaGrille(int ligne, int colonne)
        {
            if (ligne >= 20 || colonne >= 20 || ligne < 0 || colonne < 0)
                return false;
            if (matrice[ligne, colonne] == 0)
                return false;
            return true;
        }

        /// <summary>
        /// initialise la grille et la liste de noeuds ouverts
        /// </summary>
        public void initialisationGrille()
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrice[i,j] = 1;
                    graph.L_Ouverts.Add(new Node(i, j));
                }
            }
            for (int i = 0; i < 20; i++)
            {
                matrice[0,i] = 0; // premiere ligne
                matrice[19,i] = 0; // deuxieme ligne
                matrice[i,0] = 0; // première colonne
                matrice[i,19] = 0; // dernière colonne
            }

            matrice[1,9] = 0;
            matrice[1,15] = 0;
            matrice[2,9] = 0;
            matrice[2,15] = 0;
            matrice[3,4] = 0;
            matrice[3,5] = 0;
            matrice[3,9] = 0;
            matrice[3,15] = 0;
            matrice[4,4] = 0;
            matrice[4,5] = 0;
            matrice[4,9] = 0;
            matrice[4,15] = 0;
            matrice[4,16] = 0;
            matrice[4,17] = 0;
            matrice[4,18] = 0;
            matrice[5,4] = 0;
            matrice[5,5] = 0;

            matrice[5,9] = 0;
            matrice[6,4] = 0;
            matrice[6,5] = 0;
            matrice[6,9] = 0;
            matrice[7,4] = 0;
            matrice[7,5] = 0;
            matrice[7,9] = 0;
            matrice[8,4] = 0;
            matrice[8,5] = 0;
            matrice[8,9] = 0;
            matrice[9,9] = 0;
            matrice[10,9] = 0;
            matrice[11,1] = 0;
            matrice[11,2] = 0;
            matrice[11,3] = 0;
            matrice[11,4] = 0;
            matrice[11,5] = 0;
            matrice[11,6] = 0;
            matrice[11,8] = 0;
            matrice[11,9] = 0;
            matrice[12,5] = 0;
            matrice[12,6] = 0;
            matrice[12,15] = 0;
            matrice[12,16] = 0;
            matrice[13,5] = 0;
            matrice[13,6] = 0;
            matrice[13,15] = 0;
            matrice[13,16] = 0;
            matrice[14,5] = 0;
            matrice[14,6] = 0;
            matrice[14,10] = 0;
            matrice[14,11] = 0;
            matrice[14,15] = 0;
            matrice[14,16] = 0;
            matrice[15,5] = 0;
            matrice[15,6] = 0;
            matrice[15,10] = 0;
            matrice[15,11] = 0;
            matrice[15,15] = 0;
            matrice[15,16] = 0;
            matrice[16,10] = 0;
            matrice[16,11] = 0;
            matrice[16,15] = 0;
            matrice[16,16] = 0;
            matrice[17,10] = 0;
            matrice[17,11] = 0;
            matrice[18,10] = 0;
            matrice[18,11] = 0;

        }
    }
}
