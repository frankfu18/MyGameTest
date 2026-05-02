using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public abstract class SlotInfo :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SlotInfo(Perfect.Marshal.Octets os) {

    }

    public SlotInfo()
    {
    }

}
}
}
