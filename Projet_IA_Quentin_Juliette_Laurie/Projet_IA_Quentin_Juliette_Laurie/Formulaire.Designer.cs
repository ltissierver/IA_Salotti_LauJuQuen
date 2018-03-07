namespace Projet_IA_Quentin_Juliette_Laurie
{
    partial class Formulaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoutonChercherChemin = new System.Windows.Forms.Button();
            this.labelPositionDepart = new System.Windows.Forms.Label();
            this.labelPositionArrivee = new System.Windows.Forms.Label();
            this.textBoxPositionDepart = new System.Windows.Forms.TextBox();
            this.textBoxPositionArrivee = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BoutonChercherChemin
            // 
            this.BoutonChercherChemin.Location = new System.Drawing.Point(901, 631);
            this.BoutonChercherChemin.Name = "BoutonChercherChemin";
            this.BoutonChercherChemin.Size = new System.Drawing.Size(190, 46);
            this.BoutonChercherChemin.TabIndex = 0;
            this.BoutonChercherChemin.Text = "Chercher le chemin";
            this.BoutonChercherChemin.UseVisualStyleBackColor = true;
            this.BoutonChercherChemin.Click += new System.EventHandler(this.BoutonChercherChemin_Click);
            // 
            // labelPositionDepart
            // 
            this.labelPositionDepart.AutoSize = true;
            this.labelPositionDepart.Location = new System.Drawing.Point(29, 30);
            this.labelPositionDepart.Name = "labelPositionDepart";
            this.labelPositionDepart.Size = new System.Drawing.Size(98, 13);
            this.labelPositionDepart.TabIndex = 1;
            this.labelPositionDepart.Text = "Position de départ :";
            // 
            // labelPositionArrivee
            // 
            this.labelPositionArrivee.AutoSize = true;
            this.labelPositionArrivee.Location = new System.Drawing.Point(29, 68);
            this.labelPositionArrivee.Name = "labelPositionArrivee";
            this.labelPositionArrivee.Size = new System.Drawing.Size(93, 13);
            this.labelPositionArrivee.TabIndex = 2;
            this.labelPositionArrivee.Text = "Position d\'arrivée :";
            // 
            // textBoxPositionDepart
            // 
            this.textBoxPositionDepart.Location = new System.Drawing.Point(133, 25);
            this.textBoxPositionDepart.Name = "textBoxPositionDepart";
            this.textBoxPositionDepart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPositionDepart.TabIndex = 4;
            // 
            // textBoxPositionArrivee
            // 
            this.textBoxPositionArrivee.Location = new System.Drawing.Point(133, 65);
            this.textBoxPositionArrivee.Name = "textBoxPositionArrivee";
            this.textBoxPositionArrivee.Size = new System.Drawing.Size(100, 20);
            this.textBoxPositionArrivee.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(46, 129);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 20;
            this.dataGridView.Size = new System.Drawing.Size(674, 484);
            this.dataGridView.TabIndex = 6;
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 712);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxPositionArrivee);
            this.Controls.Add(this.textBoxPositionDepart);
            this.Controls.Add(this.labelPositionArrivee);
            this.Controls.Add(this.labelPositionDepart);
            this.Controls.Add(this.BoutonChercherChemin);
            this.Name = "Formulaire";
            this.Text = "Trouve le plus court chemin !";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BoutonChercherChemin;
        private System.Windows.Forms.Label labelPositionDepart;
        private System.Windows.Forms.Label labelPositionArrivee;
        private System.Windows.Forms.TextBox textBoxPositionDepart;
        private System.Windows.Forms.TextBox textBoxPositionArrivee;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}