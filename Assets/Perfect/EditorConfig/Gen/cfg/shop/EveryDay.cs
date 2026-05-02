using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class EveryDay : LimitBuyType
 {




    public const int TYPE_ID = 28248;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EveryDay(Perfect.Marshal.Octets os) : base(os)  {

    }

    public EveryDay()
    {
    }

    public EveryDay(XmlElement e)
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
        ele.WriteAttributeString("type", "EveryDay");
    }


}
}
}
