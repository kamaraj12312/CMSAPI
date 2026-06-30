using HMS.DAL;
using HMS.DAL.Interface;

namespace HMS.Injectors
{
    public class loginInjector
    {
        public static void InjectInjectors(IServiceCollection services)
        {
            services.AddScoped<IIoginService, LoginService>();
        }
    }
}
