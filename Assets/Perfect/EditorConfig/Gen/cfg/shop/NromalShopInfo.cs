using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class NromalShopInfo : ShopInfo
 {

    public System.Collections.Generic.List<cfg.shop.GoodsInfo> goodsInfos  = new System.Collections.Generic.List<cfg.shop.GoodsInfo>();
     



    public const int TYPE_ID = 14417;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public NromalShopInfo(Perfect.Marshal.Octets os) : base(os)  {

        goodsInfos = cfg.Extensions.unmarshal_list_cfg_shop_GoodsInfo(os); 
         
    }

    public NromalShopInfo()
    {
    }

    public NromalShopInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "goodsInfos":  goodsInfos = cfg.Extensions.xml_unmarshal_list_cfg_shop_GoodsInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "NromalShopInfo");
        ele.WriteStartElement("goodsInfos"); cfg.Extensions.xml_marshal_list_cfg_shop_GoodsInfo(goodsInfos,ele); ele.WriteEndElement();
         
    }


}
}
}
