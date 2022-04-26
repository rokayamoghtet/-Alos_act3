using System;

namespace DelaiLivraisonAPI.Models
{
    public class UserV2
    {
        public int Track { get; set; }
        public string ServiceUPS { get; internal set; }
        public string Poids { get; internal set; }
        public string Adresse { get; internal set; }
        public string DateLivré { get; internal set; }
        public string TempsLivré { get; internal set; }
        public string Signé { get; internal set; }
    
    }
}