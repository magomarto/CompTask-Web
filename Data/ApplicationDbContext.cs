using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompTask_Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    /*// Tabela de Tarefas
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Configuração padrão do Identity

            // Configuração da entidade Task
            modelBuilder.Entity<Task>(entity =>
            {
                // Chave primária
                entity.HasKey(t => t.Id);

                // Relacionamento com ApplicationUser
                entity.HasOne(t => t.User)
                    .WithMany(u => u.Tasks)
                    .HasForeignKey(t => t.UserId)
                    .OnDelete(DeleteBehavior.Cascade); // Opcional: define exclusão em cascata

                // Configurações adicionais (ex: índices)
                entity.HasIndex(t => t.DueDate);
                entity.HasIndex(t => t.Priority);
            });

            
            );
        }*/
}
