using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface ICatergoryRepo
    {
        IEnumerable<Category> Categories { get;  }
    }
}

