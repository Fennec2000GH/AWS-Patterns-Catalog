
using Amazon.EC2;
using Amazon.Runtime;

namespace AWSPatternsCatalog;

public class Ec2ClientFactory : ClientFactory
{
    public override AmazonServiceClient GetClient()
    {
        return new AmazonEC2Client(region: regionEndpoint);
    }
}

