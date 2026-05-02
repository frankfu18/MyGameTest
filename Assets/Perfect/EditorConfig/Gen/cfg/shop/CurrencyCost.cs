using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class CurrencyCost : CostType
 {

    public cfg.common.CurrencyCost cost  = new cfg.common.CurrencyCost();
     



    public const int TYPE_ID = 38192;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CurrencyCost(Perfect.Marshal.Octets os) : base(os)  {

        cost = cfg.Extensions.unmarshal_cfg_common_CurrencyCost(os); 
         
    }

    public CurrencyCost()
    {
    }

    public CurrencyCost(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_common_CurrencyCost(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CurrencyCost");
        ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_common_CurrencyCost(cost,ele); ele.WriteEndElement();
         
    }


}
}
}
