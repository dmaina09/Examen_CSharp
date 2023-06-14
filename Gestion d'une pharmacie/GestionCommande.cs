using System;

public interface GestionCommande 
{
   void Reservation (Commande commande);
    void AnnulerCommande(int IdCommande);
    void MiseAjoursEtatCommande(int IdCommande, EtatCommande status);

}
//Implementation des interfaces 
