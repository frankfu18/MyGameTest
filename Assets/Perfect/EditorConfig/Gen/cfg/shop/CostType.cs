using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public abstract class CostType :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CostType(Perfect.Marshal.Octets os) {

    }

    public CostType()
    {
    }

}
}
}
