using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class MoneyCost : CostType
 {

    public cfg.common.MoneyCost cost  = new cfg.common.MoneyCost();
     



    public const int TYPE_ID = 8515;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MoneyCost(Perfect.Marshal.Octets os) : base(os)  {

        cost = cfg.Extensions.unmarshal_cfg_common_MoneyCost(os); 
         
    }

    public MoneyCost()
    {
    }

    public MoneyCost(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_common_MoneyCost(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MoneyCost");
        ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_common_MoneyCost(cost,ele); ele.WriteEndElement();
         
    }


}
}
}
