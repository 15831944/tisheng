using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RepositoryOfXA.Dal.Entities.Mappings
{
   public class OperatorEntityMapping: EntityTypeConfiguration<Operator>
    {
        public OperatorEntityMapping()
        {
            this.HasKey(t => t.Ope_Id);

            this.ToTable("OperatorTable");

            this.Property(t => t.Ope_Id).HasColumnName("Ope_Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(t => t.Ope_Name).HasColumnName("Ope_Name").HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(50).IsRequired();
            this.Property(t => t.Ope_Account).HasColumnName("Ope_Account").HasColumnType(SqlDbType.NVarChar.ToString()).IsRequired();
            this.Property(t => t.Ope_Ifuse).HasColumnName("Ope_Ifuse").HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            this.Property(t => t.Ope_PassWord).HasColumnName("Ope_PassWord").HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(200).IsRequired();
        }
    }
}
