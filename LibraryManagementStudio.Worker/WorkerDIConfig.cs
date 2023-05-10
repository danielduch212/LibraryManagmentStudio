using Autofac;
using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Services;
using LibraryManagementStudio.Worker.Services.Intrefaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Worker;

public static class WorkerDIConfig
{
    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        //dbContext
        builder.RegisterType<LibraryDbContext>().AsSelf();
        builder.RegisterType<DbContextOptions<LibraryDbContext>>().AsSelf().InstancePerLifetimeScope();
        
        //services
        builder.RegisterType<WorkerBookService>().As<IWorkerBookService>();
        builder.RegisterType<WorkerBookBorrowService>().As<IWorkerBookBorrowService>();
        builder.RegisterType<EmailService>().As<IEmailService>();
        

        return builder.Build();
    }
}