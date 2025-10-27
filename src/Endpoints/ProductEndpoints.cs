namespace BugStore.Endpoints
{
    public static class ProductEndpoints
    {
        public static void MapProductEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/v1/products").WithTags("Products");
            group.MapGet("/", () => "Hello World!").WithDescription("Get all products");
            group.MapGet("/{id}", () => "Hello World!").WithDescription("Get product by id");
            group.MapPost("/", () => "Hello World!").WithDescription("Create a new product");
            group.MapPut("/{id}", () => "Hello World!").WithDescription("Update product by id");
            group.MapDelete("/{id}", () => "Hello World!").WithDescription("Delete product by id");
        }
    }
}