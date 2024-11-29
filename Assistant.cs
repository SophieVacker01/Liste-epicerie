using A2024_Labo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_liste_d_épicerie
{
    /// <summary>
    /// La classe assistant contrôle le logiciel
    /// Elle est en charge d'interagir avec l'utilisateur pour enregistrer ses demandes
    /// 
    /// Le constructeur commence par mettre en mémoire les prix dans le fichier des données(transmis en paramètre)
    /// 
    /// Ensuite la méthode Magasiner() prend en charge les interactions avec l'utilsateur
    /// il a le choix de :
    /// 1. ajouter un item
    /// 2. visualiser le panier
    /// 3. terminer
    /// 
    /// Lorsque l'utilisateur choisi de terminer l'utilisation du logiciel le panier est envoyé dans un fichier
    /// texte au même format que l'affichage
    /// </summary>
    public class Assistant
    {
        public List<Item> donneesMagasins;
        Panier panier;

        /// <summary>
        /// Le constructeur 
        /// - initialise les attributs
        /// - lit le fichier de données et convertit les informations en items
        /// - ajoute les items dans la liste donneesMagasin
        /// </summary>
        /// <param name="cheminFichier">Le chemin complet pour le fichier des données de prix</param>
        public Assistant(string cheminFichier)
        {
            //JE NE SAIS PAS QUOI FAIRE POUR LA LECTURE DU FICHIER
        }
        /// <summary>
        /// Affiche le menu principal à l'utilisateur
        /// Récupère le choix de l'utilisateur et appelle la méthode correspondante
        /// Ajouter un produit : méthode AjouterItem
        /// Voir le panier : méthode AfficherPanier
        /// Terminer : méthode Terminer
        /// </summary>
        public void Magasiner()
        {
            Console.WriteLine("1. Ajouter un item");
            Console.WriteLine("2. Visualiser le panier");
            Console.WriteLine("3. Terminer");
        }

        /// <summary>
        /// Affiche le menu pour ajouter un produit
        /// Demande à l'utilisateur le produit à ajouter et la quantité désirée
        /// Trouve l'item correspondant avec le prix le plus bas dans la liste donneesMagasins
        /// Envoie l'item trouvé et la quantité à la méthode AjouterItem de this.panier
        /// </summary>
        public void AjouterItem()
        {
            Magasiner();
            int choix;
            int.TryParse(Console.ReadLine(), out choix);

            //Afficher le menu
            //Faire console.WriteLine pour afficher une fonction, etc pour afficher
            //Idée: boucle while avec console.clear et console.writeLine pour ne pas accumuler 10 milles menu à la fin
            if (choix == 1)
            {
                Console.WriteLine("1. Viandes");
                Console.WriteLine("2. Fruits");
                Console.WriteLine("3. Légumes");
                Console.WriteLine("4. Produits ménagers");
                Console.WriteLine("5. Produits laitiers");
            }

            //Demander à l'utilisateur le produit à ajouter et la quantité désirée
            //Faire un console.ReadLine à la suite du console.WriteLine si l'utilisateur écrit un 1
            //L'utilisateur choisie un produit et la quantité pour l'ajouter au panier
            Console.WriteLine("Quelle produit voulez-vous ?");
            int item;
            int.TryParse(Console.ReadLine(), out item);

            Console.WriteLine("Combien en voulez-vous ?");
            int nombre;
            int.TryParse(Console.ReadLine(), out nombre);


            //Trouve l'item correspondant avec le prix le plus bas dans le fichier
            //en triant le prix des items en ordre croissant et prendre le plus petit nombre qui est associé au produit
            if (item == 1)
            {

                //Faire le prix fois le nombre de produit qu'elle veux ou
                //Marquer le produit avec sa quantité
                //Envoyer dans le panier pour qu'il soit classer dans le tableau
            }
            else if (item == 2)
            {

            }
            else if (item == 3)
            {

            }
            else if (item == 4)
            {

            }
            else
            {

            }

            //Envoie l'item trouvé et la quantité à la méthode AjouterItem de this.panier
            //Idée pour le panier: 2 tableau-(1 produit, 2 items) ou 1 tableau où on rajoute une case pour produit et quantité
        }

        /// <summary>
        /// Affiche le panier à la console en regroupant les produits par magasin
        /// </summary>
        public void AfficherPanier()
        {
            //Trier selon le nom de l'épicerie
            //Ou peut-être faire un if -> si l'ordinateur l'a trouvé chez maxi, il le met dans un tableau maxi.
            //Donc une case se rajoute pour l'item
            //Afficher le panier
        }

        /// <summary>
        /// Génére un fichier nommé : ListeAssistant.txt
        /// Ce fichier contient le même résumé que le résumé affiché par AfficherPanier
        /// On ajoute le total du panier à la fin du résumé
        /// </summary>
        public void Terminer()
        {
            //JE NE SAIS PAS QUOI FAIRE
        }
    }
}
