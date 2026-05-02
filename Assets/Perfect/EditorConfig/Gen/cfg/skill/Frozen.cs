using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class Frozen : BuffEffectContent
 {




    public const int TYPE_ID = 13309;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Frozen(Perfect.Marshal.Octets os) : base(os)  {

    }

    public Frozen()
    {
    }

    public Frozen(XmlElement e)
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
        ele.WriteAttributeString("type", "Frozen");
    }


}
}
}
