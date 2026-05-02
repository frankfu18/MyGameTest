using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class EveryMonth : LimitBuyType
 {




    public const int TYPE_ID = 19255;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EveryMonth(Perfect.Marshal.Octets os) : base(os)  {

    }

    public EveryMonth()
    {
    }

    public EveryMonth(XmlElement e)
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
        ele.WriteAttributeString("type", "EveryMonth");
    }


}
}
}
