using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.level
{
[System.Serializable]
public  class Chapter :   cfg.EditorWriter 
 {

    public int id ;
     public string name  = "";
     public int costStrength ;
     public int mapId ;
     public System.Collections.Generic.List<cfg.level.ChapterBox> boxRewards  = new System.Collections.Generic.List<cfg.level.ChapterBox>();
     public cfg.bonus.Bonus idleReward ;
     public cfg.bonus.Bonus resultReward ;
     



    public const int TYPE_ID = 63342;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Chapter(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         name = os.ReadString(); 
         costStrength = os.ReadInt(); 
         mapId = os.ReadInt(); 
         boxRewards = cfg.Extensions.unmarshal_list_cfg_level_ChapterBox(os); 
         idleReward = cfg.Extensions.unmarshal_cfg_bonus_Bonus(os); 
         resultReward = cfg.Extensions.unmarshal_cfg_bonus_Bonus(os); 
         
    }

    public Chapter()
    {
    }

    public Chapter(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "costStrength":  costStrength = ele.ReadInt(); break; 
             case "mapId":  mapId = ele.ReadInt(); break; 
             case "boxRewards":  boxRewards = cfg.Extensions.xml_unmarshal_list_cfg_level_ChapterBox(ele); break; 
             case "idleReward":  idleReward = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(ele); break; 
             case "resultReward":  resultReward = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Chapter");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("costStrength"); ele.WriteInt(costStrength); ele.WriteEndElement();
         ele.WriteStartElement("mapId"); ele.WriteInt(mapId); ele.WriteEndElement();
         ele.WriteStartElement("boxRewards"); cfg.Extensions.xml_marshal_list_cfg_level_ChapterBox(boxRewards,ele); ele.WriteEndElement();
         ele.WriteStartElement("idleReward"); cfg.Extensions.xml_marshal_cfg_bonus_Bonus(idleReward,ele); ele.WriteEndElement();
         ele.WriteStartElement("resultReward"); cfg.Extensions.xml_marshal_cfg_bonus_Bonus(resultReward,ele); ele.WriteEndElement();
         
    }


}
}
}
