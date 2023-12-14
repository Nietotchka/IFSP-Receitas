using IFSPReceita.Repository.Context;
using IFSPReceita.Domain.Base;
using IFSPReceita.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IFSPReceita.Domain.Entities;
using IFSPReceitas.App.Outros;
using IFSPReceitas.App.Cadastro;
using IFSPReceita.Service.Services;
using AutoMapper;
using IFSPReceitas.App.Models;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<CategoriaMedicamento>, BaseRepository<CategoriaMedicamento>>();
            Services.AddScoped<IBaseRepository<Medicamento>, BaseRepository<Medicamento>>();
            Services.AddScoped<IBaseRepository<Medico>, BaseRepository<Medico>>();
            Services.AddScoped<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            Services.AddScoped<IBaseRepository<Receita>, BaseRepository<Receita>>();

            // Services
            Services.AddScoped<IBaseService<CategoriaMedicamento>, BaseService<CategoriaMedicamento>>();
            Services.AddScoped<IBaseService<Medicamento>, BaseService<Medicamento>>();
            Services.AddScoped<IBaseService<Medico>, BaseService<Medico>>();
            Services.AddScoped<IBaseService<Paciente>, BaseService<Paciente>>();
            Services.AddScoped<IBaseService<Receita>, BaseService<Receita>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroCategoriaMedicamento, CadastroCategoriaMedicamento>();
            Services.AddTransient<CadastroMedicamento, CadastroMedicamento>();
            Services.AddTransient<CadastroMedico, CadastroMedico>();
            Services.AddTransient<CadastroPaciente, CadastroPaciente>();
            Services.AddTransient<CadastroReceita, CadastroReceita>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriaMedicamento, CategoriaMedicamentoModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Id));
                config.CreateMap<Medicamento, MedicamentoModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Id))
                    .ForMember(d => d.Categoria, d => d.MapFrom(x => x.Categoria));
                config.CreateMap<Medico, MedicoModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Id));
                config.CreateMap<Paciente, PacienteModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Id));
                config.CreateMap<Receita, ReceitaModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Id));
                    
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
