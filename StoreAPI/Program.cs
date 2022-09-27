using StoreAPI.Clients;
using StoreAPI.Configurations;
using StoreAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IVendorClient, VendorClient>();
builder.Services.AddSingleton<IVendorService, VendorService>();

builder.Services.AddHttpClient(HttpClientNames.VENDOR_CLIENT_NAME, client =>
{
    VendorApiConfiguration vendorApiConfiguration = builder.Configuration.GetSection("VendorApi").Get<VendorApiConfiguration>();
    client.BaseAddress = new Uri(vendorApiConfiguration.Uri);
    client.DefaultRequestHeaders.Add(vendorApiConfiguration.KeyHeader, vendorApiConfiguration.KeyValue);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
