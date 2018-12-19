using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class StoreDataInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            new List<Category>()
            {
                new Category() { Name = "Telefon" },
                new Category() { Name = "Bilgisayar" },
                new Category() { Name = "Tablet" },
                new Category() { Name = "Kitap" },
                new Category() { Name = "Eğitim" }
            }.ForEach(i => context.Categories.Add(i));
            context.SaveChanges();

            new List<Product>()
            {
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=1, isApproved = true},
                new Product() {Name = "Samsung S6",Description = "idare eder", Price=900, CategoryId=1},
                new Product() {Name = "Samsung S7",Description = "idare eder", Price=800, CategoryId=1, isApproved = true},
                new Product() {Name = "IPhone 5",Description = "ikinci el", Price=1000, CategoryId=1},
                new Product() {Name = "IPhone 6",Description = "sıfır", Price=1200, CategoryId=1, isApproved = true},
                new Product() {Name = "IPhone 6S",Description = "idare eder", Price=2000, CategoryId=1},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=2},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=2, isApproved = true},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=2},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=2, isApproved = true},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=2},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=2},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=1},
                new Product() {Name = "Web Api Eğitimi : Single Page Application",Description = "web servisler", Price=500, CategoryId=3},
                new Product() {Name = "Web Api Eğitimi : KnockoutJS - AngularJS",Description = "web servisler JS", Price=600, CategoryId=4, isApproved = true},
                new Product() {Name = "IPhone 5",Description = "ikinci el", Price=1000, CategoryId=1},
                new Product() {Name = "Gün Olur Asra Bedel",Description = "Cengiz Aytmatov", Price=30, CategoryId=4},
                new Product() {Name = "1984",Description = "George Orwell", Price=20, CategoryId=4},
                new Product() {Name = "BOZKURTLAR",Description = "H.Nihal Atsız", Price=50, CategoryId=4},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=4, isApproved = true},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=3},
                new Product() {Name = "Samsung S5",Description = "idare eder", Price=800, CategoryId=3},
                new Product() {Name = "IPad Pro",Description = "isıfır", Price=4000, CategoryId=3},
                new Product() {Name = "IPad Mini",Description = "ikinci el", Price=3000, CategoryId=3}
            }.ForEach(i => context.Products.Add(i));
            context.SaveChanges();

            new List<Order>()
            {
                new Order() { UserName = "dogancanalptekin", TotalPrice = 100},
                new Order() { UserName = "dogancanalptekin1", TotalPrice = 200},
                new Order() { UserName = "dogancanalptekin2", TotalPrice = 300},
                new Order() { UserName = "dogancanalptekin3", TotalPrice = 500}
            }.ForEach(i => context.Orders.Add(i));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
