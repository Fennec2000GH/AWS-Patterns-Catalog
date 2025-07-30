

using Amazon;
using Amazon.Runtime;

namespace AWSPatternsCatalog;

public abstract class ClientFactory
{
    internal readonly RegionEndpoint regionEndpoint;

    /// <summary>
    /// Constructs base of factory for producing AWS service clients.
    /// </summary>
    /// <param name="region">
    /// Long form of region name e.g. us-east-1. Defaults to us-east-1.
    /// </param>
    public ClientFactory(string regionName = "us-east-1")
    {
        regionEndpoint = RegionEndpoint.GetBySystemName(systemName: regionName);
    }
    public abstract AmazonServiceClient GetClient();
}
