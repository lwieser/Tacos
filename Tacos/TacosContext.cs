using System;
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
            var list = _context.Tacos.ToList();
            foreach (var l in list)
            {
                Console.WriteLine($"{l.Id} : {l.Name}");
            }
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
            Console.WriteLine("Saisir l'id du tacos");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le nom du tacos");
            var name = Console.ReadLine();
            var tacos = Get(id);
            tacos.Name = name;
            _context.SaveChanges();
        }

        private Tacos Get(int id)
        {
            return _context.Tacos.Single(x => x.Id == id);
        }

        public void Remove()
        {
            Console.WriteLine("Saisir l'id du tacos");
            var id = int.Parse(Console.ReadLine());
            var tacos = Get(id);
            _context.Remove(tacos);
            _context.SaveChanges();
        }
    }

    public class TacosContext:DbContext
    {
        public DbSet<Tacos> Tacos { get; set; }
        
        public TacosContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = "server=localhost;port=3307;database=tacos;uid=tacos;password=tacos;TreatTinyAsBoolean=false";
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }

    }
}