namespace DollarComputerStore
{
  using System.Data.Entity;

  public partial class StoreModel : DbContext
  {
    public StoreModel()
        : base("name=StoreModel")
    {
    }

    public virtual DbSet<products> products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<products>()
          .Property(e => e.cost)
          .HasPrecision(19, 4);
    }
  }
}
