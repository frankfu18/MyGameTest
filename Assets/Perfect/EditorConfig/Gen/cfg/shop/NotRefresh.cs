using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class NotRefresh : ShopRefreshInfo
 {




    public const int TYPE_ID = 53704;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public NotRefresh(Perfect.Marshal.Octets os) : base(os)  {

    }

    public NotRefresh()
    {
    }

    public NotRefresh(XmlElement e)
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
        ele.WriteAttributeString("type", "NotRefresh");
    }


}
}
}
