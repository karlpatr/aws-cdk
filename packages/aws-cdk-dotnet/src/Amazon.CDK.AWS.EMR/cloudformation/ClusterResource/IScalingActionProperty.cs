using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EMR.cloudformation.ClusterResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html </remarks>
    [JsiiInterface(typeof(IScalingActionProperty), "@aws-cdk/aws-emr.cloudformation.ClusterResource.ScalingActionProperty")]
    public interface IScalingActionProperty
    {
        /// <summary>``ClusterResource.ScalingActionProperty.Market``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-elasticmapreduce-cluster-scalingaction-market </remarks>
        [JsiiProperty("market", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Market
        {
            get;
            set;
        }

        /// <summary>``ClusterResource.ScalingActionProperty.SimpleScalingPolicyConfiguration``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-elasticmapreduce-cluster-scalingaction-simplescalingpolicyconfiguration </remarks>
        [JsiiProperty("simpleScalingPolicyConfiguration", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.ClusterResource.SimpleScalingPolicyConfigurationProperty\"}]}}")]
        object SimpleScalingPolicyConfiguration
        {
            get;
            set;
        }
    }
}