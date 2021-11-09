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
    public partial class Lions : Form
    {
        public Lions()
        {
            InitializeComponent();
        }

/*        private void Hercule_Click(object sender, EventArgs e)
        {
            Information Info = new Information();
            Info.StartPosition = FormStartPosition.CenterParent;
            Info.ShowDialog();
        }*/

        private void Btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lions_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Hercule_Click(object sender, EventArgs e)
        {
            Information Info = new Information("Hercule", this.Pic_Hercule.Image);
            Info.StartPosition = FormStartPosition.CenterParent;
            Info.ShowDialog();
        }

        private void Btn_Leo_Click(object sender, EventArgs e)
        {
            Information Info = new Information("Leo", this.Pic_Leo.Image);
            Info.StartPosition = FormStartPosition.CenterParent;
            Info.ShowDialog();
        }

        /*        private void Btn_Steakos_Click(object sender, EventArgs e)
                {
                    Information Info = new Information();
                    Info.StartPosition = FormStartPosition.CenterParent;
                    Info.ShowDialog();
                }
        */
    }
}
