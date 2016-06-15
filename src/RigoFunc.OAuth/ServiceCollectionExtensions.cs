﻿using System;
using RigoFunc.OAuth;

namespace Microsoft.Extensions.DependencyInjection {
    /// <summary>
    /// Contains extension methods to <see cref="IServiceCollection"/> for configuring OAuth services.
    /// </summary>
    public static class ServiceCollectionExtensions {
        /// <summary>
        /// Adds OAuth server to <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The services available in the application.</param>
        /// <param name="setupAction">An action to configure the <see cref="OAuthOptions"/>.</param>
        /// <returns>The services available in the application.</returns>
        public static IServiceCollection AddOAuth(this IServiceCollection services, Action<OAuthOptions> setupAction) {
            services.AddAuthorization();

            if (setupAction != null) {
                services.Configure(setupAction);
            }

            return services;
        }
    }
}
