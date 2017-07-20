using System.ServiceModel;
using System.ServiceModel.Dispatcher;

namespace WcfDigitalSignature.Client
{
    public class EchoClientMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {
            return null;
        }
    }
}
