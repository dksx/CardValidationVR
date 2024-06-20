﻿using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CardValidation.Api.Shared;

internal sealed class BasicHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken) => Task.FromResult(HealthCheckResult.Healthy("Healthy"));
}
