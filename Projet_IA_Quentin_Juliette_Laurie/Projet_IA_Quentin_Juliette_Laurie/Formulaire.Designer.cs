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
            this.BoutonChemin = new System.Windows.Forms.Button();
            this.labelPositionDepart = new System.Windows.Forms.Label();
            this.labelPositionArrivee = new System.Windows.Forms.Label();
            this.textBoxPositionDepart = new System.Windows.Forms.TextBox();
            this.textBoxPositionArrivee = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCheckpoint1 = new System.Windows.Forms.TextBox();
            this.textBoxDepartCheckpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCheckpoint3 = new System.Windows.Forms.TextBox();
            this.textBoxCheckpoint2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCheckpoint4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckpoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoutonChemin
            // 
            this.BoutonChemin.Location = new System.Drawing.Point(293, 29);
            this.BoutonChemin.Name = "BoutonChemin";
            this.BoutonChemin.Size = new System.Drawing.Size(150, 46);
            this.BoutonChemin.TabIndex = 0;
            this.BoutonChemin.Text = "Chercher le chemin";
            this.BoutonChemin.UseVisualStyleBackColor = true;
            this.BoutonChemin.Click += new System.EventHandler(this.BoutonChercherChemin_Click);
            // 
            // labelPositionDepart
            // 
            this.labelPositionDepart.AutoSize = true;
            this.labelPositionDepart.Location = new System.Drawing.Point(766, 83);
            this.labelPositionDepart.Name = "labelPositionDepart";
            this.labelPositionDepart.Size = new System.Drawing.Size(98, 13);
            this.labelPositionDepart.TabIndex = 1;
            this.labelPositionDepart.Text = "Position de départ :";
            // 
            // labelPositionArrivee
            // 
            this.labelPositionArrivee.AutoSize = true;
            this.labelPositionArrivee.Location = new System.Drawing.Point(766, 121);
            this.labelPositionArrivee.Name = "labelPositionArrivee";
            this.labelPositionArrivee.Size = new System.Drawing.Size(93, 13);
            this.labelPositionArrivee.TabIndex = 2;
            this.labelPositionArrivee.Text = "Position d\'arrivée :";
            // 
            // textBoxPositionDepart
            // 
            this.textBoxPositionDepart.AcceptsTab = true;
            this.textBoxPositionDepart.Location = new System.Drawing.Point(870, 78);
            this.textBoxPositionDepart.Name = "textBoxPositionDepart";
            this.textBoxPositionDepart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPositionDepart.TabIndex = 4;
            // 
            // textBoxPositionArrivee
            // 
            this.textBoxPositionArrivee.AcceptsTab = true;
            this.textBoxPositionArrivee.Location = new System.Drawing.Point(870, 118);
            this.textBoxPositionArrivee.Name = "textBoxPositionArrivee";
            this.textBoxPositionArrivee.Size = new System.Drawing.Size(100, 20);
            this.textBoxPositionArrivee.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(41, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 20;
            this.dataGridView.Size = new System.Drawing.Size(674, 484);
            this.dataGridView.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoutonChemin);
            this.groupBox1.Location = new System.Drawing.Point(758, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 99);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcours de A à B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCheckpoint);
            this.groupBox2.Controls.Add(this.textBoxCheckpoint4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCheckpoint3);
            this.groupBox2.Controls.Add(this.textBoxCheckpoint2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxCheckpoint1);
            this.groupBox2.Controls.Add(this.textBoxDepartCheckpoint);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(758, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 223);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parcours à checkpoint";
            // 
            // textBoxCheckpoint1
            // 
            this.textBoxCheckpoint1.AcceptsTab = true;
            this.textBoxCheckpoint1.Location = new System.Drawing.Point(113, 68);
            this.textBoxCheckpoint1.Name = "textBoxCheckpoint1";
            this.textBoxCheckpoint1.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckpoint1.TabIndex = 13;
            // 
            // textBoxDepartCheckpoint
            // 
            this.textBoxDepartCheckpoint.AcceptsTab = true;
            this.textBoxDepartCheckpoint.Location = new System.Drawing.Point(113, 28);
            this.textBoxDepartCheckpoint.Name = "textBoxDepartCheckpoint";
            this.textBoxDepartCheckpoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartCheckpoint.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Position checkpoint :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Position de départ :";
            // 
            // textBoxCheckpoint3
            // 
            this.textBoxCheckpoint3.AcceptsTab = true;
            this.textBoxCheckpoint3.Location = new System.Drawing.Point(113, 144);
            this.textBoxCheckpoint3.Name = "textBoxCheckpoint3";
            this.textBoxCheckpoint3.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckpoint3.TabIndex = 17;
            // 
            // textBoxCheckpoint2
            // 
            this.textBoxCheckpoint2.AcceptsTab = true;
            this.textBoxCheckpoint2.Location = new System.Drawing.Point(113, 104);
            this.textBoxCheckpoint2.Name = "textBoxCheckpoint2";
            this.textBoxCheckpoint2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckpoint2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Position checkpoint :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Position checkpoint :";
            // 
            // textBoxCheckpoint4
            // 
            this.textBoxCheckpoint4.AcceptsTab = true;
            this.textBoxCheckpoint4.Location = new System.Drawing.Point(113, 181);
            this.textBoxCheckpoint4.Name = "textBoxCheckpoint4";
            this.textBoxCheckpoint4.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckpoint4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Position checkpoint :";
            // 
            // buttonCheckpoint
            // 
            this.buttonCheckpoint.Location = new System.Drawing.Point(293, 92);
            this.buttonCheckpoint.Name = "buttonCheckpoint";
            this.buttonCheckpoint.Size = new System.Drawing.Size(150, 46);
            this.buttonCheckpoint.TabIndex = 1;
            this.buttonCheckpoint.Text = "Chercher le chemin";
            this.buttonCheckpoint.UseVisualStyleBackColor = true;
            this.buttonCheckpoint.Click += new System.EventHandler(this.buttonCheckpoint_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 566);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxPositionArrivee);
            this.Controls.Add(this.textBoxPositionDepart);
            this.Controls.Add(this.labelPositionArrivee);
            this.Controls.Add(this.labelPositionDepart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulaire";
            this.Text = "Trouve le plus court chemin !";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BoutonChemin;
        private System.Windows.Forms.Label labelPositionDepart;
        private System.Windows.Forms.Label labelPositionArrivee;
        private System.Windows.Forms.TextBox textBoxPositionDepart;
        private System.Windows.Forms.TextBox textBoxPositionArrivee;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCheckpoint;
        private System.Windows.Forms.TextBox textBoxCheckpoint4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCheckpoint3;
        private System.Windows.Forms.TextBox textBoxCheckpoint2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCheckpoint1;
        private System.Windows.Forms.TextBox textBoxDepartCheckpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}