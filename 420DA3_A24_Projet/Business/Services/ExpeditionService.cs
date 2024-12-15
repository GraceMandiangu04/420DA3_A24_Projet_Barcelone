using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ExpeditionService {
    private readonly WsysDbContext _context;

    public ExpeditionService(WsysDbContext context) {
        _context = context;
    }

    public void Create(Expedition expedition) {
        _context.Expeditions.Add(expedition);
        _context.SaveChanges();
    }

    public Expedition? GetById(int id) {
        return _context.Expeditions.Find(id);
    }

    public void Update(Expedition expedition) {
        _context.Expeditions.Update(expedition);
        _context.SaveChanges();
    }

    public void Delete(int id) {
        var expedition = _context.Expeditions.Find(id);
        if (expedition != null) {
            _context.Expeditions.Remove(expedition);
            _context.SaveChanges();
        }
    }
}