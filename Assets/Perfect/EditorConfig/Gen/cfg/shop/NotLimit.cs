using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class NotLimit : LimitBuyType
 {




    public const int TYPE_ID = 24476;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public NotLimit(Perfect.Marshal.Octets os) : base(os)  {

    }

    public NotLimit()
    {
    }

    public NotLimit(XmlElement e)
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
        ele.WriteAttributeString("type", "NotLimit");
    }


}
}
}
