using Person.Model;

namespace Person.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            app.MapGet("person", () => new PersonModel(name:"Gabriel"));
        }
    }
}
