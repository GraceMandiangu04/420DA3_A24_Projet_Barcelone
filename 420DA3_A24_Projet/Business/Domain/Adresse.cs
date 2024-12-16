namespace _420DA3_A24_Projet.Business.Domain;


public class Adresse {
    public int AdresseId { get; set; }
    public string TypeAdresse { get; set; } = null!;
    public string Destinataire { get; set; } = null!;
    public string NumeroCivique { get; set; } = null!;
    public string Rue { get; set; } = null!;
    public string Ville { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string Pays { get; set; } = null!;
    public string CodePostal { get; set; } = null!;
    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    
    public Adresse() { }

    
    public Adresse(string typeAdresse, string destinataire, string numeroCivique, string rue, string ville, string province, string pays, string codePostal) {
        TypeAdresse = typeAdresse;
        Destinataire = destinataire;
        NumeroCivique = numeroCivique;
        Rue = rue;
        Ville = ville;
        Province = province;
        Pays = pays;
        CodePostal = codePostal;
    }

   
    public override string ToString() {
        return $"{NumeroCivique} {Rue}, {Ville}, {Province}, {CodePostal}, {Pays}";
    }
}
