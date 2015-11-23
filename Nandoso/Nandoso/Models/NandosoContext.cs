using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace Nandoso.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class NandosoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public class MyConfiguration : DbMigrationsConfiguration<NandosoContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;

                this.AutomaticMigrationDataLossAllowed = true;
            }

            //seed database with specials menu items
            protected override void Seed(NandosoContext context)
            {
                var special = new List<Specials>
            {
                new Specials { SpecialName = "Quarter Chicken", SpecialPrice = "$8.90",
                    SpecialDescription = "Small fraction, big reaction." },
                new Specials { SpecialName = "Half Chicken", SpecialPrice = "$12.90",
                    SpecialDescription = "Nothing half hearted here." },
                new Specials { SpecialName = "5 Grilled Tenderloins", SpecialPrice = "$8.90",
                    SpecialDescription = "So tender you'll feel it in your loins." },
                new Specials { SpecialName = "Portuguese Paella", SpecialPrice = "$13.90",
                    SpecialDescription = "Grilled chicken pieces combined with veggie strips, tossed over our spicy rice." },
                new Specials { SpecialName = "8 BBQ Ribs", SpecialPrice = "$11.90",
                    SpecialDescription = "Bite sized chicken on the bone." },
                new Specials { SpecialName = "5 BBQ Wings", SpecialPrice = "$11.90",
                    SpecialDescription = "Reach new heights of enjoyment." },
                new Specials { SpecialName = "Classic Chicken Wrap", SpecialPrice = "$9.90",
                    SpecialDescription = "Trim, taut & terrific tenderloins basted & grilled, dressed with crisp lettuce, tomato & our special light mayo, all quietly nestled in a warm tortilla." },
                new Specials { SpecialName = "Chicken Breast Pita", SpecialPrice = "$10.90",
                    SpecialDescription = "Portuguese passion in a pita with a succulent, skinless chicken breast, crisp iceberg lettuce, cucumber & juicy tomato, topped with our special light mayo." },
                new Specials { SpecialName = "Classic Chicken Breast Burger", SpecialPrice = "$9.90",
                    SpecialDescription = "Sink your teeth into our soft, seeded bun filled with a delicious marinated skinless chicken breast, fresh lettuce, tomato & our special light mayo." },
                new Specials { SpecialName = "Supremo Chicken Breast Burger", SpecialPrice = "$12.90",
                    SpecialDescription = "Combining a freshly baked Portuguese roll, chicken breast, gourmet lettuce, tomato, light mayo & PERi-PERi chutney." },
                new Specials { SpecialName = "Double Breast Burger", SpecialPrice = "$15.90",
                    SpecialDescription = "Two marinated & basted skinless chicken breasts, accompanied by crisp lettuce, tomato & our special light mayo inside a soft, seeded bun." }
            };
                special.ForEach(s => context.Specials.AddOrUpdate(p => p.SpecialName, s));
                context.SaveChanges();
            }
        }

        


        public NandosoContext() : base("name=NandosoContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NandosoContext, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<Nandoso.Models.Specials> Specials { get; set; }
    }
}
