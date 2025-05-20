using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Mango.Services.CouponAPI.Data
{
    //DbContext adalah class dasar (base class) yang disediakan oleh Entity Framework Core (EF Core).
    //Class ini bertanggung jawab untuk mengatur koneksi ke database dan bertindak sebagai bridge
    //antara database dan kode C#
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Saat membuat AppDbContext sebagai turunan dari DbContext,
            //kita harus memberitahu DbContext bagaimana caranya mengatur koneksi ke database.
            //itu dilakukan melalui parameter DbContextOptions<AppDbContext> options

            //Namun, DbContext itu sendiri punya constructor yang menerima DbContextOptions,
            //jadi kita harus meneruskan (pass) parameter tersebut ke constructor parent class
            //menggunakan : base(options).
        }

        public DbSet<Coupon> Coupons { get; set; }
        

    }
}