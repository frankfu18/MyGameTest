using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class Free : CostType
 {




    public const int TYPE_ID = 41221;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Free(Perfect.Marshal.Octets os) : base(os)  {

    }

    public Free()
    {
    }

    public Free(XmlElement e)
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
        ele.WriteAttributeString("type", "Free");
    }


}
}
}
