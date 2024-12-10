namespace WebApiTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddNewtonsoftJson();

            builder.Services.AddOpenApiDocument();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseOpenApi();

            app.MapControllers();

            app.Run();
        }
    }
}
