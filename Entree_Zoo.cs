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
    public partial class Zoo_Especes : Form
    {
        public Zoo_Especes()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Taureaux_Click(object sender, EventArgs e)
        {
            Taureaux taureaux = new Taureaux();
            taureaux.StartPosition = FormStartPosition.CenterParent;
            taureaux.ShowDialog();
        }

        private void Btn_Lions_Click(object sender, EventArgs e)
        {
            Lions lions = new Lions();
            lions.StartPosition = FormStartPosition.CenterParent;
            lions.ShowDialog();
        }
    }
}
