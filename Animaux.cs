//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoo_Raph
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animaux
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Espece { get; set; }
        public string Sous_espece { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }
        public string Statut { get; set; }
    
        public virtual Especes Especes { get; set; }
    }
}
