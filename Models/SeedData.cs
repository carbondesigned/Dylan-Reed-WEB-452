using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using web452_assignment1.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace web452_assignment1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>());
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new ProductItem
                {
                    Name = "Ergonomic Mouse",
                    Description = "Ergonomic mouse with 3 buttons and a scroll wheel",
                    Image = "https://imgs.search.brave.com/qzGhFlQs6rNsf4JXcUKYj4M90BvO7BRNfrLSXffLmcw/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4u/ZW5lcHN0ZXJzLmNv/bS93cC1jb250ZW50/L3VwbG9hZHMvMjAx/Ny8xMC9teG1hc3Rl/cjJzX2VuZXBzdGVy/cy5qcGc",
                    Price = 409.99,
                    CustomerReview = 4.5,

                },
                new ProductItem
                {
                    Name = "Ergonomic Keyboard",
                    Description = "Ergonomic keyboard with 104 keys",
                    Image = "https://imgs.search.brave.com/x1QnTJY9pXjvSkd8Ct37DCqT4GHU-dUq3m-cstLL0p0/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9leHRl/cm5hbC1wcmV2aWV3/LnJlZGQuaXQvWkVt/ck1FSnp6Z2J4R3hv/LUN1UkRvbS1MVmNu/Z29TZTU0cEZvc3d6/S2hXQS5qcGc_YXV0/bz13ZWJwJnM9NGU0/ZDgxZTBmN2ZlNWRh/YmFmMDgyMzU5MGFj/ODQzNjdkNTAwNDJh/Mg",
                    Price = 309.99,
                    CustomerReview = 4.0,
                },
                 new ProductItem
                 {
                     Name = "Ergonomic Chair",
                     Description = "Ergonomic chair with height, back and arm adjustments",
                     Image = "https://imgs.search.brave.com/SCvW-UDSAAxoGfTcFRAoj8mfPNLZwUw0WQLCWOJRKuU/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly93d3cu/b2ZmaWNlcmVzYWxl/LmNvLnVrL3dwLWNv/bnRlbnQvdXBsb2Fk/cy8yMDE4LzA4L0RT/QzAwNzQ5LmpwZw",
                     Price = 5099.99,
                     CustomerReview = 4.5,
                 },
                    new ProductItem
                    {
                        Name = "Ergonomic Monitor",
                        Description = "Ergonomic monitor with 27 inch screen",
                        Image = "https://imgs.search.brave.com/h-xQdkbdEB0NnzMPzl7Eiil2FgXRItCQoGlS6lx_RQc/rs:fit:1200:600:1/g:ce/aHR0cDovL3N0YXRp/YzQuYnVzaW5lc3Np/bnNpZGVyLmNvbS9p/bWFnZS81OWQ3OGFi/OTM1MWNjZjBiMDc4/YjcwMzUtMTIwMC9z/YW1zdW5ncy1jaGc5/MC1pcy1pbmNyZWRp/Ymx5LXdpZGUuanBn",
                        Price = 5099.99,
                        CustomerReview = 4.5,
                    },
                    new ProductItem
                    {
                        Name = "Ergonomic Desk",
                        Description = "Ergonomic desk with height adjustment",
                        Image = "https://imgs.search.brave.com/p8BRFlldOUYobS9vrR3hW_45reE2OozIcn0ztZeiovs/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9pLnBp/bmltZy5jb20vb3Jp/Z2luYWxzL2E2LzI3/L2Y3L2E2MjdmN2Mw/NDI3OTU1YzhmN2Ri/OGNiMDk5MmI0Y2Y2/LmpwZw",
                        Price = 999.99,
                        CustomerReview = 4.5,
                    },
                    new ProductItem
                    {
                        Name = "Ergonomic Headphones",
                        Description = "Ergonomic headphones with noise cancelling and bluetooth",
                        Image = "https://imgs.search.brave.com/Q8tTJ3zYnggwgLmSqK74h30VzrPfHJh1emR2s93ISWc/rs:fit:1200:923:1/g:ce/aHR0cHM6Ly93d3cu/aGl0ZWNoY2VudHVy/eS5jb20vd3AtY29u/dGVudC91cGxvYWRz/LzIwMjAvMDkvc3Vw/ZXItY2xvc2UuanBn",
                        Price = 999.99,
                        CustomerReview = 4.5,
                    },
                                             new ProductItem
                                             {
                                                 Name = "Ergonomic Desk Lamp",
                                                 Description = "Ergonomic desk lamp with adjustable height and brightness",
                                                 Image = "https://imgs.search.brave.com/VQQCfirZlGAbnDppVBad4Jj3PwTBHWu4ohGU4zOlygw/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9pNS53/YWxtYXJ0aW1hZ2Vz/LmNvbS9hc3IvN2Jl/NzZjMTAtMDFjMi00/NTI1LWFiNTgtMDcw/MGMzODQ1ODNmXzEu/ZDBhZjcwMjZkMjkx/YmRiNDU2MTRmYmI4/MDdmNTZlYzMuanBl/Zw",
                                                 Price = 999.99,
                                                 CustomerReview = 4.5,
                                             },
                    new ProductItem
                    {
                        Name = "Ergonomic Desk Clock",
                        Description = "Ergonomic desk clock with 3 levels of brightness",
                        Image = "https://imgs.search.brave.com/UrmPdx5cJ9PAtV04emtb921HJ6ZsD4T-nhJjfm1OstE/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA2/MDYvNTMyNS9wcm9k/dWN0cy9CcmVndWV0/X1BlcnBldHVhbF9D/YWxlbmRhcl9BcnRf/RGVjb19EZXNrX0Ns/b2NrX2F0X0FfQ29s/bGVjdGVkX01hbl9M/b25kb24yLmpwZz92/PTE1NDY4NzkyNzQ",
                        Price = 999.99,
                        CustomerReview = 4.5,
                    },
                    new ProductItem
                    {
                        Name = "Ergonomic Desk Mat",
                        Description = "Ergonomic desk mat with wrist support",
                        Image = "https://imgs.search.brave.com/5b0M16REziPT0TQ6DJjT-UCt9_e0J6bDktjVxbZiK5c/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9ibG9n/LmljaGliYW5lbGVj/dHJvbmljLmNvbS93/cC1jb250ZW50L3Vw/bG9hZHMvMjAyMC8w/My9Hcm92ZW1hZGUt/V29vbC1GZWx0LURl/c2stUGFkLTAxLmpw/Zw",
                        Price = 999.99,
                        CustomerReview = 4.5,
                    },
                    new ProductItem
                    {
                        Name = "Ergonomic Desk Organizer",
                        Description = "Ergonomic desk organizer with 3 compartments",
                        Image = "https://imgs.search.brave.com/gBYvt3ZObm7OrIE_sM_Gt4zZ2B6pAnmnKp_j7VjbCzY/rs:fit:1024:1024:1/g:ce/aHR0cHM6Ly9tZWRp/YTEucG9wc3VnYXIt/YXNzZXRzLmNvbS9m/aWxlcy90aHVtYm9y/L0Z1LUJvdF9qVkVZ/a2FNQTZHbkJHSEpC/QllGYy9maXQtaW4v/MTAyNHgxMDI0L2Zp/bHRlcnM6Zm9ybWF0/X2F1dG8tISEtOnN0/cmlwX2ljYy0hIS0v/MjAyMC8wMS8yOC85/NTUvbi8xOTIyNDQx/LzZkM2I0MDdmMmQz/MjAwNGJfbmV0aW1n/QTZ6aE9EL2kvWmVu/LUJhbWJvby1EZXNr/LU9yZ2FuaXplci5q/cGc",
                        Price = 999.99,
                        CustomerReview = 4.5,
                    }
            );
            context.SaveChanges();
        }
    }
}

