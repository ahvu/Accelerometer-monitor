using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    public enum HANDSHAKE_TYPE
    {
        REQUEST_TO_SEND = 1,
        XON_XOFF,
        BOTH,
        NONE
    }

    public delegate void DataWritenUpdate(string sData);
    public delegate void HighLevelDataHandler();

    public interface ISerialPort
    {
        bool OpenPort();
        bool OpenPort(string port);
        bool ClosePort();

        bool CheckPort();
        bool IsPortOpen();
        string GetPortName();

        bool HandshakeSetting(HANDSHAKE_TYPE iMode);
        bool DTRSetting(bool FlagEnable);
        bool RTSSetting(bool FlagEnable);
        bool SetBaudRate(int _baudrate);
        bool RegisterHighLevelDataHandler(HighLevelDataHandler handler);

        bool Write(int dataOut);
        bool Write(string dataOut);
        bool Write(byte[] Data);

        string Read();
        Byte[] XtractInData(); 
    }
}
