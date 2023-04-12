using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace eTickets.Data.Services
{
    //    public class ActorsService : IActorsService
    //    {
    //        private readonly ApplicationDbContext _context;

    //        public ActorsService(ApplicationDbContext context)
    //        {
    //            _context = context;
    //        }

    //        public async Task AddAsync(Actor actor)
    //        {
    //            await _context.Actors.AddAsync(actor);
    //            await _context.SaveChangesAsync();
    //        }

    //        public async Task DeleteAsync(int id)
    //        {
    //            var actor = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
    //             _context.Actors.Remove(actor);
    //            await _context.SaveChangesAsync();
    //        }

    //        public async Task<IEnumerable<Actor>> GetAllAsync()
    //        {
    //            var actors = await _context.Actors.ToListAsync();
    //            return actors;
    //        }

    //        public async Task<Actor> GetByIdAsync(int id)
    //        {
    //            var actor = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
    //            return actor;
    //        }

    //        public async Task<Actor> UpdateAsync(int id, Actor newActor)
    //        {
    //            _context.Actors.Update(newActor);
    //           await _context.SaveChangesAsync();
    //            return newActor;
    //        }
    //    }
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context) { }
    }
}