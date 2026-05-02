using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class Shop :   cfg.EditorWriter 
 {

    public cfg.shop.EShopType shopType ;
     public string name  = "";
     public cfg.shop.ShopRefreshInfo refreshInfo ;
     public cfg.shop.ShopInfo shopInfo ;
     



    public const int TYPE_ID = 56449;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Shop(Perfect.Marshal.Octets os) {

        shopType = (cfg.shop.EShopType)(os.ReadInt()); 
         name = os.ReadString(); 
         refreshInfo = cfg.Extensions.unmarshal_cfg_shop_ShopRefreshInfo(os); 
         shopInfo = cfg.Extensions.unmarshal_cfg_shop_ShopInfo(os); 
         
    }

    public Shop()
    {
    }

    public Shop(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "shopType":  shopType = ele.ReadEnum<cfg.shop.EShopType>(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "refreshInfo":  refreshInfo = cfg.Extensions.xml_unmarshal_cfg_shop_ShopRefreshInfo(ele); break; 
             case "shopInfo":  shopInfo = cfg.Extensions.xml_unmarshal_cfg_shop_ShopInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Shop");
        ele.WriteStartElement("shopType"); ele.WriteEnum(shopType); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("refreshInfo"); cfg.Extensions.xml_marshal_cfg_shop_ShopRefreshInfo(refreshInfo,ele); ele.WriteEndElement();
         ele.WriteStartElement("shopInfo"); cfg.Extensions.xml_marshal_cfg_shop_ShopInfo(shopInfo,ele); ele.WriteEndElement();
         
    }


}
}
}
