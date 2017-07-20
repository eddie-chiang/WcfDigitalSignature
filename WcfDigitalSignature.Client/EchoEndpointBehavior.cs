using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Security;

namespace WcfDigitalSignature.Client
{
    public class EchoEndpointBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            // Sign only the header, but not the body.

            // This does not work.
            //endpoint.Contract.ProtectionLevel = System.Net.Security.ProtectionLevel.Sign;
            //foreach (OperationDescription operation in endpoint.Contract.Operations)
            //{
            //    MessageDescription requestMessage = operation.Messages.First(msg => msg.Direction == MessageDirection.Input);

            //    foreach (MessagePartDescription body in requestMessage.Body.Parts)
            //    {
            //        body.ProtectionLevel = System.Net.Security.ProtectionLevel.None;
            //    }
            //}

            bindingParameters.Remove<ChannelProtectionRequirements>();

            var m = new MessagePartSpecification();
            m.IsBodyIncluded = false;

            var c1 = new ChannelProtectionRequirements();
            c1.IncomingSignatureParts.AddParts(m, "*");

            MessagePartSpecification m1 = new MessagePartSpecification();
            m.IsBodyIncluded = false;
            c1.IncomingEncryptionParts.AddParts(m1, "*");

            bindingParameters.Add(c1);
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new EchoClientMessageInspector());
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }
}
