using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class MapOutDirFilter :   cfg.EditorWriter 
 {

    public cfg.map.EPathDir dir ;
     public int initPercent ;
     public int percentSub ;
     public int percentMinLimit ;
     public System.Collections.Generic.List<cfg.map.OutDirFilterAdd> addPercentContent  = new System.Collections.Generic.List<cfg.map.OutDirFilterAdd>();
     



    public const int TYPE_ID = 37360;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public MapOutDirFilter(Perfect.Marshal.Octets os) {

        dir = (cfg.map.EPathDir)(os.ReadInt()); 
         initPercent = os.ReadInt(); 
         percentSub = os.ReadInt(); 
         percentMinLimit = os.ReadInt(); 
         addPercentContent = cfg.Extensions.unmarshal_list_cfg_map_OutDirFilterAdd(os); 
         
    }

    public MapOutDirFilter()
    {
    }

    public MapOutDirFilter(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "dir":  dir = ele.ReadEnum<cfg.map.EPathDir>(); break; 
             case "initPercent":  initPercent = ele.ReadInt(); break; 
             case "percentSub":  percentSub = ele.ReadInt(); break; 
             case "percentMinLimit":  percentMinLimit = ele.ReadInt(); break; 
             case "addPercentContent":  addPercentContent = cfg.Extensions.xml_unmarshal_list_cfg_map_OutDirFilterAdd(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "MapOutDirFilter");
        ele.WriteStartElement("dir"); ele.WriteEnum(dir); ele.WriteEndElement();
         ele.WriteStartElement("initPercent"); ele.WriteInt(initPercent); ele.WriteEndElement();
         ele.WriteStartElement("percentSub"); ele.WriteInt(percentSub); ele.WriteEndElement();
         ele.WriteStartElement("percentMinLimit"); ele.WriteInt(percentMinLimit); ele.WriteEndElement();
         ele.WriteStartElement("addPercentContent"); cfg.Extensions.xml_marshal_list_cfg_map_OutDirFilterAdd(addPercentContent,ele); ele.WriteEndElement();
         
    }


}
}
}
