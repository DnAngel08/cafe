using Coffe_Shiuma.Shared;

namespace Coffe_Shiuma.Server.Models
{
    public static class SeedData
    {
        public static void Initialize(CafeteriaStoreContext context)
        {
            var Specials = new CafeSpecial[]
            {
            new CafeSpecial
            {
            Name = "Cafe espresso",
            Description = "Un shot de espresso con un aroma intenso y un sabor suave.",
            BasePrice = 25.5m,
            ImageUrl = "images/Cafes/espresso.jpg"
            } ,
            new CafeSpecial()
            {
            Name = "Latte de Vainilla",
            Description = "Espresso con leche vaporizada y un toque de deliciosa esencia de vainilla.",
            BasePrice = 35.5m,
            ImageUrl = "images/Cafes/latte.jpg",
            },
            new CafeSpecial()
            {
            Name = "Mocha Frio",
            Description = "Una mezcla de café helado, leche, chocolate y un toque de crema batida por encima.",
            BasePrice = 45.5m,
            ImageUrl = "images/Cafes/mocha.jpg",
            },
            new CafeSpecial()
            {
            Name = "Cappuccino de Caramelo",
            Description = "Espresso suave cubierto con espuma de leche cremosa y un toque dulce de salsa de caramelo.",
            BasePrice = 40.5m,
            ImageUrl = "images/Cafes/caramelo.jpg",
            },
            new CafeSpecial()
            {
            Name = "Frappé de MoKa",
            Description = "Una deliciosa combinación de café helado, chocolate, leche y hielo, todo mezclado hasta obtener una textura suave.",
            BasePrice = 50.5m,
            ImageUrl = "images/Cafes/moka.jpg",
            },
            new CafeSpecial()
            {
            Name = "Té Helado de Frutas",
            Description = "Una refrescante mezcla de té helado con sabores de frutas tropicales como mango, piña y maracuyá.",
            BasePrice = 30.5m,
            ImageUrl = "images/Cafes/te.jpg",
            },
            new CafeSpecial()
            {
            Name = "Smoothie de Fresa y Plátano",
            Description = "Una mezcla cremosa de fresas frescas, plátano maduro, yogur y hielo.",
            BasePrice = 40.5m,
            ImageUrl = "images/Cafes/smoothie.jpg",
            },
            new CafeSpecial()
            {
            Name = "Limonada de Sandía",
            Description = "Una bebida refrescante hecha con jugo de sandía fresca, limón y un toque de menta.",
            BasePrice = 35.5m,
            ImageUrl = "images/Cafes/limonada.jpg",
            }
            };

            
            

            var Bebidas = new Bebida[]
            {
                 new Bebida
                 {
                 Name = "Azucar",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Leche light",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Leche de almendras",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Leche de Soya",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Leche de Coco",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Crema",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Pan",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Chocolate",
                Price = 10.0m
                },
                 new Bebida
                 {
                 Name = "Fruta",
                Price = 20.0m
                 },
                 new Bebida
                 {
                 Name = "Hot cake",
                Price = 20.0m
                 },
                 new Bebida
                 {
                 Name = "Jugo de Naranja",
                Price = 20.0m
                 },
                 new Bebida
                 {
                 Name = "Sandwich",
                Price = 25.0m
                 },
                 new Bebida
                 {
                 Name = "Torta",
                 Price = 25.0m
                 },
                 new Bebida
                 {
                 Name = "Churros",
                Price = 20.0m
                 },
                 new Bebida
                 {
                 Name = "cupcake",
                Price = 20.0m
                 },
                 new Bebida
                 {
                 Name = "Pastel",
                Price = 25.0m
                 },
                 new Bebida
                 {
                 Name = "Empanada",
                Price = 30.0m
                 },
                 new Bebida
                 {
                 Name = "Flan",
                 Price = 25.0m
                 },
                 new Bebida
                 {
                 Name = "Mantequilla",
                Price = 15.0m
                 },
                new Bebida
                 {
                 Name = "Mermelada",
                Price = 10.0m
                 },
                 new Bebida
                 {
                 Name = "Cajeta",
                Price = 10.0m
                 }
            };
            context.Specials.AddRange(Specials);
            context.Toppings.AddRange(Bebidas);
            context.SaveChanges();
        }
    }
}
