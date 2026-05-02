using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class Dizz : BuffEffectContent
 {




    public const int TYPE_ID = 41897;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Dizz(Perfect.Marshal.Octets os) : base(os)  {

    }

    public Dizz()
    {
    }

    public Dizz(XmlElement e)
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
        ele.WriteAttributeString("type", "Dizz");
    }


}
}
}
