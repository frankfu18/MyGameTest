using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class NormalGoods : GoodsInfo
 {




    public const int TYPE_ID = 55656;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public NormalGoods(Perfect.Marshal.Octets os) : base(os)  {

    }

    public NormalGoods()
    {
    }

    public NormalGoods(XmlElement e)
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
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "NormalGoods");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("limitBuyType"); cfg.Extensions.xml_marshal_cfg_shop_LimitBuyType(limitBuyType,ele); ele.WriteEndElement();
         ele.WriteStartElement("maxBuyTimes"); ele.WriteInt(maxBuyTimes); ele.WriteEndElement();
         ele.WriteStartElement("sellInfo"); cfg.Extensions.xml_marshal_cfg_shop_SellInfo(sellInfo,ele); ele.WriteEndElement();
         ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_shop_CostType(cost,ele); ele.WriteEndElement();
         
    }


}
}
}
