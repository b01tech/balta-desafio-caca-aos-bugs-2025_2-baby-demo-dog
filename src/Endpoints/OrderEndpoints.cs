namespace src.Endpoints
{
    public static class OrderEndpoints
    {
        public static void MapOrderEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/v1/orders").WithTags("Orders");
            group.MapGet("/{id}", () => "Hello World!").WithDescription("Get order by id");
            group.MapPost("/", () => "Hello World!").WithDescription("Create a new order");
        }
    }
}