
namespace Zoo_Raph
{
    partial class List_Animaux
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
            this.Btn_Retour = new System.Windows.Forms.Button();
            this.Pic_Animal2 = new System.Windows.Forms.PictureBox();
            this.Pic_Animal1 = new System.Windows.Forms.PictureBox();
            this.Btn_Animal1 = new System.Windows.Forms.Button();
            this.Btn_Animal2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Animal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Animal1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Retour
            // 
            this.Btn_Retour.Location = new System.Drawing.Point(661, 504);
            this.Btn_Retour.Name = "Btn_Retour";
            this.Btn_Retour.Size = new System.Drawing.Size(125, 38);
            this.Btn_Retour.TabIndex = 9;
            this.Btn_Retour.Text = "Retour";
            this.Btn_Retour.UseVisualStyleBackColor = true;
            // 
            // Pic_Animal2
            // 
            this.Pic_Animal2.Image = global::Zoo_Raph.Properties.Resources.who;
            this.Pic_Animal2.Location = new System.Drawing.Point(292, 12);
            this.Pic_Animal2.Name = "Pic_Animal2";
            this.Pic_Animal2.Size = new System.Drawing.Size(233, 209);
            this.Pic_Animal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Animal2.TabIndex = 7;
            this.Pic_Animal2.TabStop = false;
            // 
            // Pic_Animal1
            // 
            this.Pic_Animal1.Image = global::Zoo_Raph.Properties.Resources.who;
            this.Pic_Animal1.Location = new System.Drawing.Point(21, 12);
            this.Pic_Animal1.Name = "Pic_Animal1";
            this.Pic_Animal1.Size = new System.Drawing.Size(233, 209);
            this.Pic_Animal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Animal1.TabIndex = 5;
            this.Pic_Animal1.TabStop = false;
            // 
            // Btn_Animal1
            // 
            this.Btn_Animal1.Location = new System.Drawing.Point(21, 214);
            this.Btn_Animal1.Name = "Btn_Animal1";
            this.Btn_Animal1.Size = new System.Drawing.Size(233, 38);
            this.Btn_Animal1.TabIndex = 10;
            this.Btn_Animal1.Text = "Animal1";
            this.Btn_Animal1.UseVisualStyleBackColor = true;
            // 
            // Btn_Animal2
            // 
            this.Btn_Animal2.Location = new System.Drawing.Point(292, 214);
            this.Btn_Animal2.Name = "Btn_Animal2";
            this.Btn_Animal2.Size = new System.Drawing.Size(233, 38);
            this.Btn_Animal2.TabIndex = 11;
            this.Btn_Animal2.Text = "Animal2";
            this.Btn_Animal2.UseVisualStyleBackColor = true;
            // 
            // List_Animaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 554);
            this.Controls.Add(this.Btn_Animal2);
            this.Controls.Add(this.Btn_Animal1);
            this.Controls.Add(this.Btn_Retour);
            this.Controls.Add(this.Pic_Animal2);
            this.Controls.Add(this.Pic_Animal1);
            this.Name = "List_Animaux";
            this.Text = "List_Animaux";
            this.Load += new System.EventHandler(this.List_Animaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Animal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Animal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Retour;
        private System.Windows.Forms.PictureBox Pic_Animal2;
        private System.Windows.Forms.PictureBox Pic_Animal1;
        private System.Windows.Forms.Button Btn_Animal1;
        private System.Windows.Forms.Button Btn_Animal2;
    }
}