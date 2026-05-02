using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class MapBuild :   cfg.EditorWriter 
 {

    public int id ;
     public string buildDes  = "";
     public string buildIcon  = "";
     public int buildCost ;
     public int buildDelGet ;
     public cfg.battle.BuildingType buildingType ;
     



    public const int TYPE_ID = 20567;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MapBuild(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         buildDes = os.ReadString(); 
         buildIcon = os.ReadString(); 
         buildCost = os.ReadInt(); 
         buildDelGet = os.ReadInt(); 
         buildingType = cfg.Extensions.unmarshal_cfg_battle_BuildingType(os); 
         
    }

    public MapBuild()
    {
    }

    public MapBuild(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "buildDes":  buildDes = ele.ReadString2(); break; 
             case "buildIcon":  buildIcon = ele.ReadString2(); break; 
             case "buildCost":  buildCost = ele.ReadInt(); break; 
             case "buildDelGet":  buildDelGet = ele.ReadInt(); break; 
             case "buildingType":  buildingType = cfg.Extensions.xml_unmarshal_cfg_battle_BuildingType(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MapBuild");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("buildDes"); ele.WriteString2(buildDes); ele.WriteEndElement();
         ele.WriteStartElement("buildIcon"); ele.WriteString2(buildIcon); ele.WriteEndElement();
         ele.WriteStartElement("buildCost"); ele.WriteInt(buildCost); ele.WriteEndElement();
         ele.WriteStartElement("buildDelGet"); ele.WriteInt(buildDelGet); ele.WriteEndElement();
         ele.WriteStartElement("buildingType"); cfg.Extensions.xml_marshal_cfg_battle_BuildingType(buildingType,ele); ele.WriteEndElement();
         
    }


}
}
}
