using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class Immediate : BuffEffectType
 {




    public const int TYPE_ID = 64257;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Immediate(Perfect.Marshal.Octets os) : base(os)  {

    }

    public Immediate()
    {
    }

    public Immediate(XmlElement e)
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
        ele.WriteAttributeString("type", "Immediate");
    }


}
}
}
