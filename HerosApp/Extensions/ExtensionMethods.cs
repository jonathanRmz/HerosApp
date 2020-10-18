using Microsoft.EntityFrameworkCore;

namespace HerosApp.Extensions
{
    public static class ExtensionMethods
    {
        public static void LowercaseRelationalTableAndPropertyNames(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToLowerInvariant());

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToLowerInvariant());
                }
            }
        }
    }
}
