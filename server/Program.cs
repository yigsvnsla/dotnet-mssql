using Microsoft.EntityFrameworkCore;
using Server.Models.ProductModel;
using Server.Interfaces;
using Server.Contexts.ProductDbCtx;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddDbContext<ProductDbCtx>(opt => opt.UseInMemoryDatabase("DefaultConnection"));

var app = builder.Build();

// Get list

app.MapGet("/product", async (ProductDbCtx db) => await db.Products.ToListAsync());

// Get One

app.MapGet("/product/{id}", async (ProductDbCtx db, int id) => await db.Products.FindAsync(id));

// Post

app.MapPost("/product", async (ProductDbCtx db, ProductModel product) =>
{
    await db.Products.AddAsync(product);
    await db.SaveChangesAsync();
    return Results.Created($"/products/{product.Id}", product);
});


// Put
app.MapPut("/product/{id}", async (ProductDbCtx db, ProductModel updateProduct, int id) =>
{
    var product = await db.Products.FindAsync(id);
    if (product is null) return Results.NotFound();
    product.Title = updateProduct.Title;
    product.Description = updateProduct.Description;
    product.Price = updateProduct.Price;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/product/{id}", async (ProductDbCtx db, int id) =>
{
   var product = await db.Products.FindAsync(id);
   if (product is null) return Results.NotFound();
   db.Products.Remove(product);
   await db.SaveChangesAsync();
   return Results.Ok();
});

app.MapGet("/", () => "Hello World!");

app.Run();
