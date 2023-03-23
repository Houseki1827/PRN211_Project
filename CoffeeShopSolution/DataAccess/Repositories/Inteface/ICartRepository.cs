using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Inteface {
    public interface ICartRepository {
        IEnumerable<Cart> GetCarts();
        IEnumerable<Cart> GetCartByUserId(int id);
        void AddCartItem(int UserId, String ItemId, int quantity, DateTime OrderDate);
        void DeleteCartItem(int UserId, String ItemId, int quantity, DateTime OrderDate);
    }
}
