namespace Tacos
{
    public class Composition
    {
        public Tacos Tacos { get; set; }
        public Ingredient Ingredient { get; set; }
        public int TacosId { get; set; }
        public int IngredientId { get; set; }
        public float Weight { get; set; }
    }
}