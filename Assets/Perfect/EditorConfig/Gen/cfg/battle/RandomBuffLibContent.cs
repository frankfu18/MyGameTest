using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RandomBuffLibContent :   cfg.EditorWriter 
 {

    public int buffId ;
     public int buffWeight ;
     



    public const int TYPE_ID = 5592;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RandomBuffLibContent(Perfect.Marshal.Octets os) {

        buffId = os.ReadInt(); 
         buffWeight = os.ReadInt(); 
         
    }

    public RandomBuffLibContent()
    {
    }

    public RandomBuffLibContent(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffId":  buffId = ele.ReadInt(); break; 
             case "buffWeight":  buffWeight = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RandomBuffLibContent");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         ele.WriteStartElement("buffWeight"); ele.WriteInt(buffWeight); ele.WriteEndElement();
         
    }


}
}
}
