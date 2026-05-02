using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class MapPath :   cfg.EditorWriter 
 {

    public int id ;
     public string res  = "";
     public System.Collections.Generic.List<cfg.map.EPathDir> pathDir  = new System.Collections.Generic.List<cfg.map.EPathDir>();
     



    public const int TYPE_ID = 14553;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MapPath(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         res = os.ReadString(); 
         pathDir = cfg.Extensions.unmarshal_list_cfg_map_EPathDir(os); 
         
    }

    public MapPath()
    {
    }

    public MapPath(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "res":  res = ele.ReadString2(); break; 
             case "pathDir":  pathDir = cfg.Extensions.xml_unmarshal_list_cfg_map_EPathDir(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MapPath");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("res"); ele.WriteString2(res); ele.WriteEndElement();
         ele.WriteStartElement("pathDir"); cfg.Extensions.xml_marshal_list_cfg_map_EPathDir(pathDir,ele); ele.WriteEndElement();
         
    }


}
}
}
