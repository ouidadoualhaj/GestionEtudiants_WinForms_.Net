namespace GestionEtudiants
{
    partial class Etudiants
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gnd = new System.Windows.Forms.DataGridView();
            this.btnaffiche = new System.Windows.Forms.Button();
            this.btnAjoutter = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.findlabel = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnsupp = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // gnd
            // 
            this.gnd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gnd.Location = new System.Drawing.Point(53, 174);
            this.gnd.Name = "gnd";
            this.gnd.Size = new System.Drawing.Size(398, 267);
            this.gnd.TabIndex = 0;
            this.gnd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gnd_CellContentClick);
            // 
            // btnaffiche
            // 
            this.btnaffiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnaffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaffiche.Location = new System.Drawing.Point(370, 138);
            this.btnaffiche.Name = "btnaffiche";
            this.btnaffiche.Size = new System.Drawing.Size(81, 30);
            this.btnaffiche.TabIndex = 1;
            this.btnaffiche.Text = "Afficher";
            this.btnaffiche.UseVisualStyleBackColor = false;
            this.btnaffiche.Click += new System.EventHandler(this.btnaffiche_Click);
            // 
            // btnAjoutter
            // 
            this.btnAjoutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjoutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutter.Location = new System.Drawing.Point(53, 138);
            this.btnAjoutter.Name = "btnAjoutter";
            this.btnAjoutter.Size = new System.Drawing.Size(76, 30);
            this.btnAjoutter.TabIndex = 2;
            this.btnAjoutter.Text = "Ajouter";
            this.btnAjoutter.UseVisualStyleBackColor = false;
            this.btnAjoutter.Click += new System.EventHandler(this.btnAjoutter_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(122, 72);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(269, 20);
            this.textName.TabIndex = 3;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(122, 111);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(269, 20);
            this.textAge.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(77, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nom";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(77, 115);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age";
            // 
            // findlabel
            // 
            this.findlabel.AutoSize = true;
            this.findlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findlabel.Location = new System.Drawing.Point(77, 43);
            this.findlabel.Name = "findlabel";
            this.findlabel.Size = new System.Drawing.Size(20, 16);
            this.findlabel.TabIndex = 10;
            this.findlabel.Text = "ID";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(122, 39);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(269, 20);
            this.textId.TabIndex = 11;
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.Location = new System.Drawing.Point(161, 138);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(74, 30);
            this.btnsupp.TabIndex = 12;
            this.btnsupp.Text = "supprimer";
            this.btnsupp.UseVisualStyleBackColor = false;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.Location = new System.Drawing.Point(268, 138);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(82, 30);
            this.btnmod.TabIndex = 13;
            this.btnmod.Text = "modifier";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion des etudiants";
            // 
            // Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(503, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.findlabel);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnAjoutter);
            this.Controls.Add(this.btnaffiche);
            this.Controls.Add(this.gnd);
            this.Name = "Etudiants";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gnd;
        private System.Windows.Forms.Button btnaffiche;
        private System.Windows.Forms.Button btnAjoutter;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label findlabel;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmod;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
    }
}

