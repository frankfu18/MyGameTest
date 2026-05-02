using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class EveryDayFreeGoods : GoodsInfo
 {

    public int freeCount ;
     



    public const int TYPE_ID = 29286;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public EveryDayFreeGoods(Perfect.Marshal.Octets os) : base(os)  {

        freeCount = os.ReadInt(); 
         
    }

    public EveryDayFreeGoods()
    {
    }

    public EveryDayFreeGoods(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "limitBuyType":  limitBuyType = cfg.Extensions.xml_unmarshal_cfg_shop_LimitBuyType(ele); break; 
             case "maxBuyTimes":  maxBuyTimes = ele.ReadInt(); break; 
             case "sellInfo":  sellInfo = cfg.Extensions.xml_unmarshal_cfg_shop_SellInfo(ele); break; 
             case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_shop_CostType(ele); break; 
             case "freeCount":  freeCount = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "EveryDayFreeGoods");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("limitBuyType"); cfg.Extensions.xml_marshal_cfg_shop_LimitBuyType(limitBuyType,ele); ele.WriteEndElement();
         ele.WriteStartElement("maxBuyTimes"); ele.WriteInt(maxBuyTimes); ele.WriteEndElement();
         ele.WriteStartElement("sellInfo"); cfg.Extensions.xml_marshal_cfg_shop_SellInfo(sellInfo,ele); ele.WriteEndElement();
         ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_shop_CostType(cost,ele); ele.WriteEndElement();
         ele.WriteStartElement("freeCount"); ele.WriteInt(freeCount); ele.WriteEndElement();
         
    }


}
}
}
