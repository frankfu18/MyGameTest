using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class MapLevel :   cfg.EditorWriter 
 {

    public int id ;
     public int colNum ;
     public int rowNum ;
     public int totalWave ;
     public int goldStartAdd ;
     public int exploreStartAdd ;
     public int goldPerSec ;
     public int refreshStartId ;
     public bool exploreAllways ;
     public System.Collections.Generic.List<int> showExploreWave  = new System.Collections.Generic.List<int>();
     



    public const int TYPE_ID = 9447;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MapLevel(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         colNum = os.ReadInt(); 
         rowNum = os.ReadInt(); 
         totalWave = os.ReadInt(); 
         goldStartAdd = os.ReadInt(); 
         exploreStartAdd = os.ReadInt(); 
         goldPerSec = os.ReadInt(); 
         refreshStartId = os.ReadInt(); 
         exploreAllways = os.ReadBool(); 
         showExploreWave = cfg.Extensions.unmarshal_list_int(os); 
         
    }

    public MapLevel()
    {
    }

    public MapLevel(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "colNum":  colNum = ele.ReadInt(); break; 
             case "rowNum":  rowNum = ele.ReadInt(); break; 
             case "totalWave":  totalWave = ele.ReadInt(); break; 
             case "goldStartAdd":  goldStartAdd = ele.ReadInt(); break; 
             case "exploreStartAdd":  exploreStartAdd = ele.ReadInt(); break; 
             case "goldPerSec":  goldPerSec = ele.ReadInt(); break; 
             case "refreshStartId":  refreshStartId = ele.ReadInt(); break; 
             case "exploreAllways":  exploreAllways = ele.ReadBool(); break; 
             case "showExploreWave":  showExploreWave = cfg.Extensions.xml_unmarshal_list_int(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MapLevel");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("colNum"); ele.WriteInt(colNum); ele.WriteEndElement();
         ele.WriteStartElement("rowNum"); ele.WriteInt(rowNum); ele.WriteEndElement();
         ele.WriteStartElement("totalWave"); ele.WriteInt(totalWave); ele.WriteEndElement();
         ele.WriteStartElement("goldStartAdd"); ele.WriteInt(goldStartAdd); ele.WriteEndElement();
         ele.WriteStartElement("exploreStartAdd"); ele.WriteInt(exploreStartAdd); ele.WriteEndElement();
         ele.WriteStartElement("goldPerSec"); ele.WriteInt(goldPerSec); ele.WriteEndElement();
         ele.WriteStartElement("refreshStartId"); ele.WriteInt(refreshStartId); ele.WriteEndElement();
         ele.WriteStartElement("exploreAllways"); ele.WriteBool(exploreAllways); ele.WriteEndElement();
         ele.WriteStartElement("showExploreWave"); cfg.Extensions.xml_marshal_list_int(showExploreWave,ele); ele.WriteEndElement();
         
    }


}
}
}
