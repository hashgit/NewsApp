namespace NewsWeb.Repository
{
    public abstract class BaseDataContext
    {
        protected readonly IApplicationDbContext Context;

        protected BaseDataContext(IApplicationDbContext context)
        {
            Context = context;
        }
    }
}