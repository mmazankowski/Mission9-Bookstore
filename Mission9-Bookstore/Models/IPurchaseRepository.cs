using System;
using System.Linq;
using Mission9_Bookstore.Models;

namespace Mission9_Bookstore.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        public void SavePurchase(Purchase purchase);
    }
}
