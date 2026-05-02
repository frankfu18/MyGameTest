using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class CostWithCount : CostType
 {

    public cfg.shop.CostType cost ;
     public int count ;
     



    public const int TYPE_ID = 11098;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CostWithCount(Perfect.Marshal.Octets os) : base(os)  {

        cost = cfg.Extensions.unmarshal_cfg_shop_CostType(os); 
         count = os.ReadInt(); 
         
    }

    public CostWithCount()
    {
    }

    public CostWithCount(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_shop_CostType(ele); break; 
             case "count":  count = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CostWithCount");
        ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_shop_CostType(cost,ele); ele.WriteEndElement();
         ele.WriteStartElement("count"); ele.WriteInt(count); ele.WriteEndElement();
         
    }


}
}
}
