using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> Categories { get; }
    }
}

