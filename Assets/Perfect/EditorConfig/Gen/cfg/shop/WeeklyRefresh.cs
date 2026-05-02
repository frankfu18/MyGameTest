using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class WeeklyRefresh : ShopRefreshInfo
 {




    public const int TYPE_ID = 49412;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public WeeklyRefresh(Perfect.Marshal.Octets os) : base(os)  {

    }

    public WeeklyRefresh()
    {
    }

    public WeeklyRefresh(XmlElement e)
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
        ele.WriteAttributeString("type", "WeeklyRefresh");
    }


}
}
}
