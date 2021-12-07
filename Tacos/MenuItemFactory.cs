using System.Collections.Generic;

namespace Tacos
{
    public class MenuItemFactory
    {
        public static List<MenuItem> GetItems()
        {
            var ts = new TacosService();
            return new List<MenuItem>()
            {
                new("1", "Liste", ts.List),
                new("2", "Ajouter", ts.Add),
                new("3", "Modifier", ts.Update),
                new("4", "Supprimer", ts.Remove),
                new("5", "Ajouter ingrédients", ts.AddIngredients),
                new("6", "Reset recette", ts.Reset),
            };
        }
    }
}