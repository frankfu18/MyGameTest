using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class StartSelectBuffOnce : BattleStartBuffContent
 {




    public const int TYPE_ID = 59428;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public StartSelectBuffOnce(Perfect.Marshal.Octets os) : base(os)  {

    }

    public StartSelectBuffOnce()
    {
    }

    public StartSelectBuffOnce(XmlElement e)
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
        ele.WriteAttributeString("type", "StartSelectBuffOnce");
    }


}
}
}
