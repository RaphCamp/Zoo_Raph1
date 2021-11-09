
namespace Zoo_Raph
{
    partial class Zoo_Especes
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
            this.Pic_Lions = new System.Windows.Forms.PictureBox();
            this.Pic_Taureaux = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Lions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Taureaux)).BeginInit();
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
            // Zoo_Especes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 618);
            this.Controls.Add(this.Btn_Lions);
            this.Controls.Add(this.Btn_Taureaux);
            this.Controls.Add(this.Pic_Lions);
            this.Controls.Add(this.Pic_Taureaux);
            this.Name = "Zoo_Especes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo de Campagnac";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Lions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Taureaux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox Pic_Taureaux;
        private System.Windows.Forms.PictureBox Pic_Lions;
        private System.Windows.Forms.Button Btn_Lions;
        private System.Windows.Forms.Button Btn_Taureaux;
    }
}

