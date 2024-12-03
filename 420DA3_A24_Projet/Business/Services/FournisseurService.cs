using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service pour la gestion des fournisseurs.
/// </summary>
internal class FournisseurService {
    private readonly WsysDbContext _context;

    public FournisseurService(WsysDbContext context) {
        _context = context;
    }

    /// <summary>
    /// Créer un nouveau fournisseur.
    /// </summary>
    public void Create(Fournisseur fournisseur) {
        _context.Fournisseurs.Add(fournisseur);
        _context.SaveChanges();
    }

    /// <summary>
    /// Récupérer un fournisseur par son identifiant.
    /// </summary>
    public Fournisseur? GetById(int id) {
        return _context.Fournisseurs.Find(id);
    }

    /// <summary>
    /// Récupérer tous les fournisseurs.
    /// </summary>
    public List<Fournisseur> GetAll() {
        return _context.Fournisseurs.ToList();
    }

    /// <summary>
    /// Mettre à jour un fournisseur existant.
    /// </summary>
    public void Update(Fournisseur fournisseur) {
        _context.Fournisseurs.Update(fournisseur);
        _context.SaveChanges();
    }

    /// <summary>
    /// Supprimer un fournisseur par son identifiant.
    /// </summary>
    public void Delete(int id) {
        var fournisseur = _context.Fournisseurs.Find(id);
        if (fournisseur != null) {
            _context.Fournisseurs.Remove(fournisseur);
            _context.SaveChanges();
        }
    }
}
