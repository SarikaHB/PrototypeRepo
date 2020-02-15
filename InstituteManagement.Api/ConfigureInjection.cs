using InstitueManagement.DataAccess.MongoDb.Repository;
using InstituteManagement.DataAccess.Sql.Repository;
using InstituteManagement.Domain.Logics;
using Microsoft.Extensions.DependencyInjection;

namespace InstituteManagement.Api
{
    public static class ConfigureInjection
    {
        public static void BindAll(IServiceCollection services)
        {
            #region Domain
            services.AddTransient<IStudentServices, StudentServices>();
            #endregion

            #region DataAccess
            services.AddTransient<IStudentRepository, StudentRepository>();
            #endregion
        }
    }
}
