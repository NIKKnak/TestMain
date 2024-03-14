namespace WebEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.UseWelcomePage();
            //app.Run(async (context) => await context.Response.WriteAsync("Hello METANIT.COM"));
            //app.MapGet("/", () => "Hello World!");

            //app.Run(async (context) => await context.Response.SendFileAsync("C:\\Users\\nik88\\OneDrive\\Desktop\\C# test\\WebEmpty\\Photo\\IMG_1710.JPG"));



            /*app.Run(async (context) =>
            {
                var response = context.Response;
                response.ContentType = "text/html; charset=utf-8";
                await response.WriteAsync("<h2>Hello METANIT.COM</h2><h3>Welcome to ASP.NET Core</h3>");
            });*/

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";

                // если обращение идет по адресу "/postuser", получаем данные формы
                if (context.Request.Path == "/postuser")
                {
                    var form = context.Request.Form;
                    string name = form["name"];
                    string age = form["age"];
                    await context.Response.WriteAsync($"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
                }
                else
                {
                    await context.Response.SendFileAsync("html/index.html");
                }
            });

            app.Run();
        }
    }
}
