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
        public Formulaire()
        {
            InitializeComponent();
            initialisationGraphique(3,3);
        }


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

        void coloriageGraphique(int[][] matrice)
        {
            //Parcourir la grille
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (matrice[i][j]==1)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                    //Obstacles
                    else if (matrice[i][j] == 0)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    //Robot
                    else if (matrice[i][j] == 2)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                    //Passe par
                    else if (matrice[i][j] == 3)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    //Arrivée
                    else if (matrice[i][j] == 3)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }

        private void BoutonChercherChemin_Click(object sender, EventArgs e)
        {
            //vérifier valeurs remplies
            if (textBoxPositionDepart.Text=="" || textBoxPositionArrivee.Text=="")
            {
                return;
            }
            //montrer différents chemins ?
            //montrer chemin fini
        }

        private void buttonCheckpoint_Click(object sender, EventArgs e)
        {
            //vérifier valeurs remplies
            //montrer différents chemins ?
            //montrer chemin fini
        }

        public bool dansLaGrille(string cellule)
        {

            return true;
        }
    }
}
