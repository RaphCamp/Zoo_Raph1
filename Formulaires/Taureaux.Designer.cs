
namespace Zoo_Raph
{
    partial class Taureaux
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
            System.Windows.Forms.Button Arnold;
            System.Windows.Forms.Button Btn_Steakos;
            this.Btn_Retour = new System.Windows.Forms.Button();
            this.Pic_Steakos = new System.Windows.Forms.PictureBox();
            this.Pic_Arnold = new System.Windows.Forms.PictureBox();
            Arnold = new System.Windows.Forms.Button();
            Btn_Steakos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Steakos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Arnold)).BeginInit();
            this.SuspendLayout();
            // 
            // Arnold
            // 
            Arnold.Location = new System.Drawing.Point(70, 252);
            Arnold.Name = "Arnold";
            Arnold.Size = new System.Drawing.Size(233, 37);
            Arnold.TabIndex = 1;
            Arnold.Text = "Arnold";
            Arnold.UseVisualStyleBackColor = true;
            Arnold.Click += new System.EventHandler(this.Arnold_Click);
            // 
            // Btn_Steakos
            // 
            Btn_Steakos.Location = new System.Drawing.Point(381, 252);
            Btn_Steakos.Name = "Btn_Steakos";
            Btn_Steakos.Size = new System.Drawing.Size(233, 37);
            Btn_Steakos.TabIndex = 3;
            Btn_Steakos.Text = "Steakos";
            Btn_Steakos.UseVisualStyleBackColor = true;
            Btn_Steakos.Click += new System.EventHandler(this.Btn_Steakos_Click);
            // 
            // Btn_Retour
            // 
            this.Btn_Retour.Location = new System.Drawing.Point(678, 552);
            this.Btn_Retour.Name = "Btn_Retour";
            this.Btn_Retour.Size = new System.Drawing.Size(125, 38);
            this.Btn_Retour.TabIndex = 4;
            this.Btn_Retour.Text = "Retour";
            this.Btn_Retour.UseVisualStyleBackColor = true;
            this.Btn_Retour.Click += new System.EventHandler(this.Btn_Retour_Click);
            // 
            // Pic_Steakos
            // 
            this.Pic_Steakos.Image = global::Zoo_Raph.Properties.Resources.Steakos;
            this.Pic_Steakos.Location = new System.Drawing.Point(381, 48);
            this.Pic_Steakos.Name = "Pic_Steakos";
            this.Pic_Steakos.Size = new System.Drawing.Size(233, 209);
            this.Pic_Steakos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Steakos.TabIndex = 2;
            this.Pic_Steakos.TabStop = false;
            // 
            // Pic_Arnold
            // 
            this.Pic_Arnold.Image = global::Zoo_Raph.Properties.Resources.Arnold;
            this.Pic_Arnold.Location = new System.Drawing.Point(70, 48);
            this.Pic_Arnold.Name = "Pic_Arnold";
            this.Pic_Arnold.Size = new System.Drawing.Size(233, 209);
            this.Pic_Arnold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Arnold.TabIndex = 0;
            this.Pic_Arnold.TabStop = false;
            // 
            // Taureaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(839, 601);
            this.Controls.Add(this.Btn_Retour);
            this.Controls.Add(Btn_Steakos);
            this.Controls.Add(this.Pic_Steakos);
            this.Controls.Add(Arnold);
            this.Controls.Add(this.Pic_Arnold);
            this.Name = "Taureaux";
            this.Text = "Les taureaux";
            this.Load += new System.EventHandler(this.Taureaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Steakos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Arnold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Arnold;
        private System.Windows.Forms.PictureBox Pic_Steakos;
        private System.Windows.Forms.Button Btn_Retour;
    }
}