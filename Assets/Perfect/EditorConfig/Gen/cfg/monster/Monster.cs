using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.monster
{
[System.Serializable]
public  class Monster :   cfg.EditorWriter 
 {

    public int id ;
     public cfg.monster.EMonsterType monsterType ;
     public string name  = "";
     public string icon  = "";
     public string desc  = "";
     public int resId ;
     public int exp ;
     public int gold ;
     public int energy ;
     public float radius ;
     public int pathAtkRange ;
     public int skillId ;
     public System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> baseAttrs  = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
     



    public const int TYPE_ID = 41826;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Monster(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         monsterType = (cfg.monster.EMonsterType)(os.ReadInt()); 
         name = os.ReadString(); 
         icon = os.ReadString(); 
         desc = os.ReadString(); 
         resId = os.ReadInt(); 
         exp = os.ReadInt(); 
         gold = os.ReadInt(); 
         energy = os.ReadInt(); 
         radius = os.ReadFloat(); 
         pathAtkRange = os.ReadInt(); 
         skillId = os.ReadInt(); 
         baseAttrs = cfg.Extensions.unmarshal_list_cfg_attribute_AttributeLongNumber(os); 
         
    }

    public Monster()
    {
    }

    public Monster(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "monsterType":  monsterType = ele.ReadEnum<cfg.monster.EMonsterType>(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "icon":  icon = ele.ReadString2(); break; 
             case "desc":  desc = ele.ReadString2(); break; 
             case "resId":  resId = ele.ReadInt(); break; 
             case "exp":  exp = ele.ReadInt(); break; 
             case "gold":  gold = ele.ReadInt(); break; 
             case "energy":  energy = ele.ReadInt(); break; 
             case "radius":  radius = ele.ReadFloat(); break; 
             case "pathAtkRange":  pathAtkRange = ele.ReadInt(); break; 
             case "skillId":  skillId = ele.ReadInt(); break; 
             case "baseAttrs":  baseAttrs = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Monster");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("monsterType"); ele.WriteEnum(monsterType); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("icon"); ele.WriteString2(icon); ele.WriteEndElement();
         ele.WriteStartElement("desc"); ele.WriteString2(desc); ele.WriteEndElement();
         ele.WriteStartElement("resId"); ele.WriteInt(resId); ele.WriteEndElement();
         ele.WriteStartElement("exp"); ele.WriteInt(exp); ele.WriteEndElement();
         ele.WriteStartElement("gold"); ele.WriteInt(gold); ele.WriteEndElement();
         ele.WriteStartElement("energy"); ele.WriteInt(energy); ele.WriteEndElement();
         ele.WriteStartElement("radius"); ele.WriteFloat(radius); ele.WriteEndElement();
         ele.WriteStartElement("pathAtkRange"); ele.WriteInt(pathAtkRange); ele.WriteEndElement();
         ele.WriteStartElement("skillId"); ele.WriteInt(skillId); ele.WriteEndElement();
         ele.WriteStartElement("baseAttrs"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(baseAttrs,ele); ele.WriteEndElement();
         
    }


}
}
}
