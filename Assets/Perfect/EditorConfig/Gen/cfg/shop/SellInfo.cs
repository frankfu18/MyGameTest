using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public abstract class SellInfo :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SellInfo(Perfect.Marshal.Octets os) {

    }

    public SellInfo()
    {
    }

}
}
}
