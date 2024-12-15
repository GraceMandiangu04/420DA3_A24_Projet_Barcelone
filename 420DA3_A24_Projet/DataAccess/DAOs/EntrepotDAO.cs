using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class EntrepotDAO {

    private WsysDbContext context;

    public EntrepotDAO(WsysDbContext context) {

        this.context = context;
    }

    public List<Entrepot> Search(String criterion) {
        return this.context.Entrepots
            .Where(e => e.nomEntrepot.Contains(criterion) || e.adresse.Contains(criterion))
            .Include(e => e.Produit)
            .ToList();

    }

    public Entrepot Insert(Entrepot entrepot) {
        _=this.context.Entrepots.Add(entrepot);
        _ = this.context.SaveChanges();
        return entrepot;
    }

    public Entrepot Update(Entrepot entrepot) {
        _ = this.context.Entrepots.Update(entrepot);
        _ = this.context.SaveChanges();
        return entrepot;
    }

    public Entrepot Delete(Entrepot entrepot) {
        _ = this.context.Entrepots.Remove(entrepot);
        _ = this.context.SaveChanges();
        return entrepot;
    }





}
