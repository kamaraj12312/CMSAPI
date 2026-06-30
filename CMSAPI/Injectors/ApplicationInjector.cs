using HMS.DAL;
using HMS.DAL.Interface;

namespace HMS.Injectors
{
    public class ApplicationInjector
    {
        public static void InjectInjectors(IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
        }
    }
}
