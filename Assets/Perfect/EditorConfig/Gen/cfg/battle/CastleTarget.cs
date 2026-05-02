using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class CastleTarget : EffectTarget
 {




    public const int TYPE_ID = 1940;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleTarget(Perfect.Marshal.Octets os) : base(os)  {

    }

    public CastleTarget()
    {
    }

    public CastleTarget(XmlElement e)
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
        ele.WriteAttributeString("type", "CastleTarget");
    }


}
}
}
