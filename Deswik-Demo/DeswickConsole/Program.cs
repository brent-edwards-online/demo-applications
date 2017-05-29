namespace DeswickConsole
{
    using DataAccess;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataAccess.Entities.RecipeDbContext())
            {
                try
                {
                    DataAccess.Repositories.RecipeRepository repo = new DataAccess.Repositories.RecipeRepository(context);
                    DataAccess.Entities.Recipe r = new DataAccess.Entities.Recipe();
                    r.name = "Big Mac";
                    repo.Create(r);
                    DataAccess.Repositories.UnitOfWork u = new DataAccess.Repositories.UnitOfWork(context);
                    u.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                
            }

            Console.WriteLine("End of application");
            Console.ReadKey();
        }
    }
}
