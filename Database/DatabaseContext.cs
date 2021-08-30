using Microsoft.EntityFrameworkCore;
using System;

namespace FormsApp
{
    /// <summary>
    /// Database context
    /// </summary>
    public class DatabaseContext : DbContext
    {
        #region Tables
        public DbSet<Tech> Techs { get; set; }
        public DbSet<Company> Companies { get; set; }
        #endregion

        /// <summary>
        /// Path to the database
        /// </summary>
        public string DbPath { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DatabaseContext()
        {
            var folder = AppContext.BaseDirectory;
            DbPath = $"{folder}{System.IO.Path.DirectorySeparatorChar}app.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite($"Data Source={DbPath}");
    }

    /// <summary>
    /// Contains company data
    /// </summary>
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName {  get; set; }
        public string ContactName {  get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    /// <summary>
    /// Contains tech data
    /// </summary>
    public partial class Tech
    {
        public int TechId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// Contains methods for the tech class
    /// </summary>
    public partial class Tech
    {
        public string Name => $"{FirstName[0]}. {LastName}";
        public string Initials => $"{FirstName[0]}.{LastName[0]}";
    }
}
