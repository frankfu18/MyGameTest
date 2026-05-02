using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class mapEventShowWeight :   cfg.EditorWriter 
 {

    public int num ;
     public int weight ;
     



    public const int TYPE_ID = 1470;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public mapEventShowWeight(Perfect.Marshal.Octets os) {

        num = os.ReadInt(); 
         weight = os.ReadInt(); 
         
    }

    public mapEventShowWeight()
    {
    }

    public mapEventShowWeight(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "num":  num = ele.ReadInt(); break; 
             case "weight":  weight = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "mapEventShowWeight");
        ele.WriteStartElement("num"); ele.WriteInt(num); ele.WriteEndElement();
         ele.WriteStartElement("weight"); ele.WriteInt(weight); ele.WriteEndElement();
         
    }


}
}
}
