using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.IO;


namespace lab_30_Northwind_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            // read northwind
            using (var db = new Northwind())
            {
                products = db.Products.OrderBy(p=>p.ProductName).Take(3).ToList();
            }

            products.ForEach(p => Console.WriteLine(p.ProductName));

            // extract Products

            Console.WriteLine("\n\nExtracting To XML\n\n");

            var xml = new XElement("Products",
                from p in products
                select new XElement("Product",
                new XAttribute("ProductID", p.ProductID),
                new XAttribute("Cost", p.Cost),
                new XAttribute("ProductName", p.ProductName)
                ));
            // Write to XML
            Console.WriteLine(xml.ToString());
            // Write to File
            var doc = new XDocument(xml);
            doc.Save("Products.xml");


            // now the test

            Console.WriteLine("\n\nFirstly just read back the raw XML data as a string\n\n");

            Console.WriteLine(File.ReadAllText("Products.xml"));

            // as XML document

            var doc2 = XDocument.Load("Products.xml");



        }
    }


    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            this.Products = new List<Product>();
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }


    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "../../../../data/Northwind.db");
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "../data/Northwind.db");
            
            // use SQLite
            optionsBuilder.UseSqlite($"Filename={path}");
            // use SQL
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=Northwind;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            // filter out discontinued products
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.Discontinued);
        }
    }

    // This class will hold the deserialized object  (casting XML back into List of Products)
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }



}
