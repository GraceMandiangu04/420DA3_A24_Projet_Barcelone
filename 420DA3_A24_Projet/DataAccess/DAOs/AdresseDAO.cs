using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class AdresseDAO {

    private readonly WsysDbContext context;

    public AdresseDAO(WsysDbContext context) {
        this.context = context;
    }

    public Adresse? GetById(int id) {
        return this.context.Adresses
            .FirstOrDefault(adresse => adresse.AdresseId == id && adresse.DateSuppression == null);
    }

    public List<Adresse> GetAll() {
        return this.context.Adresses
            .Where(adresse => adresse.DateSuppression == null)
            .ToList();
    }

    public Adresse Create(Adresse adresse) {
        this.context.Adresses.Add(adresse);
        this.context.SaveChanges();
        return adresse;
    }

    public Adresse Update(Adresse adresse) {
        adresse.DateModification = DateTime.Now;
        this.context.Adresses.Update(adresse);
        this.context.SaveChanges();
        return adresse;
    }

    public Adresse Delete(Adresse adresse) {
        adresse.DateSuppression = DateTime.Now;
        this.context.Adresses.Update(adresse);
        this.context.SaveChanges();
        return adresse;
    }
}
