using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PatientList.Models
{
    public class PatientDataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new PatientDbContext(serviceProvider.GetRequiredService<DbContextOptions<PatientDbContext>>());
            // Look for any todos.
            if (context.PatientDatas.Any())
            {
                //if we get here then the data already seeded
                return;
            }

            using (StreamReader r = new StreamReader(@"F:\L&D\PatientListDemo\PatientList\PatientList\Data\PatientData.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Root>(json);
                context.PatientDatas.AddRange(items.PatientData);
            }
            context.SaveChanges();
        }
    }
}
