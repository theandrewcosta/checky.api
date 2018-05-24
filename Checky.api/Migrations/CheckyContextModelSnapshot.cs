﻿// <auto-generated />
using Checky.api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Checky.api.Migrations
{
    [DbContext(typeof(CheckyContext))]
    partial class CheckyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Checky.api.Model.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("DeviceGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("DeviceName")
                        .IsRequired();

                    b.Property<int>("InventoryId");

                    b.Property<int>("OrganizationId");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("DeviceId");

                    b.HasAlternateKey("DeviceGuid");

                    b.HasIndex("InventoryId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Checky.api.Model.Identity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Checky.api.Model.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("InventoryGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("OrganizationId");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("InventoryId");

                    b.HasAlternateKey("InventoryGuid");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Checky.api.Model.InventoryItem", b =>
                {
                    b.Property<int>("InventoryItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("InventoryId");

                    b.Property<string>("InventoryItemGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("ItemId");

                    b.Property<int>("Quantity");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("InventoryItemId");

                    b.HasAlternateKey("InventoryItemGuid");


                    b.HasAlternateKey("InventoryId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("Checky.api.Model.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Calories");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("ItemGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("VendorId");

                    b.Property<double>("Weight");

                    b.HasKey("ItemId");

                    b.HasAlternateKey("ItemGuid");

                    b.HasIndex("VendorId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Checky.api.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("InventoryId");

                    b.Property<string>("OrderGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

                    b.HasAlternateKey("OrderGuid");

                    b.HasIndex("InventoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Checky.api.Model.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Quantity");

                    b.Property<string>("orderItemGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.HasKey("OrderItemId");

                    b.HasAlternateKey("orderItemGuid");


                    b.HasAlternateKey("OrderId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Checky.api.Model.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("MaxDevices");

                    b.Property<string>("OrganizationGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("OrganizationName")
                        .IsRequired();

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("OrganizationId");

                    b.HasAlternateKey("OrganizationGuid");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Checky.api.Model.OrganizationItem", b =>
                {
                    b.Property<int>("OrganizationItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("ItemId");

                    b.Property<int>("OrganizationId");

                    b.Property<string>("OrganizationItemGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("OrganizationItemId");

                    b.HasAlternateKey("OrganizationItemGuid");


                    b.HasAlternateKey("OrganizationId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("OrganizationItems");
                });

            modelBuilder.Entity("Checky.api.Model.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<bool>("Default")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Details")
                        .IsRequired();

                    b.Property<string>("PaymentMethodGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("UserId");

                    b.HasKey("PaymentMethodId");

                    b.HasAlternateKey("PaymentMethodGuid");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("Checky.api.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("RoleGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("RoleId");

                    b.HasAlternateKey("RoleGuid");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Checky.api.Model.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("OrderId");

                    b.Property<int>("PaymentMethodId");

                    b.Property<double>("Total");

                    b.Property<string>("TransactionGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("TransactionToken")
                        .IsRequired();

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.HasKey("TransactionId");

                    b.HasAlternateKey("TransactionGuid");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Checky.api.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Birthdate");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<int>("OrganizationId");

                    b.Property<string>("Pin")
                        .IsRequired();

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("UserGuid")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasAlternateKey("UserGuid");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Checky.api.Model.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("RoleId");

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<int>("UserId");

                    b.Property<string>("UserRoleGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.HasKey("UserRoleId");

                    b.HasAlternateKey("UserRoleGuid");


                    b.HasAlternateKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Checky.api.Model.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTimeOffset>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("VendorGuid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.HasKey("VendorId");

                    b.HasAlternateKey("VendorGuid");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<string>("ClientSecret");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("ConsentType");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Permissions");

                    b.Property<string>("PostLogoutRedirectUris");

                    b.Property<string>("Properties");

                    b.Property<string>("RedirectUris");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("Properties");

                    b.Property<string>("Scopes");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("OpenIddictAuthorizations");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Properties");

                    b.Property<string>("Resources");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OpenIddictScopes");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("AuthorizationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<DateTimeOffset?>("CreationDate");

                    b.Property<DateTimeOffset?>("ExpirationDate");

                    b.Property<string>("Payload");

                    b.Property<string>("Properties");

                    b.Property<string>("ReferenceId");

                    b.Property<string>("Status");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId")
                        .IsUnique()
                        .HasFilter("[ReferenceId] IS NOT NULL");

                    b.ToTable("OpenIddictTokens");
                });

            modelBuilder.Entity("Checky.api.Model.Device", b =>
                {
                    b.HasOne("Checky.api.Model.Inventory", "Inventory")
                        .WithMany("Devices")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.Organization", "Organization")
                        .WithMany("Devices")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.Inventory", b =>
                {
                    b.HasOne("Checky.api.Model.Organization", "Organization")
                        .WithMany("Inventories")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.InventoryItem", b =>
                {
                    b.HasOne("Checky.api.Model.Inventory", "Inventory")
                        .WithMany("InventoryItems")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.Item", "Item")
                        .WithMany("InventoryItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.Item", b =>
                {
                    b.HasOne("Checky.api.Model.Vendor", "Vendor")
                        .WithMany("Items")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.Order", b =>
                {
                    b.HasOne("Checky.api.Model.Inventory", "Inventory")
                        .WithMany("Orders")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.OrderItem", b =>
                {
                    b.HasOne("Checky.api.Model.Item", "Item")
                        .WithMany("OrderItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.OrganizationItem", b =>
                {
                    b.HasOne("Checky.api.Model.Item", "Item")
                        .WithMany("OrganizationsItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.Organization", "Organization")
                        .WithMany("OrganizationItems")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.PaymentMethod", b =>
                {
                    b.HasOne("Checky.api.Model.User", "User")
                        .WithMany("PaymentMethods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.Transaction", b =>
                {
                    b.HasOne("Checky.api.Model.Order", "Order")
                        .WithOne("Transaction")
                        .HasForeignKey("Checky.api.Model.Transaction", "OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.PaymentMethod", "PaymentMethod")
                        .WithMany("Trancsactions")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.User", b =>
                {
                    b.HasOne("Checky.api.Model.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Checky.api.Model.UserRole", b =>
                {
                    b.HasOne("Checky.api.Model.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Checky.api.Model.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Checky.api.Model.Identity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Checky.api.Model.Identity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Checky.api.Model.Identity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Checky.api.Model.Identity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.Models.OpenIddictAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
