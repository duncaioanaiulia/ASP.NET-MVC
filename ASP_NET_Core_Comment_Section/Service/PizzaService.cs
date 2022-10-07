using ASP_NET_Core_Comment_Section.Models;

namespace ASP_NET_Core_Comment_Section.Service
{
    public static class PizzaService
    {

        static List<Pizza> Pizzas { get; }
        static int nextId = 3;

        static PizzaService()
        {
            Pizzas = new List<Pizza>() {
                new Pizza{ Id=1, Name="Italia", IsGlutenFree = false},
                new Pizza{ Id=2, Name="Veggie", IsGlutenFree=true}
            };
        }

        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(x => x.Id == id);

        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void Update(Pizza pizza)
        {
            var index =Pizzas.FindIndex (x => x.Id == pizza.Id);
            if (index == -1)
                return;
            Pizzas[index] = pizza;
        }
    }
}
