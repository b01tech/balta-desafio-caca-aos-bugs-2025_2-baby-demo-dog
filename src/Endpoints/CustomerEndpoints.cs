namespace src.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void MapCustomerEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/v1/customers").WithTags("Customers");
            group.MapGet("/", () => "Hello World!").WithDescription("Get all customers");
            group.MapGet("/{id}", () => "Hello World!").WithDescription("Get customer by id");
            group.MapPost("/", () => "Hello World!").WithDescription("Create a new customer");
            group.MapPut("/{id}", () => "Hello World!").WithDescription("Update customer by id");
            group.MapDelete("/{id}", () => "Hello World!").WithDescription("Delete customer by id");
        }
    }
}