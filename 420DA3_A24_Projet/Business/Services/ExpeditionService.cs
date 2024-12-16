using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;

namespace _420DA3_A24_Projet.Business.Services;

internal class ExpeditionService {

    private readonly ExpeditionDAO expeditionDAO;

    public ExpeditionService(WsysApplication parentApp, WsysDbContext context) {
        this.expeditionDAO = new ExpeditionDAO(context);
    }

    public Expedition? GetById(int id) {
        return this.expeditionDAO.GetById(id);
    }

    public List<Expedition> GetAll() {
        return this.expeditionDAO.GetAll();
    }

    public Expedition Create(Expedition expedition) {
        return this.expeditionDAO.Create(expedition);
    }

    public Expedition Update(Expedition expedition) {
        return this.expeditionDAO.Update(expedition);
    }

    public Expedition Delete(Expedition expedition) {
        return this.expeditionDAO.Delete(expedition);
    }
}
