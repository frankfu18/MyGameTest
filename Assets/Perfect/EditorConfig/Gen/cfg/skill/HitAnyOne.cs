using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitAnyOne : BulletEffectType
 {




    public const int TYPE_ID = 60405;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitAnyOne(Perfect.Marshal.Octets os) : base(os)  {

    }

    public HitAnyOne()
    {
    }

    public HitAnyOne(XmlElement e)
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
        ele.WriteAttributeString("type", "HitAnyOne");
    }


}
}
}
