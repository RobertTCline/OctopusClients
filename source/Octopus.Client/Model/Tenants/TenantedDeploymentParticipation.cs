﻿namespace Octopus.Client.Model.Tenants
{
    public enum TenantedDeploymentParticipation
    {
        /// <summary>
        /// Excluded from tenanted deployments
        /// </summary>
        Excluded,

        /// <summary>
        /// Eligible to be included only in tenanted deployments 
        /// </summary>
        IncludedInTenanted,

        /// <summary>
        /// Eligible to be included in tenanted or un-tenanted deployments 
        /// </summary>
        IncludedAlways
    }
}