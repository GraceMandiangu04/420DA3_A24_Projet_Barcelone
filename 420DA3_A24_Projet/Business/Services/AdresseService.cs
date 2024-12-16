using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;

namespace _420DA3_A24_Projet.Business.Services;

internal class AdresseService {

    private readonly AdresseDAO adresseDAO;

    public AdresseService(WsysApplication parentApp, WsysDbContext context) {
        this.adresseDAO = new AdresseDAO(context);
    }

    public Adresse? GetById(int id) {
        return this.adresseDAO.GetById(id);
    }

    public List<Adresse> GetAll() {
        return this.adresseDAO.GetAll();
    }

    public Adresse Create(Adresse adresse) {
        return this.adresseDAO.Create(adresse);
    }

    public Adresse Update(Adresse adresse) {
        return this.adresseDAO.Update(adresse);
    }

    public Adresse Delete(Adresse adresse) {
        return this.adresseDAO.Delete(adresse);
    }
}
