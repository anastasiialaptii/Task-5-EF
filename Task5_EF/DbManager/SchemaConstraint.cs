using System.Data.Entity;

namespace Task5_EF.DbManager
{
    public class SchemaConstraint
    {
        public void SetSchemaConstraint(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SupplyFlowerSchema");
        }
    }
}