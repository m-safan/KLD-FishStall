using Microsoft.EntityFrameworkCore;

namespace KLDFishStall.Model.Models
{
    public partial class KLDFishStallContext : DbContext
    {
        public KLDFishStallContext()
        {
        }

        public KLDFishStallContext(DbContextOptions<KLDFishStallContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Fish> Fish { get; set; }
        public virtual DbSet<FishAttributes> FishAttributes { get; set; }
        public virtual DbSet<FishCategory> FishCategory { get; set; }
        public virtual DbSet<FishImage> FishImage { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Category__737584F628C7DDDD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Fish>(entity =>
            {
                entity.HasIndex(e => e.FkIdFishAttributes)
                    .HasName("UQ__Fish__CF96F83C3E148DF2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkIdFishAttributes).HasColumnName("FK_ID_FishAttributes");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.FkIdFishAttributesNavigation)
                    .WithOne(p => p.Fish)
                    .HasForeignKey<Fish>(d => d.FkIdFishAttributes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Fish__FK_ID_Fish__164452B1");
            });

            modelBuilder.Entity<FishAttributes>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherNames).HasMaxLength(200);

                entity.Property(e => e.Units).HasMaxLength(50);
            });

            modelBuilder.Entity<FishCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkIdCategory).HasColumnName("FK_ID_Category");

                entity.Property(e => e.FkIdFish).HasColumnName("FK_ID_Fish");

                entity.HasOne(d => d.FkIdCategoryNavigation)
                    .WithMany(p => p.FishCategory)
                    .HasForeignKey(d => d.FkIdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FishCateg__FK_ID__1CF15040");

                entity.HasOne(d => d.FkIdFishNavigation)
                    .WithMany(p => p.FishCategory)
                    .HasForeignKey(d => d.FkIdFish)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FishCateg__FK_ID__1BFD2C07");
            });

            modelBuilder.Entity<FishImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FkIdFish).HasColumnName("FK_ID_Fish");

                entity.HasOne(d => d.FkIdFishNavigation)
                    .WithMany(p => p.FishImage)
                    .HasForeignKey(d => d.FkIdFish)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FishImage__FK_ID__1920BF5C");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkIdUserConfirmedBy).HasColumnName("FK_ID_User_ConfirmedBy");

                entity.Property(e => e.FkIdUserDeleveredBy).HasColumnName("FK_ID_User_DeleveredBy");

                entity.Property(e => e.FkIdUserOrderedBy).HasColumnName("FK_ID_User_OrderedBy");

                entity.HasOne(d => d.FkIdUserConfirmedByNavigation)
                    .WithMany(p => p.OrderFkIdUserConfirmedByNavigation)
                    .HasForeignKey(d => d.FkIdUserConfirmedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__FK_ID_Use__24927208");

                entity.HasOne(d => d.FkIdUserDeleveredByNavigation)
                    .WithMany(p => p.OrderFkIdUserDeleveredByNavigation)
                    .HasForeignKey(d => d.FkIdUserDeleveredBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__FK_ID_Use__25869641");

                entity.HasOne(d => d.FkIdUserOrderedByNavigation)
                    .WithMany(p => p.OrderFkIdUserOrderedByNavigation)
                    .HasForeignKey(d => d.FkIdUserOrderedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__FK_ID_Use__239E4DCF");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FkIdFish).HasColumnName("FK_ID_Fish");

                entity.Property(e => e.FkIdOrder).HasColumnName("FK_ID_Order");

                entity.HasOne(d => d.FkIdFishNavigation)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.FkIdFish)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__FK_ID__29572725");

                entity.HasOne(d => d.FkIdOrderNavigation)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.FkIdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderItem__FK_ID__286302EC");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__User__A9D10534FC6C6806")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
