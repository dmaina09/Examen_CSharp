using System;




public interface GestionStock 
{
	void AjouterMedicament(Medicaments medicaments);
	void SupprimerMedicament(int IdMedicament);
	Medicaments GetMedicaments(int IdMedicaments);
	void MisAJourStock(int IdMedicaments, int QuantiteStock);
}

public class LaGestionDeStock : GestionStock
{
    private List<Medicaments> _medicaments;

    // declaration du constructeur 
    public LaGestionDeStock()
    {
        _medicaments = new List<Medicaments>();
    }
    
        //methode ajouter medicament 
        s
    public void AjouterMedicament(Medicaments medicaments) 
    {
        _medicaments.Add(medicaments);
    }

    public Medicaments GetMedicaments(int IdMedicaments)
    {
        throw new NotImplementedException();
    }

    public void MisAJourStock(int IdMedicaments, int QuantiteStock)
    {
        throw new NotImplementedException();
    }

    public void SupprimerMedicament(int IdMedicament)
    {
        throw new NotImplementedException();
    }
}
