using System;
using System.ServiceModel.Configuration;

namespace WcfDigitalSignature.Client
{
    public class EchoBehaviorExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(EchoEndpointBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new EchoEndpointBehavior();
        }
    }
}
