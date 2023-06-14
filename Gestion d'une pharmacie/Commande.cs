using System;

//classe commande 
public class Commande
{
    public int IdCommande { get; set; }
    public List<Medicaments>? Medicaments { get; set;}
    public DateTime DateCommande { get; set; }
    public EtatCommande.Status Status { get; set; }
}
