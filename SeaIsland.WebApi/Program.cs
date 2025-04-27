using Microsoft.EntityFrameworkCore;
using SeaIsland.BusinessLayer.Abstract;
using SeaIsland.BusinessLayer.Concrete;
using SeaIsland.DataAccessLayer.Abstract;
using SeaIsland.DataAccessLayer.Concrete;
using SeaIsland.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal,EfAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal,EfBookingDal>(); 

builder.Services.AddScoped<ICategoryService, CategoryManager>();    
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();   

builder.Services.AddScoped<IContactService, ContactManager>();  
builder.Services.AddScoped<IContactDal,EfContactDal>(); 

builder.Services.AddScoped<IDiscountService, DiscountManager>();    
builder.Services.AddScoped<IDiscountDal,EfDiscountDal>();    

builder.Services.AddAutoMapper(typeof(Program));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));


    }
    
    );
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
