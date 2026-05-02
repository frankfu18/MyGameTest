using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class HeroTarget : EffectTarget
 {




    public const int TYPE_ID = 39296;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HeroTarget(Perfect.Marshal.Octets os) : base(os)  {

    }

    public HeroTarget()
    {
    }

    public HeroTarget(XmlElement e)
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
        ele.WriteAttributeString("type", "HeroTarget");
    }


}
}
}
