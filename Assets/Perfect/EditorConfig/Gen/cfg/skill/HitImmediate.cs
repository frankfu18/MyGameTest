using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitImmediate : BulletEffectType
 {




    public const int TYPE_ID = 47063;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitImmediate(Perfect.Marshal.Octets os) : base(os)  {

    }

    public HitImmediate()
    {
    }

    public HitImmediate(XmlElement e)
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
        ele.WriteAttributeString("type", "HitImmediate");
    }


}
}
}
