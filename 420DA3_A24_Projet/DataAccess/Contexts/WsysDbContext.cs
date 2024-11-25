﻿using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Domain.Pivots;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class WsysDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public DbSet<Entrepot> Entrepots { get; set; }

    public DbSet<Produit> Produits { get; set; }

    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<ShippingOrderProduct> ShippingOrderProducts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseSqlServer("") // TODO: Add connection string
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);


        #region USER

        _ = modelBuilder.Entity<User>()
            .ToTable(nameof(this.Users))
            .HasKey(user => user.Id);

        _ = modelBuilder.Entity<User>()
            .HasIndex(user => user.Username)
            .IsUnique(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Id)
            .HasColumnName(nameof(User.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Username)
            .HasColumnName(nameof(User.Username))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({User.USERNAME_MAX_LENGTH})")
            .HasMaxLength(User.USERNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.PasswordHash)
            .HasColumnName(nameof(User.PasswordHash))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({User.PASSWORDHASH_MAX_LENGTH})")
            .HasMaxLength(User.PASSWORDHASH_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.EmployeeWarehouseId)
            .HasColumnName(nameof(User.EmployeeWarehouseId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateCreated)
            .HasColumnName(nameof(User.DateCreated))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateModified)
            .HasColumnName(nameof(User.DateModified))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateDeleted)
            .HasColumnName(nameof(User.DateDeleted))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.RowVersion)
            .HasColumnName(nameof(User.RowVersion))
            .HasColumnOrder(7)
            .IsRowVersion();


        // TODO @PROF Faire config User-Warehouse 

        #endregion

        #region ROLE

        _ = modelBuilder.Entity<Role>()
            .ToTable(nameof(this.Roles))
            .HasKey(role => role.Id);

        _ = modelBuilder.Entity<Role>()
            .HasIndex(role => role.Name)
            .IsUnique(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Id)
            .HasColumnName(nameof(Role.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Name)
            .HasColumnName(nameof(Role.Name))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Role.NAME_MAX_LENGTH})")
            .HasMaxLength(Role.NAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Description)
            .HasColumnName(nameof(Role.Description))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Role.DESCRIPTION_MAX_LENGTH})")
            .HasMaxLength(Role.DESCRIPTION_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateCreated)
            .HasColumnName(nameof(Role.DateCreated))
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateModified)
            .HasColumnName(nameof(Role.DateModified))
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateDeleted)
            .HasColumnName(nameof(Role.DateDeleted))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName(nameof(Role.RowVersion))
            .HasColumnOrder(6)
            .IsRowVersion();


        #endregion

        #region ENTREPOT

        _ = modelBuilder.Entity<Entrepot>()
            .ToTable(nameof(this.Entrepots))
            .HasKey(entrepot => entrepot.id);

        _ = modelBuilder.Entity<Entrepot>()
            .Property(entrepot => entrepot.id)
            .HasColumnName(nameof(Entrepot.id))
            .HasColumnOrder(0)
            .HasColumnType("int");


        _ = modelBuilder.Entity<Entrepot>()
            .Property(Entrepot => Entrepot.nomEntrepot)
            .HasColumnName("nomEntrepot")
            .HasColumnOrder(1)
            .HasColumnType($"nVarchar({Entrepot.NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Entrepot>()
           .Property(Entrepot => Entrepot.adresse)
           .HasColumnName("adresse")
           .HasColumnOrder(2)
           .HasColumnType($"nVarchar({Entrepot.ADRESSE_MAX_LENGTH})")
           .IsRequired(true);

        _ = modelBuilder.Entity<Entrepot>()
           .Property(Entrepot => Entrepot.DateCreated)
           .HasColumnName("DateCreated")
           .HasColumnOrder(3)
           .HasColumnType("datetime2(5)") 
           .HasPrecision(5) 
           .HasDefaultValueSql("GETUTCDATE()") 
           .IsRequired(true);

        _ = modelBuilder.Entity<Entrepot>()
            .Property(Entrepot => Entrepot.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(5)")
            .HasPrecision(5)
            .IsRequired(false); 

        _ = modelBuilder.Entity<Entrepot>()
            .Property(Entrepot => Entrepot.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(5)")
            .HasPrecision(5)
            .IsRequired(false);

        _ = modelBuilder.Entity<Entrepot>()
            .Property( Entrepot => Entrepot.RowVersion)
            .HasColumnOrder(6)
            .HasColumnName("RowVersion")
            .IsRowVersion();

        #endregion

        #region Produit

        _ = modelBuilder.Entity<Produit>()
            .ToTable(nameof(this.Produits))
            .HasKey(Produit => Produit.Id);

        _ = modelBuilder.Entity<Produit>()
            .Property(Produit => Produit.Id)
            .HasColumnName(nameof(Produit.Id))
            .HasColumnOrder(0)
            .HasColumnType("int");


        _ = modelBuilder.Entity<Produit>()
            .Property(Produit => Produit.nomproduit)
            .HasColumnName("nomproduit")
            .HasColumnOrder(1)
            .HasColumnType($"nVarchar")
            .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
           .Property(Produit => Produit.descriptionproduit)
           .HasColumnName("descriptionproduit")
           .HasColumnOrder(2)
           .HasColumnType($"nVarchar")
           .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
           .Property(Produit=> Produit.codeUpcinternational)
           .HasColumnName("codeUpcinternational")
           .HasColumnOrder(3)
           .HasColumnType($"nVarchar")
           .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
           .Property(Produit => Produit.nomFichierProduit)
           .HasColumnName("nomFichierProduit")
           .HasColumnOrder(4)
           .HasColumnType($"nVarchar")
           .IsRequired(false);

        _ = modelBuilder.Entity<Produit>()
            .Property(Produit => Produit.proprietaireProduit)
            .HasColumnName("proprietaireProduit")
            .HasColumnOrder(5)
            .HasColumnType("$nVarchar")
            .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
            .Property(Produit => Produit.fournisseur)
            .HasColumnName("fournisseur")
            .HasColumnOrder(6)
            .HasColumnType("$nVarchar")
            .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
           .Property(Produit => Produit.codeProduitFournisseur)
           .HasColumnName("codeProduitFournisseur")
           .HasColumnOrder(7)
           .HasColumnType("$nVarchar")
           .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
          .Property(Produit => Produit.qteStock)
          .HasColumnName("Quantité en stock")
          .HasColumnOrder(8)
          .HasColumnType("int")
          .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
         .Property(Produit => Produit.qteStockVise)
         .HasColumnName("Quantité visée")
         .HasColumnOrder(9)
         .HasColumnType("int")
         .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
         .Property(Produit => Produit.poids)
         .HasColumnName("Poids")
         .HasColumnOrder(10)
         .HasColumnType("Float")
         .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
          .Property(Produit => Produit.dateCreated)
          .HasColumnName("DateCreated")
          .HasColumnOrder(11)
          .HasColumnType("datetime2(5)")
          .HasPrecision(13)
          .HasDefaultValueSql("GETUTCDATE()")
          .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
          .Property(Produit => Produit.dateModified)
          .HasColumnName("DateModified")
          .HasColumnOrder(12)
          .HasColumnType("datetime2(5)")
          .HasPrecision(13)
          .HasDefaultValueSql("GETUTCDATE()")
          .IsRequired(true);

        _ = modelBuilder.Entity<Produit>()
          .Property(Produit => Produit.dateDelete)
          .HasColumnName("DateDeleted")
          .HasColumnOrder(13)
          .HasColumnType("datetime2(5)")
          .HasPrecision(13)
          .HasDefaultValueSql("GETUTCDATE()")
          .IsRequired(true);

        _ = modelBuilder.Entity<Entrepot>()
            .Property(Entrepot => Entrepot.RowVersion)
            .HasColumnOrder(6)
            .HasColumnName("RowVersion")
            .IsRowVersion();



        _ = modelBuilder.Entity<Entrepot>()
            .Property(Entrepot => Entrepot.RowVersion)
            .HasColumnOrder(6)
            .HasColumnName("RowVersion")
            .IsRowVersion();

        #endregion







        #region SHIPPING_ORDER

        EnumToStringConverter<ShippingOrderStatusEnum> ShippingOrderStatusConverter = new EnumToStringConverter<ShippingOrderStatusEnum>();

        _ = modelBuilder.Entity<ShippingOrder>()
            .ToTable(nameof(this.ShippingOrders))
            .HasKey(so => so.Id);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.Id)
            .HasColumnName(nameof(ShippingOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.Status)
            .HasColumnName(nameof(ShippingOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(24)")
            .HasConversion(ShippingOrderStatusConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.SourceClientId)
            .HasColumnName(nameof(ShippingOrder.SourceClientId))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.CreatorEmployeeId)
            .HasColumnName(nameof(ShippingOrder.CreatorEmployeeId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DestinationAddressId)
            .HasColumnName(nameof(ShippingOrder.DestinationAddressId))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.FulfillerEmployeeId)
            .HasColumnName(nameof(ShippingOrder.FulfillerEmployeeId))
            .HasColumnOrder(5)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.ShippingDate)
            .HasColumnName(nameof(ShippingOrder.ShippingDate))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DateCreated)
            .HasColumnName(nameof(ShippingOrder.DateCreated))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DateModified)
            .HasColumnName(nameof(ShippingOrder.DateModified))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.DateDeleted)
            .HasColumnName(nameof(ShippingOrder.DateDeleted))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.RowVersion)
            .HasColumnName(nameof(ShippingOrder.RowVersion))
            .HasColumnOrder(10)
            .IsRowVersion();

        // TODO: @PROF Faire config des relations de ShippingOrder

        #endregion

        #region PURCHASE_ORDER

        EnumToStringConverter<PurchaseOrderStatusEnum> PurchaseOrderStatusConverter = new EnumToStringConverter<PurchaseOrderStatusEnum>();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .ToTable(nameof(this.PurchaseOrders))
            .HasKey(po => po.Id);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Id)
            .HasColumnName(nameof(PurchaseOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Status)
            .HasColumnName(nameof(PurchaseOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(24)")
            .HasConversion(PurchaseOrderStatusConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.Quantity)
            .HasColumnName(nameof(PurchaseOrder.Quantity))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.OrderedProductId)
            .HasColumnName(nameof(PurchaseOrder.OrderedProductId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);


        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DestinationWarehouseId)
            .HasColumnName(nameof(PurchaseOrder.DestinationWarehouseId))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.CompletionDate)
            .HasColumnName(nameof(PurchaseOrder.CompletionDate))
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateCreated)
            .HasColumnName(nameof(PurchaseOrder.DateCreated))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateModified)
            .HasColumnName(nameof(PurchaseOrder.DateModified))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.DateDeleted)
            .HasColumnName(nameof(PurchaseOrder.DateDeleted))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(po => po.RowVersion)
            .HasColumnName(nameof(PurchaseOrder.RowVersion))
            .HasColumnOrder(9)
            .IsRowVersion();

        // TODO: @PROF Faire config des relations de PurchaseOrder

        #endregion

        #region PIVOT - SHIPPING_ORDER_PRODUCTS (PIVOT)

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .ToTable(nameof(this.ShippingOrderProducts))
            .HasKey(sop => new { sop.ShippingOderId, sop.ProductId });

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.ShippingOderId)
            .HasColumnName(nameof(ShippingOrderProduct.ShippingOderId))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.ProductId)
            .HasColumnName(nameof(ShippingOrderProduct.ProductId))
            .HasColumnOrder(1)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.Quantity)
            .HasColumnName(nameof(ShippingOrderProduct.Quantity))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .Property(sop => sop.RowVersion)
            .HasColumnName(nameof(ShippingOrderProduct.RowVersion))
            .HasColumnOrder(3)
            .IsRowVersion();


        // Relations un-à-plusieurs pour ShippingOrder à ShippingOrderProduct
        // et pour Product à ShippingOrderProduct

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .HasOne(sop => sop.ShippingOrder)
            .WithMany(so => so.ShippingOrderProducts)
            .HasForeignKey(sop => sop.ShippingOderId)
            .HasPrincipalKey(so => so.Id);

        _ = modelBuilder.Entity<ShippingOrderProduct>()
            .HasOne(sop => sop.Product)
            .WithMany(product => product.OrgderProducts)
            .HasForeignKey(sop => sop.ProductId)
            .HasPrincipalKey(p => p.Id);

        #endregion

        // TODO: @TOUTE_EQUIPE Faites la configuration de vos entités et de leur relations ici






        #region RELATIONS RE DONNÉES DE TEST

        // Warehouse ici


        // NOTE: le mot de passe des user est "testpasswd".
        User user1 = new User("UserAdmin", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 1
        };
        User user2 = new User("UserOffice", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 2
        };
        // TODO: @PROF assigner une warehouse à user3 quand une warehouse sera ajoutée.
        User user3 = new User("UserWarehouse", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 3
        };
        _ = modelBuilder.Entity<User>().HasData(user1, user2, user3);


        Role adminRole = new Role("Administrateurs",
            "Administrateurs tout-puissants."
        ) {
            Id = Role.ADMIN_ROLE_ID
        };
        Role officeEmployeesRole = new Role("Employés de bureau",
            "Employés travaillant dans les bureaux de WSYS Inc."
        ) {
            Id = Role.OFFICE_EMPLOYEE_ROLE_ID
        };
        Role whEmployeeRole = new Role("Employés d'entrepôt",
            "Employés travaillant dans les entrepôts de WSYS Inc."
        ) {
            Id = Role.WAREHOUSE_EMPLOYEE_ROLE_ID
        };
        _ = modelBuilder.Entity<Role>()
            .HasData(adminRole, officeEmployeesRole, whEmployeeRole);


        // NOTE: doit être placé après l'insertion de données pour User et pour Role
        // (besoin des IDs pour les associations)
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.Users)
            .UsingEntity("UserRoles",
                rightRelation => {
                    return rightRelation.HasOne(typeof(Role)).WithMany().HasForeignKey("RoleId").HasPrincipalKey(nameof(Role.Id));
                },
                leftRelation => {
                    return leftRelation.HasOne(typeof(User)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(User.Id));
                },
                shadowEntityConfig => {
                    _ = shadowEntityConfig.HasKey("UserId", "RoleId");
                    _ = shadowEntityConfig.HasData(
                    new { UserId = 1, RoleId = 1 },
                    new { UserId = 2, RoleId = 2 },
                    new { UserId = 3, RoleId = 3 });
                }
            );
        // Possiblement pas besoin de la relation inverse
        /*
        _ = modelBuilder.Entity<Role>()
            .HasMany(role => role.Users)
            .WithMany(user => user.Roles);
        */

        #endregion

    }

    private object dateTimeUtcConverter(object arg) {
        throw new NotImplementedException();
    }
}
