using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class DailyGoodsRefresh :   cfg.EditorWriter 
 {

    public int count ;
     public cfg.shop.CostType cost ;
     



    public const int TYPE_ID = 24798;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DailyGoodsRefresh(Perfect.Marshal.Octets os) {

        count = os.ReadInt(); 
         cost = cfg.Extensions.unmarshal_cfg_shop_CostType(os); 
         
    }

    public DailyGoodsRefresh()
    {
    }

    public DailyGoodsRefresh(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "count":  count = ele.ReadInt(); break; 
             case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_shop_CostType(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DailyGoodsRefresh");
        ele.WriteStartElement("count"); ele.WriteInt(count); ele.WriteEndElement();
         ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_shop_CostType(cost,ele); ele.WriteEndElement();
         
    }


}
}
}
