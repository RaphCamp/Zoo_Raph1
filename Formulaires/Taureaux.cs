using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_Raph
{
    public partial class Taureaux : Form
    {
        public Taureaux()
        {
            InitializeComponent();
        }

        private void Btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Arnold_Click(object sender, EventArgs e)
        {
            Information Info = new Information("Arnold", this.Pic_Arnold.Image);
            Info.StartPosition = FormStartPosition.CenterParent;
            Info.ShowDialog();
        }

        private void Btn_Steakos_Click(object sender, EventArgs e)
        {
            Information Info = new Information("Steakos", this.Pic_Steakos.Image);
            Info.StartPosition = FormStartPosition.CenterParent;
            Info.ShowDialog();
        }

        private void Taureaux_Load(object sender, EventArgs e)
        {

        }
    }
}
