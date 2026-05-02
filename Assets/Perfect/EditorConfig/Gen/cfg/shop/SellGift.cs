using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class SellGift : SellInfo
 {

    public System.Collections.Generic.List<cfg.shop.SellInfo> sellInfos  = new System.Collections.Generic.List<cfg.shop.SellInfo>();
     



    public const int TYPE_ID = 60652;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SellGift(Perfect.Marshal.Octets os) : base(os)  {

        sellInfos = cfg.Extensions.unmarshal_list_cfg_shop_SellInfo(os); 
         
    }

    public SellGift()
    {
    }

    public SellGift(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "sellInfos":  sellInfos = cfg.Extensions.xml_unmarshal_list_cfg_shop_SellInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SellGift");
        ele.WriteStartElement("sellInfos"); cfg.Extensions.xml_marshal_list_cfg_shop_SellInfo(sellInfos,ele); ele.WriteEndElement();
         
    }


}
}
}
