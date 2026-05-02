using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class AdCost : CostType
 {




    public const int TYPE_ID = 11115;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AdCost(Perfect.Marshal.Octets os) : base(os)  {

    }

    public AdCost()
    {
    }

    public AdCost(XmlElement e)
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
        ele.WriteAttributeString("type", "AdCost");
    }


}
}
}
