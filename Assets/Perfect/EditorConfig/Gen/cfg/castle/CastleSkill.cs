using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleSkill :   cfg.EditorWriter 
 {

    public int id ;
     public string name  = "";
     public string des  = "";
     public string icon  = "";
     public int initLv ;
     public int maxLv ;
     public System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo> upgradeLvInfoDic  = new System.Collections.Generic.Dictionary<int,cfg.castle.CastleSkillUpgradeInfo>();
     



    public const int TYPE_ID = 8211;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleSkill(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         name = os.ReadString(); 
         des = os.ReadString(); 
         icon = os.ReadString(); 
         initLv = os.ReadInt(); 
         maxLv = os.ReadInt(); 
         upgradeLvInfoDic = cfg.Extensions.unmarshal_map_int_cfg_castle_CastleSkillUpgradeInfo(os); 
         
    }

    public CastleSkill()
    {
    }

    public CastleSkill(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "des":  des = ele.ReadString2(); break; 
             case "icon":  icon = ele.ReadString2(); break; 
             case "initLv":  initLv = ele.ReadInt(); break; 
             case "maxLv":  maxLv = ele.ReadInt(); break; 
             case "upgradeLvInfoDic":  upgradeLvInfoDic = cfg.Extensions.xml_unmarshal_map_int_cfg_castle_CastleSkillUpgradeInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleSkill");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("des"); ele.WriteString2(des); ele.WriteEndElement();
         ele.WriteStartElement("icon"); ele.WriteString2(icon); ele.WriteEndElement();
         ele.WriteStartElement("initLv"); ele.WriteInt(initLv); ele.WriteEndElement();
         ele.WriteStartElement("maxLv"); ele.WriteInt(maxLv); ele.WriteEndElement();
         ele.WriteStartElement("upgradeLvInfoDic"); cfg.Extensions.xml_marshal_map_int_cfg_castle_CastleSkillUpgradeInfo(upgradeLvInfoDic,ele); ele.WriteEndElement();
         
    }


}
}
}
