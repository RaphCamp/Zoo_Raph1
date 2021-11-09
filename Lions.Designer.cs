
namespace Zoo_Raph
{
    partial class Lions
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
            System.Windows.Forms.Button Btn_Leo;
            System.Windows.Forms.Button Btn_Hercule;
            this.Btn_Retour = new System.Windows.Forms.Button();
            this.Pic_Leo = new System.Windows.Forms.PictureBox();
            this.Pic_Hercule = new System.Windows.Forms.PictureBox();
            Btn_Leo = new System.Windows.Forms.Button();
            Btn_Hercule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Leo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hercule)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Leo
            // 
            Btn_Leo.Location = new System.Drawing.Point(355, 238);
            Btn_Leo.Name = "Btn_Leo";
            Btn_Leo.Size = new System.Drawing.Size(233, 37);
            Btn_Leo.TabIndex = 7;
            Btn_Leo.Text = "Leo";
            Btn_Leo.UseVisualStyleBackColor = true;
            Btn_Leo.Click += new System.EventHandler(this.Btn_Leo_Click);
            // 
            // Btn_Hercule
            // 
            Btn_Hercule.Location = new System.Drawing.Point(44, 238);
            Btn_Hercule.Name = "Btn_Hercule";
            Btn_Hercule.Size = new System.Drawing.Size(233, 37);
            Btn_Hercule.TabIndex = 5;
            Btn_Hercule.Text = "Hercule";
            Btn_Hercule.UseVisualStyleBackColor = true;
            Btn_Hercule.Click += new System.EventHandler(this.Btn_Hercule_Click);
            // 
            // Btn_Retour
            // 
            this.Btn_Retour.Location = new System.Drawing.Point(746, 501);
            this.Btn_Retour.Name = "Btn_Retour";
            this.Btn_Retour.Size = new System.Drawing.Size(125, 38);
            this.Btn_Retour.TabIndex = 8;
            this.Btn_Retour.Text = "Retour";
            this.Btn_Retour.UseVisualStyleBackColor = true;
            this.Btn_Retour.Click += new System.EventHandler(this.Btn_Retour_Click);
            // 
            // Pic_Leo
            // 
            this.Pic_Leo.Image = global::Zoo_Raph.Properties.Resources.Léo;
            this.Pic_Leo.Location = new System.Drawing.Point(355, 33);
            this.Pic_Leo.Name = "Pic_Leo";
            this.Pic_Leo.Size = new System.Drawing.Size(233, 209);
            this.Pic_Leo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Leo.TabIndex = 6;
            this.Pic_Leo.TabStop = false;
            // 
            // Pic_Hercule
            // 
            this.Pic_Hercule.Image = global::Zoo_Raph.Properties.Resources.Hercule;
            this.Pic_Hercule.Location = new System.Drawing.Point(44, 33);
            this.Pic_Hercule.Name = "Pic_Hercule";
            this.Pic_Hercule.Size = new System.Drawing.Size(233, 209);
            this.Pic_Hercule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Hercule.TabIndex = 4;
            this.Pic_Hercule.TabStop = false;
            // 
            // Lions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 569);
            this.Controls.Add(this.Btn_Retour);
            this.Controls.Add(Btn_Leo);
            this.Controls.Add(this.Pic_Leo);
            this.Controls.Add(Btn_Hercule);
            this.Controls.Add(this.Pic_Hercule);
            this.Name = "Lions";
            this.Text = "Les lions";
            this.Load += new System.EventHandler(this.Lions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Leo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Hercule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Leo;
        private System.Windows.Forms.PictureBox Pic_Hercule;
        private System.Windows.Forms.Button Btn_Retour;
    }
}