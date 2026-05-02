using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class MapGround :   cfg.EditorWriter 
 {

    public int id ;
     public string assetId  = "";
     public int weight ;
     



    public const int TYPE_ID = 41417;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MapGround(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         assetId = os.ReadString(); 
         weight = os.ReadInt(); 
         
    }

    public MapGround()
    {
    }

    public MapGround(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "assetId":  assetId = ele.ReadString2(); break; 
             case "weight":  weight = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MapGround");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("assetId"); ele.WriteString2(assetId); ele.WriteEndElement();
         ele.WriteStartElement("weight"); ele.WriteInt(weight); ele.WriteEndElement();
         
    }


}
}
}
