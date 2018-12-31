using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // DbContext
using app_TWINTER.Global_Constraints; // Constraints;

namespace app_TWINTER.Models
{
    public class twinterContext : DbContext
    {
        public DbSet<BIO> BIOs { get; set; }

        public DbSet<media> medias { get; set; }

        public DbSet<poll> polls { get; set; }

        public DbSet<Stats> stats { get; set; }

        public DbSet<Trandings> trandings { get; set; }

        public DbSet<Twint> twints { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<UserBIO> userBIOs { get; set; }

        public DbSet<UserTwint> UserTwints { get; set; }
    }

    public class twinterDbInitializer : DropCreateDatabaseAlways<twinterContext>
    {
        protected override void Seed(twinterContext db)
        {
            Constants role = new Constants(); // special

            db.users.Add(new User { User1 = "Admin", password = "Lol97NoPassword", email = "noemail@gmil.com" });
            db.users.Add(new User { User1 = "Vlad Ganusceac", password = "97twinter19", email = "vlad.ganuscheak@gmail.com" });
            db.users.Add(new User { User1 = "Timbalist Ana", password = "1234567890Ab", email = "ana.timbalist@gmail.com" });

            db.twints.Add(new Twint { msg = "Wellcome to TWINTER #Welcome #Twinter #Authors #Ganusceac #Timbalist", Location = "Chisinau" });
            db.twints.Add(new Twint { msg = "TIDPP exam is right now #TIDPP #EXAM #presentation #Gavrilita #professor" });

            db.UserTwints.Add(new UserTwint { User_Id = 1, Twint_Id = 1 });
            db.UserTwints.Add(new UserTwint { User_Id = 1, Twint_Id = 2 });

            db.BIOs.Add(new BIO { Location = "Chisinau", Website = "Something.com" });

            db.userBIOs.Add(new UserBIO { User_Id = 1, BIO_Id = 1 });

            db.trandings.Add(new Trandings { Twint_Id = 1, HashTag = "Welcome" });
            db.trandings.Add(new Trandings { Twint_Id = 1, HashTag = "Twinter" });
            db.trandings.Add(new Trandings { Twint_Id = 1, HashTag = "Authors" });
            db.trandings.Add(new Trandings { Twint_Id = 1, HashTag = "Ganusceac" });
            db.trandings.Add(new Trandings { Twint_Id = 1, HashTag = "Timbalist" });
            db.trandings.Add(new Trandings { Twint_Id = 2, HashTag = "TIDPP" });
            db.trandings.Add(new Trandings { Twint_Id = 2, HashTag = "EXAM" });
            db.trandings.Add(new Trandings { Twint_Id = 2, HashTag = "presentation" });
            db.trandings.Add(new Trandings { Twint_Id = 2, HashTag = "Gavrilita" });
            db.trandings.Add(new Trandings { Twint_Id = 2, HashTag = "professor" });


            base.Seed(db);
        }
    }
}