using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class ExpeditionDAO {

    private readonly WsysDbContext context;

    public ExpeditionDAO(WsysDbContext context) {
        this.context = context;
    }

    public Expedition? GetById(int id) {
        return this.context.Expeditions
            .FirstOrDefault(exp => exp.ExpeditionId == id && exp.DateSuppression == null);
    }

    public List<Expedition> GetAll() {
        return this.context.Expeditions
            .Where(exp => exp.DateSuppression == null)
            .ToList();
    }

    public Expedition Create(Expedition expedition) {
        this.context.Expeditions.Add(expedition);
        this.context.SaveChanges();
        return expedition;
    }

    public Expedition Update(Expedition expedition) {
        expedition.DateModification = DateTime.Now;
        this.context.Expeditions.Update(expedition);
        this.context.SaveChanges();
        return expedition;
    }

    public Expedition Delete(Expedition expedition) {
        expedition.DateSuppression = DateTime.Now;
        this.context.Expeditions.Update(expedition);
        this.context.SaveChanges();
        return expedition;
    }
}
