using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public abstract class LimitBuyType :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public LimitBuyType(Perfect.Marshal.Octets os) {

    }

    public LimitBuyType()
    {
    }

}
}
}
