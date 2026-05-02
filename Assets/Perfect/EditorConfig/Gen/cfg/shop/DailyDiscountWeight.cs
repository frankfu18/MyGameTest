using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class DailyDiscountWeight :   cfg.EditorWriter 
 {

    public int discount ;
     public int weight ;
     



    public const int TYPE_ID = 33045;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DailyDiscountWeight(Perfect.Marshal.Octets os) {

        discount = os.ReadInt(); 
         weight = os.ReadInt(); 
         
    }

    public DailyDiscountWeight()
    {
    }

    public DailyDiscountWeight(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "discount":  discount = ele.ReadInt(); break; 
             case "weight":  weight = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DailyDiscountWeight");
        ele.WriteStartElement("discount"); ele.WriteInt(discount); ele.WriteEndElement();
         ele.WriteStartElement("weight"); ele.WriteInt(weight); ele.WriteEndElement();
         
    }


}
}
}
