using System;
using System.Collections.Generic;
using System.Text;

using Magazine.Core.Models;

namespace Magazine.Core.Services
{
    internal interface IProductService
    {
        Product add(Product product);
        Product remove(Guid id);
        Product edit(Product product);
        Product search(Guid id);
    }
}
