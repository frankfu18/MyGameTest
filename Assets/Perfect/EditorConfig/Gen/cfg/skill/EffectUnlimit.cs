using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class EffectUnlimit : BulletDestroyType
 {




    public const int TYPE_ID = 52790;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EffectUnlimit(Perfect.Marshal.Octets os) : base(os)  {

    }

    public EffectUnlimit()
    {
    }

    public EffectUnlimit(XmlElement e)
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
        ele.WriteAttributeString("type", "EffectUnlimit");
    }


}
}
}
