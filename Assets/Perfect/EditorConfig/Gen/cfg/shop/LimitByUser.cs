using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class LimitByUser : LimitBuyType
 {




    public const int TYPE_ID = 44165;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public LimitByUser(Perfect.Marshal.Octets os) : base(os)  {

    }

    public LimitByUser()
    {
    }

    public LimitByUser(XmlElement e)
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
        ele.WriteAttributeString("type", "LimitByUser");
    }


}
}
}
