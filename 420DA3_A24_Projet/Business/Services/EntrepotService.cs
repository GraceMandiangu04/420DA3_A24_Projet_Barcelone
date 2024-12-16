using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class EntrepotService {

    private EntrepotDAO dAO;

    public EntrepotService(WsysApplication parentApp, WsysDbContext context) {
        this.dAO = new EntrepotDAO(context);
    }

    public List<Entrepot>SearchEntrepots(string criterion) {
        return this.dAO.Search(criterion);
    }

    public Entrepot InsertEntrepot(Entrepot entrepot) {
        return this.dAO.Insert(entrepot);
    }

    public Entrepot UpdateEntrepot(Entrepot entrepot) {
        return this.dAO.Update(entrepot);
    }

    public Entrepot DeleteEntrepot(Entrepot entrepot) {
        return this.dAO.Delete(entrepot);
    }

}
