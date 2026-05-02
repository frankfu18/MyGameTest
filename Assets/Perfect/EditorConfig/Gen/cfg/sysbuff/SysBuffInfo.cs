using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.sysbuff
{
[System.Serializable]
public abstract class SysBuffInfo :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SysBuffInfo(Perfect.Marshal.Octets os) {

    }

    public SysBuffInfo()
    {
    }

}
}
}
