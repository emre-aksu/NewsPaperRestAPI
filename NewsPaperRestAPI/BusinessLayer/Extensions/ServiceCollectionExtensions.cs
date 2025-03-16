using BusinessLayer.Contracts;
using BusinessLayer.Implementation;
using BusinessLayer.Mapping.AutoMapper.Profiles;
using DataAccessLayer.Contracts.IRepositories;
using DataAccessLayer.EntityFrameWork.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            //------------------Profile--------------------------

            services.AddAutoMapper(typeof(AgendaProfile));
            services.AddAutoMapper(typeof(AnnouncementProfile));
            services.AddAutoMapper(typeof(AuthorProfile));
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(EconomyProfile));
            services.AddAutoMapper(typeof(HomeProfile));
            services.AddAutoMapper(typeof(SpecialProfile));
            services.AddAutoMapper(typeof(SportProfile));

            //-------------------Manager-------------------------
            services.AddScoped<IAgendaManager, AgendaManager>();
            services.AddScoped<IAnnouncementManager, AnnouncementManager>();
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IEconomyManager, EconomyManager>();
            services.AddScoped<IHomeManager, HomeManager>();
            services.AddScoped<ISpecialManager, SpecialManager>();
            services.AddScoped<ISportManager, SportManager>();


            //-----------------Repository Registrations----------
            services.AddScoped<IAgendaRepository, AgendaRepository>();
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEconomyRepository, EconomyRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<ISpecialRepository, SpecialRepository>();
            services.AddScoped<ISportRepository, SportRepository>();
        }
    }
}
