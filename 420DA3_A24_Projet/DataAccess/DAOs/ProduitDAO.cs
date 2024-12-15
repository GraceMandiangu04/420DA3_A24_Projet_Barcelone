using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ProduitDAO {

    private WsysDbContext context;

    public ProduitDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<Produit>Search(string citerion) {
        return this.context.Produits
            .Where(p => p.nomFichierProduit.Contains(citerion) || p.descriptionproduit.Contains(citerion))
            .Include(p => p.fournisseur)
            .ToList();
    }

    public Produit Insert(Produit produit) {
        _ = this.context.Produits.Add(produit);
        _ = this.context.SaveChanges();
        return produit;
    }

    public Produit Update(Produit produit) {
        _ = this.context.Produits.Update(produit);
        _ = this.context.SaveChanges();
        return produit;
    }

    public Produit Delete(Produit produit) {
        _ = this.context.Produits.Remove(produit);
        _ = this.context.SaveChanges();
        return produit;
    }
}
