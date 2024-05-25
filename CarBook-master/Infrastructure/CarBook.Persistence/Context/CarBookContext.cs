﻿using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.56; Database=CarBookDb; User=sa; Password=QFC7LGmuCJa205; TrustServerCertificate=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RentACar> rentACars { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RentACarProcess>().HasOne(x => x.PickUpLocation).WithMany(y => y.RentACarProcessPickUpLocation).HasForeignKey(z => z.PickUpLocationId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<RentACarProcess>().HasOne(x => x.DropOffLocation).WithMany(y => y.RentACarProcessDropOffLocation).HasForeignKey(z => z.DropOfLocationId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Reservation>().HasOne(x => x.PickUpLocation).WithMany(y => y.ReservationProcessPickUpLocation).HasForeignKey(z => z.PickUpLocationId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Reservation>().HasOne(x => x.DropOffLocation).WithMany(y => y.ReservationProcessDropOffLocation).HasForeignKey(z => z.DropOfLocationId).OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(builder);
        }
    }
}
