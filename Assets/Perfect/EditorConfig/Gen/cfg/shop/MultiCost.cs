using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class MultiCost : CostType
 {

    public System.Collections.Generic.List<cfg.shop.CostType> costList  = new System.Collections.Generic.List<cfg.shop.CostType>();
     



    public const int TYPE_ID = 28540;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MultiCost(Perfect.Marshal.Octets os) : base(os)  {

        costList = cfg.Extensions.unmarshal_list_cfg_shop_CostType(os); 
         
    }

    public MultiCost()
    {
    }

    public MultiCost(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "costList":  costList = cfg.Extensions.xml_unmarshal_list_cfg_shop_CostType(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MultiCost");
        ele.WriteStartElement("costList"); cfg.Extensions.xml_marshal_list_cfg_shop_CostType(costList,ele); ele.WriteEndElement();
         
    }


}
}
}
