using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class DailyGoods :   cfg.EditorWriter 
 {

    public int id ;
     public string name  = "";
     public cfg.shop.SellInfo sellInfo ;
     public int weight ;
     public cfg.shop.CostType price ;
     



    public const int TYPE_ID = 16363;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DailyGoods(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         name = os.ReadString(); 
         sellInfo = cfg.Extensions.unmarshal_cfg_shop_SellInfo(os); 
         weight = os.ReadInt(); 
         price = cfg.Extensions.unmarshal_cfg_shop_CostType(os); 
         
    }

    public DailyGoods()
    {
    }

    public DailyGoods(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "sellInfo":  sellInfo = cfg.Extensions.xml_unmarshal_cfg_shop_SellInfo(ele); break; 
             case "weight":  weight = ele.ReadInt(); break; 
             case "price":  price = cfg.Extensions.xml_unmarshal_cfg_shop_CostType(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DailyGoods");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("sellInfo"); cfg.Extensions.xml_marshal_cfg_shop_SellInfo(sellInfo,ele); ele.WriteEndElement();
         ele.WriteStartElement("weight"); ele.WriteInt(weight); ele.WriteEndElement();
         ele.WriteStartElement("price"); cfg.Extensions.xml_marshal_cfg_shop_CostType(price,ele); ele.WriteEndElement();
         
    }


}
}
}
