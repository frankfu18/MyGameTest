using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class SellCurrency : SellInfo
 {

    public cfg.bonus.Currency currency  = new cfg.bonus.Currency();
     



    public const int TYPE_ID = 5617;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SellCurrency(Perfect.Marshal.Octets os) : base(os)  {

        currency = cfg.Extensions.unmarshal_cfg_bonus_Currency(os); 
         
    }

    public SellCurrency()
    {
    }

    public SellCurrency(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "currency":  currency = cfg.Extensions.xml_unmarshal_cfg_bonus_Currency(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SellCurrency");
        ele.WriteStartElement("currency"); cfg.Extensions.xml_marshal_cfg_bonus_Currency(currency,ele); ele.WriteEndElement();
         
    }


}
}
}
