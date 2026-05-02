using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public abstract class BulletEffectType :   cfg.EditorWriter 
 {




    public const int TYPE_ID = 0;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BulletEffectType(Perfect.Marshal.Octets os) {

    }

    public BulletEffectType()
    {
    }

}
}
}
