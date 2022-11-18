using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using HisoChek.Model;
using HisoChek.Helpers;

namespace HisoChek.Datos
{
    public class Dproductos
    {
        public async Task<List<Mproductos>> MostrarProductos()
        {
            return (await Cconexion.firebase
                .Child("ArtItems")
                .OnceAsync<Mproductos>()).Select(item => new Mproductos
                {
                    Description = item.Object.Description,
                    ImageUrl = item.Object.ImageUrl,
                    Price = item.Object.Price,
                    StockDetail = item.Object.StockDetail,
                    ProductID = item.Key
                }).ToList();
        }
        public async Task<List<Mproductos>> MostrarproductosXid(Mproductos parametros)
        {
            return (await Cconexion.firebase
                .Child("Productos")
                .OnceAsync<Mproductos>())
                .Where(a => a.Key == parametros.ProductID).Select(item => new Mproductos
                {
                    Description = item.Object.Description,
                    ImageUrl = item.Object.ImageUrl,
                    Price = item.Object.Price,
                    StockDetail = item.Object.StockDetail,
                    ProductID = item.Key
                }).ToList();
        }
    }
}
