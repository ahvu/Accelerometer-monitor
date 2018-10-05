using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    public interface IMessageHandler
    {
        bool handleMessage(byte[] message);
        bool provideNecessaryResources(List<Object> resource);
        bool IsAllNeccesaryResourcesProvided();
    }
}
