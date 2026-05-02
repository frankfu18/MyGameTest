using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class CostWithInterval : CostType
 {

    public cfg.shop.CostType cost ;
     public int interval ;
     public bool isSpanDay ;
     



    public const int TYPE_ID = 963;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CostWithInterval(Perfect.Marshal.Octets os) : base(os)  {

        cost = cfg.Extensions.unmarshal_cfg_shop_CostType(os); 
         interval = os.ReadInt(); 
         isSpanDay = os.ReadBool(); 
         
    }

    public CostWithInterval()
    {
    }

    public CostWithInterval(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_shop_CostType(ele); break; 
             case "interval":  interval = ele.ReadInt(); break; 
             case "isSpanDay":  isSpanDay = ele.ReadBool(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CostWithInterval");
        ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_shop_CostType(cost,ele); ele.WriteEndElement();
         ele.WriteStartElement("interval"); ele.WriteInt(interval); ele.WriteEndElement();
         ele.WriteStartElement("isSpanDay"); ele.WriteBool(isSpanDay); ele.WriteEndElement();
         
    }


}
}
}
