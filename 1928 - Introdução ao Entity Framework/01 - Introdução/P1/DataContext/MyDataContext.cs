using P1.Domain;
using System.Data.Entity;

namespace P1.DataContext
{
    public class MyDataContext : DbContext
    {
        public MyDataContext()
            : base("MyConnectionString") => Database.SetInitializer(new Initializer());

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }

    public class Initializer : DropCreateDatabaseAlways<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        {
            context.Categories.Add(new Category { Id = 1, Title = "Treinamento" });
            context.Products.Add(new Product { CategoryId = 1, Title = "EF", Price = 99 });

            context.SaveChanges();
        }
    }
}