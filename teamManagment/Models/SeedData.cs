using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using teamManagment.Data;
using System;
using System.Linq;

namespace teamManagment.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new teamManagmentContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<teamManagmentContext>>()))
        {
            // Look for any Projects.
            if (context.Project.Any())
            {
                return;   // DB has been seeded
            }
            context.Project.AddRange(
                new Project
                {
                    Name = "default",
                    Owner = "Lemira",
                    Members = "all",
                    Start = DateTime.Parse("2012-2-12"),
                    Deadline = DateTime.Parse("2035-8-21"),
                    Budget = 10,
                    CostPerHour = 7,
                    Tasks = "#"
                },
                new Project
                {
                    Name = "Ghostbusters",
                    Owner = "John Doe",
                    Members = "all",
                    Start = DateTime.Parse("1984-3-13"),
                    Deadline = DateTime.Parse("1991-4-10"),
                    Budget = 225,
                    CostPerHour = 8,
                    Tasks = "#"
                },
                new Project
                {
                    Name = "TuT",
                    Owner = "Nata",
                    Members = "all",
                    Start = DateTime.Parse("2019-2-23"),
                    Deadline = DateTime.Parse("2019-4-15"),
                    Budget = 8999,
                    CostPerHour = 9,
                    Tasks = "#"
                },
                new Project
                {
                    Name = "Bravo",
                    Owner = "Ervin",
                    Members = "all",
                    Start = DateTime.Parse("1959-4-15"),
                    Deadline = DateTime.Parse("2004-9-23"),
                    Budget = 56710,
                    CostPerHour = 3,
                    Tasks = "#"
                }
            );
            //context.SaveChanges();
        }
    }
}
