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
    public partial class Information : Form
    {

        private ZOO_RaphEntities2 MesDonnees;

        public Information(string animalName, Image animalImage)
        {
            //instanciation de la bdd
            MesDonnees = new ZOO_RaphEntities2();
            //Récupération des information de l'animal
            List<Zoo_Raph.Animaux> Infos = MesDonnees.Animaux.ToList();
            int Index = Infos.FindIndex(i => i.Nom == animalName);
            //Récupération des informations de l'espèce de l'animal
            List<Zoo_Raph.Especes> Infos_Espece = MesDonnees.Especes.ToList();
            int Index_Espece = Infos_Espece.FindIndex(i => i.EspeceAnimal == Infos[Index].Espece);

            InitializeComponent();
            //Informations relatives à l'animal
            this.Lab_Name.Text = "Nom: " + animalName;
            this.Lab_Sex.Text = "Sexe: " + Infos[Index].Sexe ;
            this.Lab_Espece.Text = "Espèce: " + Infos[Index].Espece;
            this.Lab_SousEspece.Text = "Sous-espèce: " + Infos[Index].Sous_espece;
            this.Lab_Age.Text = "Age: " + Infos[Index].Age;
            this.Lab_Statut.Text = "Statut: " + Infos[Index].Statut;
            this.Pic_Animal.Image = animalImage;
            //Informations relatives à son espèce
            this.Lab_Famille.Text = "Famille: " + Infos_Espece[Index_Espece].Famille; 
            this.Lab_SousFamille.Text = "Sous-Famille: " + Infos_Espece[Index_Espece].Sous_famille;
            this.Lab_Classe.Text = "Classe: " + Infos_Espece[Index_Espece].Classe;
            this.Lab_Regime.Text = "Régime alimentaire: " + Infos_Espece[Index_Espece].régime;
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Text_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Information_Load_1(object sender, EventArgs e)
        {

        }

        private void Lab_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
