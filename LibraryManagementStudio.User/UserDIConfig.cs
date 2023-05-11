using Autofac;
using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Services;
using LibraryManagementStudio.User.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.User;

public static class UserDIConfig
{
    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        //dbContext
        builder.RegisterType<LibraryDbContext>().AsSelf();
        builder.RegisterType<DbContextOptions<LibraryDbContext>>().AsSelf().InstancePerLifetimeScope();
        
        //services
        builder.RegisterType<UserAuthService>().As<IUserAuthService>();
        builder.RegisterType<UserBookService>().As<IUserBookService>();
        builder.RegisterType<UserBookCopyService>().As<IUserBookCopyService>();
        builder.RegisterType<UserBookBorrowService>().As<IUserBookBorrowService>();
        builder.RegisterType<UserPenaltyService>().As<IUserPenaltyService>();
        builder.RegisterType<EmailService>().As<IEmailService>();

        return builder.Build();
    }
}