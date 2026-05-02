using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.shop
{
[System.Serializable]
public  class DayLimit : LimitBuyType
 {

    public int day ;
     



    public const int TYPE_ID = 14314;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DayLimit(Perfect.Marshal.Octets os) : base(os)  {

        day = os.ReadInt(); 
         
    }

    public DayLimit()
    {
    }

    public DayLimit(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "day":  day = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DayLimit");
        ele.WriteStartElement("day"); ele.WriteInt(day); ele.WriteEndElement();
         
    }


}
}
}
