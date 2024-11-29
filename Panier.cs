using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2024_Labo
{
    /// <summary>
    /// La classe Panier est une version simplifiée des paniers que l'on peut retrouver
    /// sur les sites d'achat en ligne
    /// </summary>
    public class Panier
    {
        public List<Item> items;

        /// <summary>
        /// Le constructeur initialise la liste de ses items
        /// </summary>
        public Panier()
        {

        }
        /// <summary>
        /// Lorsque l'item est déjà dans le panier on modifie sa quantité
        /// Dans les autres cas on ajoute l'item avec la quantité désirée à la liste des items du panier
        /// </summary>
        /// <param name="item">L'item à ajouter</param>
        /// <param name="quantite">La quantité ne peut pas être plus petite que 1</param>
        public void AjouterItem(Item item, int quantite)
        {

        }

        /// <summary>
        /// Calcul le prix total du panier (sans les taxes)
        /// On peut utiliser la méthode CalculerTotal de la classe Item pour simplifier un peu les calculs
        /// </summary>
        /// <returns>Prix du panier selon les items et leurs quantités</returns>
        public double CalculerTotal()
        {
            double total = 0;

            return total;
        }
    }
}
