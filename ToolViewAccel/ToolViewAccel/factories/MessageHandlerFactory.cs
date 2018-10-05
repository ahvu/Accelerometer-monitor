using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    public sealed class MessageHandlerFactory
    {
        private List<IMessageHandler> MessageHandlerInstances;
        public MessageHandlerFactory(List<Object> NecessaryResources)
        {
            MessageHandlerInstances = new List<IMessageHandler>() ;
            MessageHandlerInstances.Add(new CAccelerometerDataMessageHandler(NecessaryResources));
        }

        public IMessageHandler GetMessageHandler(Byte MessageType)
        {
            switch(MessageType)
            {
                case CAccelerometerDataMessageHandler.MessageType:
                    return (MessageHandlerInstances[0].IsAllNeccesaryResourcesProvided()) ? MessageHandlerInstances[0] : null;
                default:
                    return null;
            }
        }
    }
}
