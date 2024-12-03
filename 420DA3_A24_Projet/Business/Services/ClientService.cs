using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service pour la gestion des clients.
/// </summary>
public class ClientService {
    private readonly WsysDbContext _context;

    public ClientService(WsysDbContext context) {
        _context = context;
    }

    /// <summary>
    /// Créer un nouveau client.
    /// </summary>
    public void Create(Client client) {
        _context.Clients.Add(client);
        _context.SaveChanges();
    }

    /// <summary>
    /// Récupérer un client par son identifiant.
    /// </summary>
    public Client? GetById(int id) {
        return _context.Clients.Find(id);
    }

    /// <summary>
    /// Récupérer tous les clients.
    /// </summary>
    public List<Client> GetAll() {
        return _context.Clients.ToList();
    }

    /// <summary>
    /// Mettre à jour un client existant.
    /// </summary>
    public void Update(Client client) {
        _context.Clients.Update(client);
        _context.SaveChanges();
    }

    /// <summary>
    /// Supprimer un client par son identifiant.
    /// </summary>
    public void Delete(int id) {
        var client = _context.Clients.Find(id);
        if (client != null) {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}
