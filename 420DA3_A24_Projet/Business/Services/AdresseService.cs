using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class AdresseService {
    private readonly WsysDbContext _context;

    public AdresseService(WsysDbContext context) {
        _context = context;
    }

    public void Create(Adresse adresse) {
        _context.Adresses.Add(adresse);
        _context.SaveChanges();
    }

    public Adresse? GetById(int id) {
        return _context.Adresses.Find(id);
    }

    public void Update(Adresse adresse) {
        _context.Adresses.Update(adresse);
        _context.SaveChanges();
    }

    public void Delete(int id) {
        var adresse = _context.Adresses.Find(id);
        if (adresse != null) {
            _context.Adresses.Remove(adresse);
            _context.SaveChanges();
        }
    }
}