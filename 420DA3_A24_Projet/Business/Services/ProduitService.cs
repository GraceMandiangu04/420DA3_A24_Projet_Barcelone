using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ProduitService {
    private ProduitDAO dAO;

    public ProduitService(WsysApplication parentApp, WsysDbContext context) {
        this.dAO = new ProduitDAO(context);
    }

    public List<Produit> SearchProduit(string criterion) {
        return this.dAO.Search(criterion);
    }

    public Entrepot InsertProduit(Produit produit) {
        return this.dAO.Insert(produit);
    }

    public Entrepot UpdateEntrepot(Produit produit) {
        return this.dAO.Update(produit);
    }

    public Entrepot DeleteEntrepot(Entrepot entrepot) {
        return this.dAO.Delete(entrepot);
    }
}
