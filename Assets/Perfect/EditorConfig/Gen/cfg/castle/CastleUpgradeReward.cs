using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public abstract class CastleUpgradeReward :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleUpgradeReward(Perfect.Marshal.Octets os) {

    }

    public CastleUpgradeReward()
    {
    }

}
}
}
