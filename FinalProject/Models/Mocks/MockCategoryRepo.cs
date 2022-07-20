using System;
using System.Collections.Generic;

namespace FinalProject.Models.Mocks
{
    public class MockCategoryRepo : ICatergoryRepo
    {


        public IEnumerable<Category> Categories

        {
            get

            {
                return new List<Category>
                {
                    new Category { Name = "Skulls", Description = "All Skulls" },
                    new Category { Name = "Small Bones", Description = "All Small Bones" },
                    new Category { Name = "Jewlery", Description = "All Jewlery" },
                    new Category { Name = "Macrame", Description = "All Macrame" }
                };
            }
        }
    }
}