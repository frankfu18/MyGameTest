using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class SellItem : SellInfo
 {

    public cfg.bonus.Item item  = new cfg.bonus.Item();
     



    public const int TYPE_ID = 65230;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SellItem(Perfect.Marshal.Octets os) : base(os)  {

        item = cfg.Extensions.unmarshal_cfg_bonus_Item(os); 
         
    }

    public SellItem()
    {
    }

    public SellItem(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "item":  item = cfg.Extensions.xml_unmarshal_cfg_bonus_Item(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SellItem");
        ele.WriteStartElement("item"); cfg.Extensions.xml_marshal_cfg_bonus_Item(item,ele); ele.WriteEndElement();
         
    }


}
}
}
