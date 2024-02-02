using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CarDealership.HealthChecks
{
    public class CustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            //throw new NotImplementedException();

            var isHealthy = false;

            if (isHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("A healthy result."));
            }

            return Task.FromResult(new HealthCheckResult(context.Registration.FailureStatus, "An unhealthy result."));
        }
    }
}
