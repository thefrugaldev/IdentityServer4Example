using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServerQuickStart
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "Clayton's API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",

                    //no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    //secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    //scopes this client has access to
                    AllowedScopes = { "api1" }
                }
            };
        }
    }
}
