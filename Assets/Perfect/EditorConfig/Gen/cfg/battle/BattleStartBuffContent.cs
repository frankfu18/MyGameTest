using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public abstract class BattleStartBuffContent :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BattleStartBuffContent(Perfect.Marshal.Octets os) {

    }

    public BattleStartBuffContent()
    {
    }

}
}
}
