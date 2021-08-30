using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormsApp
{
    /// <summary>
    /// Contains CRUD operations for the database
    /// </summary>
    public class DatabaseHelper
    {
        private static DatabaseContext context;

        /// <summary>
        /// Adds a tech to the database
        /// </summary>
        /// <param name="tech"></param>
        /// <returns></returns>
        public static async Task AddTechAsync(Tech tech)
        {
            await InitDb();
            await context.AddAsync<Tech>(tech);
            context.SaveChanges();
        }

        /// <summary>
        /// Get all techs in the database
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Tech>> GetTechsAsync()
        {
            await InitDb();
            return await context.Techs.ToListAsync();
        }

        /// <summary>
        /// Add a company to the database
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        public static async Task AddCompanyAsync(Company company)
        {
            await InitDb();
            await context.AddAsync<Company>(company);
            context.SaveChanges();
        }

        /// <summary>
        /// Get all the companies in the database
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Company>> GetCompaniesAsync()
        {
            await InitDb();
            return await context.Companies.ToListAsync();
        }

        /// <summary>
        /// Initilise the database
        /// </summary>
        /// <returns></returns>
        private static async Task InitDb()
        {
            if (context != null)
                return;

            context = new DatabaseContext();

            var created = await context.Database.EnsureCreatedAsync();

            // If database was created, add some dummy data
            if (created)
            {
                await context.AddAsync<Tech>(new Tech
                {
                    FirstName = "Terry",
                    LastName = "Smith"
                });
                await context.AddAsync<Tech>(new Tech
                {
                    FirstName = "Jack",
                    LastName = "Kitching"
                });
                await context.AddAsync<Company>(new Company
                {
                    ContactName = "Joe Blow",
                    CompanyName = "Random Company Inc.",
                    Address = "2 Somewhere Rd",
                    Suburb = "Randomsville"
                });
                await context.AddAsync<Company>(new Company
                {
                    ContactName = "Big Barry",
                    CompanyName = "WeMakeStuff co.",
                    Address = "234 ThatRoad Rd",
                    Suburb = "Somewhere Vale"
                });
                await context.SaveChangesAsync();
            }
        }
    }
}
