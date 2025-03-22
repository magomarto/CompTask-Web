using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CompTask_Web.Models.Entities;
using CompTask_Web.Models.Identity;

namespace CompTask_Web.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<UserTask>(entity =>
                {
                    // Define a relação com o ApplicationUser
                    entity.HasOne(t => t.User)
                        .WithMany(u => u.Tasks) 
                        .HasForeignKey(t => t.UserId) 
                        .OnDelete(DeleteBehavior.Cascade); // EXCLUSÃO DE TAREFAS SE O USUÁRIO FOR DELETADO

                    // Configurações adicionais (exemplo: índice na data de vencimento)
                    entity.HasIndex(t => t.DueDate);

                    // Configura o nome da tabela (opcional)
                    entity.ToTable("Tasks");
                });
            }
        }
    }

}


