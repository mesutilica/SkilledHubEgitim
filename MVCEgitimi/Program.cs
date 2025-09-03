using MVCEgitimi.Models;

namespace MVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // Uygulamada MVC controller view yapýsýný kullanacaðýz

            builder.Services.AddDbContext<UyeContext>(); // projede kullanacaðýmýz dbcontext sýnýfýmýzý uygulamaya tanýtýyoruz.

            builder.Services.AddSession(); // bu uygulamada session kullanýmýný aktif et

            var app = builder.Build(); // builder nesnesi üzerinden eklenen servislerle beraber app onesnesi oluþturuluyor

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) // uygulama develeopment yani lokaldeki geliþtirme ortamýnda deðilse
            {
                app.UseExceptionHandler("/Home/Error"); // global hata yakalamayý kullan ve oluþan hatalarda kullanýcýyý burada yazan ekrana yönlendir
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // http den https ye otomatik yönlendire yap
            app.UseRouting(); // Uygulamada Routing mekanizmasýný aktif et

            app.UseAuthorization(); // Uygulamada yetkilendirme kullanýmýný aktif et

            app.UseSession(); // uygulamada session kullanýlabilsin

            app.MapStaticAssets(); // wwwroot klasöründeki statik dosylaraý haritala
            app.MapControllerRoute( // route yapýsýný aþaðýdaki ayarlarla kullan
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}") // adres çubuðunda beklediðimiz url yapýsý
                .WithStaticAssets();

            app.Run(); // uygulamayý yukarýdaki yapýlandýrmalarla çalýþtýr.
        }
    }
}
