
namespace Zoo_Raph
{
    partial class Mon_Zoo
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_Taureaux = new System.Windows.Forms.Button();
            this.Btn_Lions = new System.Windows.Forms.Button();
            this.Btn_Oiseau = new System.Windows.Forms.Button();
            this.Pic_Oiseau = new System.Windows.Forms.PictureBox();
            this.Pic_Lions = new System.Windows.Forms.PictureBox();
            this.Pic_Taureaux = new System.Windows.Forms.PictureBox();
            this.Combo_Voir = new System.Windows.Forms.ComboBox();
            this.zOO_RaphDataSet = new Zoo_Raph.ZOO_RaphDataSet();
            this.animauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animauxTableAdapter = new Zoo_Raph.ZOO_RaphDataSetTableAdapters.AnimauxTableAdapter();
            this.Btn_Voir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Oiseau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Lions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Taureaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOO_RaphDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animauxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_Taureaux
            // 
            this.Btn_Taureaux.Location = new System.Drawing.Point(58, 191);
            this.Btn_Taureaux.Name = "Btn_Taureaux";
            this.Btn_Taureaux.Size = new System.Drawing.Size(151, 33);
            this.Btn_Taureaux.TabIndex = 2;
            this.Btn_Taureaux.Text = "Taureaux";
            this.Btn_Taureaux.UseVisualStyleBackColor = true;
            this.Btn_Taureaux.Click += new System.EventHandler(this.Btn_Taureaux_Click);
            // 
            // Btn_Lions
            // 
            this.Btn_Lions.Location = new System.Drawing.Point(274, 191);
            this.Btn_Lions.Name = "Btn_Lions";
            this.Btn_Lions.Size = new System.Drawing.Size(151, 33);
            this.Btn_Lions.TabIndex = 3;
            this.Btn_Lions.Text = "Lions";
            this.Btn_Lions.UseVisualStyleBackColor = true;
            this.Btn_Lions.Click += new System.EventHandler(this.Btn_Lions_Click);
            // 
            // Btn_Oiseau
            // 
            this.Btn_Oiseau.Location = new System.Drawing.Point(482, 191);
            this.Btn_Oiseau.Name = "Btn_Oiseau";
            this.Btn_Oiseau.Size = new System.Drawing.Size(151, 33);
            this.Btn_Oiseau.TabIndex = 5;
            this.Btn_Oiseau.Text = "Oiseau";
            this.Btn_Oiseau.UseVisualStyleBackColor = false;
            this.Btn_Oiseau.Click += new System.EventHandler(this.Btn_Oiseau_Click);
            // 
            // Pic_Oiseau
            // 
            this.Pic_Oiseau.Image = global::Zoo_Raph.Properties.Resources.oiseau;
            this.Pic_Oiseau.Location = new System.Drawing.Point(482, 47);
            this.Pic_Oiseau.Name = "Pic_Oiseau";
            this.Pic_Oiseau.Size = new System.Drawing.Size(149, 150);
            this.Pic_Oiseau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Oiseau.TabIndex = 4;
            this.Pic_Oiseau.TabStop = false;
            // 
            // Pic_Lions
            // 
            this.Pic_Lions.Image = global::Zoo_Raph.Properties.Resources.lion;
            this.Pic_Lions.Location = new System.Drawing.Point(274, 47);
            this.Pic_Lions.Name = "Pic_Lions";
            this.Pic_Lions.Size = new System.Drawing.Size(149, 150);
            this.Pic_Lions.TabIndex = 1;
            this.Pic_Lions.TabStop = false;
            // 
            // Pic_Taureaux
            // 
            this.Pic_Taureaux.Image = global::Zoo_Raph.Properties.Resources.taureau_camargue1;
            this.Pic_Taureaux.Location = new System.Drawing.Point(58, 47);
            this.Pic_Taureaux.Name = "Pic_Taureaux";
            this.Pic_Taureaux.Size = new System.Drawing.Size(151, 150);
            this.Pic_Taureaux.TabIndex = 0;
            this.Pic_Taureaux.TabStop = false;
            // 
            // Combo_Voir
            // 
            this.Combo_Voir.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animauxBindingSource, "Nom", true));
            this.Combo_Voir.DataSource = this.animauxBindingSource;
            this.Combo_Voir.DisplayMember = "Nom";
            this.Combo_Voir.FormattingEnabled = true;
            this.Combo_Voir.Location = new System.Drawing.Point(58, 381);
            this.Combo_Voir.Name = "Combo_Voir";
            this.Combo_Voir.Size = new System.Drawing.Size(151, 21);
            this.Combo_Voir.TabIndex = 6;
            this.Combo_Voir.Text = "Nom";
            this.Combo_Voir.ValueMember = "Nom";
            // 
            // zOO_RaphDataSet
            // 
            this.zOO_RaphDataSet.DataSetName = "ZOO_RaphDataSet";
            this.zOO_RaphDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animauxBindingSource
            // 
            this.animauxBindingSource.DataMember = "Animaux";
            this.animauxBindingSource.DataSource = this.zOO_RaphDataSet;
            // 
            // animauxTableAdapter
            // 
            this.animauxTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Voir
            // 
            this.Btn_Voir.Location = new System.Drawing.Point(58, 402);
            this.Btn_Voir.Name = "Btn_Voir";
            this.Btn_Voir.Size = new System.Drawing.Size(151, 27);
            this.Btn_Voir.TabIndex = 7;
            this.Btn_Voir.Text = "Voir";
            this.Btn_Voir.UseVisualStyleBackColor = true;
            this.Btn_Voir.Click += new System.EventHandler(this.Btn_Voir_Click);
            // 
            // Mon_Zoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 618);
            this.Controls.Add(this.Btn_Voir);
            this.Controls.Add(this.Combo_Voir);
            this.Controls.Add(this.Btn_Oiseau);
            this.Controls.Add(this.Pic_Oiseau);
            this.Controls.Add(this.Btn_Lions);
            this.Controls.Add(this.Btn_Taureaux);
            this.Controls.Add(this.Pic_Lions);
            this.Controls.Add(this.Pic_Taureaux);
            this.Name = "Mon_Zoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo de Campagnac";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Oiseau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Lions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Taureaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOO_RaphDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animauxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox Pic_Taureaux;
        private System.Windows.Forms.PictureBox Pic_Lions;
        private System.Windows.Forms.Button Btn_Lions;
        private System.Windows.Forms.Button Btn_Taureaux;
        private System.Windows.Forms.Button Btn_Oiseau;
        private System.Windows.Forms.PictureBox Pic_Oiseau;
        private System.Windows.Forms.ComboBox Combo_Voir;
        private ZOO_RaphDataSet zOO_RaphDataSet;
        private System.Windows.Forms.BindingSource animauxBindingSource;
        private ZOO_RaphDataSetTableAdapters.AnimauxTableAdapter animauxTableAdapter;
        private System.Windows.Forms.Button Btn_Voir;
    }
}

