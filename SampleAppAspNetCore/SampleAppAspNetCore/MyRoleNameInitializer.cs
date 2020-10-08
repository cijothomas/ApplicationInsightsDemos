using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace SampleAppAspNetCore
{
    internal class MyRoleNameInitializer : ITelemetryInitializer
    {
        private readonly string roleName;
        public MyRoleNameInitializer(string roleName)
        {
            this.roleName = roleName;
        }

        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Cloud.RoleName = this.roleName;
        }
    }
}