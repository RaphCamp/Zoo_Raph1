
namespace Zoo_Raph
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.Btn_Retour = new System.Windows.Forms.Button();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_Sex = new System.Windows.Forms.Label();
            this.Lab_Espece = new System.Windows.Forms.Label();
            this.Lab_SousEspece = new System.Windows.Forms.Label();
            this.Lab_Age = new System.Windows.Forms.Label();
            this.Lab_Statut = new System.Windows.Forms.Label();
            this.Pic_Animal = new System.Windows.Forms.PictureBox();
            this.Lab_Famille = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Animal)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Retour
            // 
            this.Btn_Retour.Location = new System.Drawing.Point(659, 520);
            this.Btn_Retour.Name = "Btn_Retour";
            this.Btn_Retour.Size = new System.Drawing.Size(125, 38);
            this.Btn_Retour.TabIndex = 9;
            this.Btn_Retour.Text = "Retour";
            this.Btn_Retour.UseVisualStyleBackColor = true;
            this.Btn_Retour.Click += new System.EventHandler(this.Btn_Retour_Click);
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Name.Location = new System.Drawing.Point(54, 280);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(185, 24);
            this.Lab_Name.TabIndex = 12;
            this.Lab_Name.Text = "Nom:  Animal_Name";
            this.Lab_Name.Click += new System.EventHandler(this.Lab_Name_Click);
            // 
            // Lab_Sex
            // 
            this.Lab_Sex.AutoSize = true;
            this.Lab_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Sex.Location = new System.Drawing.Point(54, 358);
            this.Lab_Sex.Name = "Lab_Sex";
            this.Lab_Sex.Size = new System.Drawing.Size(49, 20);
            this.Lab_Sex.TabIndex = 13;
            this.Lab_Sex.Text = "Sexe:";
            // 
            // Lab_Espece
            // 
            this.Lab_Espece.AutoSize = true;
            this.Lab_Espece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Espece.Location = new System.Drawing.Point(349, 47);
            this.Lab_Espece.Name = "Lab_Espece";
            this.Lab_Espece.Size = new System.Drawing.Size(63, 20);
            this.Lab_Espece.TabIndex = 14;
            this.Lab_Espece.Text = "Espece";
            // 
            // Lab_SousEspece
            // 
            this.Lab_SousEspece.AutoSize = true;
            this.Lab_SousEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_SousEspece.Location = new System.Drawing.Point(563, 47);
            this.Lab_SousEspece.Name = "Lab_SousEspece";
            this.Lab_SousEspece.Size = new System.Drawing.Size(105, 20);
            this.Lab_SousEspece.TabIndex = 15;
            this.Lab_SousEspece.Text = "Sous-Espece";
            // 
            // Lab_Age
            // 
            this.Lab_Age.AutoSize = true;
            this.Lab_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Age.Location = new System.Drawing.Point(54, 421);
            this.Lab_Age.Name = "Lab_Age";
            this.Lab_Age.Size = new System.Drawing.Size(38, 20);
            this.Lab_Age.TabIndex = 16;
            this.Lab_Age.Text = "Age";
            // 
            // Lab_Statut
            // 
            this.Lab_Statut.AutoSize = true;
            this.Lab_Statut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Statut.Location = new System.Drawing.Point(54, 491);
            this.Lab_Statut.Name = "Lab_Statut";
            this.Lab_Statut.Size = new System.Drawing.Size(53, 20);
            this.Lab_Statut.TabIndex = 17;
            this.Lab_Statut.Text = "Statut";
            // 
            // Pic_Animal
            // 
            this.Pic_Animal.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pic_Animal.ErrorImage")));
            this.Pic_Animal.Image = global::Zoo_Raph.Properties.Resources.who;
            this.Pic_Animal.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pic_Animal.InitialImage")));
            this.Pic_Animal.Location = new System.Drawing.Point(46, 47);
            this.Pic_Animal.Name = "Pic_Animal";
            this.Pic_Animal.Size = new System.Drawing.Size(222, 196);
            this.Pic_Animal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Animal.TabIndex = 18;
            this.Pic_Animal.TabStop = false;
            // 
            // Lab_Famille
            // 
            this.Lab_Famille.AutoSize = true;
            this.Lab_Famille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Famille.Location = new System.Drawing.Point(349, 122);
            this.Lab_Famille.Name = "Lab_Famille";
            this.Lab_Famille.Size = new System.Drawing.Size(67, 20);
            this.Lab_Famille.TabIndex = 19;
            this.Lab_Famille.Text = "Famille: ";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 582);
            this.Controls.Add(this.Lab_Famille);
            this.Controls.Add(this.Pic_Animal);
            this.Controls.Add(this.Lab_Statut);
            this.Controls.Add(this.Lab_Age);
            this.Controls.Add(this.Lab_SousEspece);
            this.Controls.Add(this.Lab_Espece);
            this.Controls.Add(this.Lab_Sex);
            this.Controls.Add(this.Lab_Name);
            this.Controls.Add(this.Btn_Retour);
            this.Name = "Information";
            this.Text = "Informations détaillées";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Retour;
        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_Sex;
        private System.Windows.Forms.Label Lab_Espece;
        private System.Windows.Forms.Label Lab_SousEspece;
        private System.Windows.Forms.Label Lab_Age;
        private System.Windows.Forms.Label Lab_Statut;
        private System.Windows.Forms.PictureBox Pic_Animal;
        private System.Windows.Forms.Label Lab_Famille;
    }
}