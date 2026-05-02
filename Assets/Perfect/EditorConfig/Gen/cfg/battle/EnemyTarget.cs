using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class EnemyTarget : EffectTarget
 {




    public const int TYPE_ID = 29593;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EnemyTarget(Perfect.Marshal.Octets os) : base(os)  {

    }

    public EnemyTarget()
    {
    }

    public EnemyTarget(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "EnemyTarget");
    }


}
}
}
