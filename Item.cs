using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2024_Labo
{
    /// <summary>
    /// La classe item représente un item disponible dans un magasin
    /// Elle sert également à construire le panier de l'utilisateur
    /// </summary>
    public class Item
    {
        public string nom;
        public double prix;
        public string magasin;
        public int quantite;

        /// <summary>
        /// Construit l'item en utilisant les paramètres du même nom que les attributs
        /// Le paramètre quantité est optionnel, 1 par défaut
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prix"></param>
        /// <param name="magasin"></param>
        /// <param name="quantite"></param>
        public Item(string nom, double prix, string magasin, int quantite = 1)
        {

        }

        /// <summary>
        /// Calcul le prix total pour cet item en utilisant son prix et la quantité désirée
        /// </summary>
        /// <returns></returns>
        public double CalculerTotal()
        {
            return 0;
        }

        /// <summary>
        /// Donne un string qui résume les informations du procuit
        /// </summary>
        /// <returns>le résumé des infos pour affichage</returns>
        public override string ToString()
        {
            // IF raccourci, se lit : SI nom a moins de 12 lettres ALORS extraPad = 10 SINON extrapad = 0
            int extraPad = this.nom.Length < 12 ? 10 : 0;

            // Ajout d'espace blancs après le nom pour égaliser les colonnes
            return this.nom.PadRight(this.nom.Length + extraPad) + "\t" + this.quantite + "\t" + CalculerTotal();
        }
    }
}
