namespace DataAccess.Repositories
{
    using Entities;

    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
