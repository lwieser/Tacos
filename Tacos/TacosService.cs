using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Tacos
{
    public class TacosService
    {
        private readonly TacosContext _context;

        public TacosService()
        {
            _context = new TacosContext();
        }

        public void List()
        {
            var list = _context.Tacos
                .Include(x => x.Ingredients)
                .ToList();
            foreach (var l in list)
            {
                Console.WriteLine($"{l.Id} : {l}");
            }
        }

        public void Reset()
        {
            var tacos = Fetch();
            tacos.Ingredients = new List<Composition>();
            _context.SaveChanges();
        }

        public void Add()
        {
            Console.WriteLine("Saisir le nom du Tacos");
            var name = Console.ReadLine();
            var tacos = new Tacos()
            {
                Name = name
            };
            _context.Tacos.Add(tacos);
            _context.SaveChanges();
        }

        public void Update()
        {
            var tacos = Fetch();
            Console.WriteLine("Saisir le nom du tacos");
            var name = Console.ReadLine();
            tacos.Name = name;
            _context.SaveChanges();
        }

        private Tacos Get(int id)
        {
            return _context.Tacos
                .Include(x => x.Ingredients)
                .Single(tacos => tacos.Id == id);
        }

        public void Remove()
        {
            var tacos = Fetch();
            _context.Remove(tacos);
            _context.SaveChanges();
        }

        public void AddIngredients()
        {
            throw new NotImplementedException();
            // var tacos = Fetch();
            // Console.WriteLine($"Tacos sélectionné {tacos}");
            // Console.WriteLine("Nouvel ingrédient : ");
            // var ing = Console.ReadLine();
            // tacos.Ingredients.Add(new Ingredient()
            // {
            //     Name = ing
            // });
            // _context.SaveChanges();
        }

        private Tacos Fetch()
        {
            List();
            Console.WriteLine("Saisir l'id du tacos");
            var id = int.Parse(Console.ReadLine());
            return Get(id);
        }
    }
}