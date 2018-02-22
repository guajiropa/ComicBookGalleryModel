using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        public Context()
        {
            // Drop and recreate the database if the model has changed.
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());

            // Create the database if it does not exists.
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());

            // Drop and create the database everytime that the app is ran
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }

        public DbSet<ComicBook> ComicBooks { get; set; }

    }
}
