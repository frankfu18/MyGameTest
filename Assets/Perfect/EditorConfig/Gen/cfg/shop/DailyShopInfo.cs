using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class DailyShopInfo : ShopInfo
 {

    public int dailyGoodsCount ;
     public System.Collections.Generic.List<cfg.shop.GoodsInfo> fixedGoodsList  = new System.Collections.Generic.List<cfg.shop.GoodsInfo>();
     public System.Collections.Generic.List<cfg.shop.GoodsInfo> firstRefreshShowGoodsList  = new System.Collections.Generic.List<cfg.shop.GoodsInfo>();
     



    public const int TYPE_ID = 44330;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DailyShopInfo(Perfect.Marshal.Octets os) : base(os)  {

        dailyGoodsCount = os.ReadInt(); 
         fixedGoodsList = cfg.Extensions.unmarshal_list_cfg_shop_GoodsInfo(os); 
         firstRefreshShowGoodsList = cfg.Extensions.unmarshal_list_cfg_shop_GoodsInfo(os); 
         
    }

    public DailyShopInfo()
    {
    }

    public DailyShopInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "dailyGoodsCount":  dailyGoodsCount = ele.ReadInt(); break; 
             case "fixedGoodsList":  fixedGoodsList = cfg.Extensions.xml_unmarshal_list_cfg_shop_GoodsInfo(ele); break; 
             case "firstRefreshShowGoodsList":  firstRefreshShowGoodsList = cfg.Extensions.xml_unmarshal_list_cfg_shop_GoodsInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DailyShopInfo");
        ele.WriteStartElement("dailyGoodsCount"); ele.WriteInt(dailyGoodsCount); ele.WriteEndElement();
         ele.WriteStartElement("fixedGoodsList"); cfg.Extensions.xml_marshal_list_cfg_shop_GoodsInfo(fixedGoodsList,ele); ele.WriteEndElement();
         ele.WriteStartElement("firstRefreshShowGoodsList"); cfg.Extensions.xml_marshal_list_cfg_shop_GoodsInfo(firstRefreshShowGoodsList,ele); ele.WriteEndElement();
         
    }


}
}
}
