namespace _420DA3_A24_Projet.Business.Domain;

public class Expedition {
    public int ExpeditionId { get; set; }
    public string ServiceLivraison { get; set; } = null!;
    public string CodeSuivi { get; set; } = null!;
    public int OrdreExpeditionId { get; set; }
    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    
    public Expedition() { }

    
    public Expedition(string serviceLivraison, string codeSuivi, int ordreExpeditionId) {
        ServiceLivraison = serviceLivraison;
        CodeSuivi = codeSuivi;
        OrdreExpeditionId = ordreExpeditionId;
    }

    
    public override string ToString() {
        return $"Expedition #{ExpeditionId} via {ServiceLivraison}, Suivi: {CodeSuivi}";
    }
}
