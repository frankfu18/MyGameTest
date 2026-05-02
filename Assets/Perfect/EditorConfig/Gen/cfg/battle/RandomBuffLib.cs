using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RandomBuffLib :   cfg.EditorWriter 
 {

    public int level ;
     public int level1Weight ;
     public int level2Weight ;
     public System.Collections.Generic.List<cfg.battle.RandomBuffLibContent> libContent  = new System.Collections.Generic.List<cfg.battle.RandomBuffLibContent>();
     



    public const int TYPE_ID = 5017;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RandomBuffLib(Perfect.Marshal.Octets os) {

        level = os.ReadInt(); 
         level1Weight = os.ReadInt(); 
         level2Weight = os.ReadInt(); 
         libContent = cfg.Extensions.unmarshal_list_cfg_battle_RandomBuffLibContent(os); 
         
    }

    public RandomBuffLib()
    {
    }

    public RandomBuffLib(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             case "level1Weight":  level1Weight = ele.ReadInt(); break; 
             case "level2Weight":  level2Weight = ele.ReadInt(); break; 
             case "libContent":  libContent = cfg.Extensions.xml_unmarshal_list_cfg_battle_RandomBuffLibContent(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RandomBuffLib");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         ele.WriteStartElement("level1Weight"); ele.WriteInt(level1Weight); ele.WriteEndElement();
         ele.WriteStartElement("level2Weight"); ele.WriteInt(level2Weight); ele.WriteEndElement();
         ele.WriteStartElement("libContent"); cfg.Extensions.xml_marshal_list_cfg_battle_RandomBuffLibContent(libContent,ele); ele.WriteEndElement();
         
    }


}
}
}
