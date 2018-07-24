using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.EC2.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html </remarks>
    [JsiiClass(typeof(VPCCidrBlockResource), "@aws-cdk/aws-ec2.cloudformation.VPCCidrBlockResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/cdk.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"properties\",\"type\":{\"fqn\":\"@aws-cdk/aws-ec2.cloudformation.VPCCidrBlockResourceProps\"}}]")]
    public class VPCCidrBlockResource : Resource
    {
        public VPCCidrBlockResource(Construct parent, string name, IVPCCidrBlockResourceProps properties): base(new DeputyProps(new object[]{parent, name, properties}))
        {
        }

        protected VPCCidrBlockResource(ByRefValue reference): base(reference)
        {
        }

        protected VPCCidrBlockResource(DeputyProps props): base(props)
        {
        }

        /// <summary>The CloudFormation resource type name for this resource class.</summary>
        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public static string ResourceTypeName
        {
            get;
        }

        = GetStaticProperty<string>(typeof(VPCCidrBlockResource));
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeInstanceMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}