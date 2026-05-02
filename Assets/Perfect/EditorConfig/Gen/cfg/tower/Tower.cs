using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class Tower :   cfg.EditorWriter 
 {

    public cfg.tower.ETowerType towerType ;
     public string note  = "";
     public string name  = "";
     public cfg.item.EItemQuality quality ;
     public cfg.attribute.EDamageType damageType ;
     public cfg.tower.ETowerTargetType targetType ;
     public string icon  = "";
     public string desc  = "";
     public int resId ;
     public cfg.condition.Condition unlockCondition ;
     public int skillId ;
     public float atkRadiusRange ;
     public string atkBlockRange  = "";
     public System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> baseAttrs  = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
     



    public const int TYPE_ID = 7526;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Tower(Perfect.Marshal.Octets os) {

        towerType = (cfg.tower.ETowerType)(os.ReadInt()); 
         note = os.ReadString(); 
         name = os.ReadString(); 
         quality = (cfg.item.EItemQuality)(os.ReadInt()); 
         damageType = (cfg.attribute.EDamageType)(os.ReadInt()); 
         targetType = (cfg.tower.ETowerTargetType)(os.ReadInt()); 
         icon = os.ReadString(); 
         desc = os.ReadString(); 
         resId = os.ReadInt(); 
         unlockCondition = cfg.Extensions.unmarshal_cfg_condition_Condition(os); 
         skillId = os.ReadInt(); 
         atkRadiusRange = os.ReadFloat(); 
         atkBlockRange = os.ReadString(); 
         baseAttrs = cfg.Extensions.unmarshal_list_cfg_attribute_AttributeLongNumber(os); 
         
    }

    public Tower()
    {
    }

    public Tower(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "towerType":  towerType = ele.ReadEnum<cfg.tower.ETowerType>(); break; 
             case "note":  note = ele.ReadString2(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "quality":  quality = ele.ReadEnum<cfg.item.EItemQuality>(); break; 
             case "damageType":  damageType = ele.ReadEnum<cfg.attribute.EDamageType>(); break; 
             case "targetType":  targetType = ele.ReadEnum<cfg.tower.ETowerTargetType>(); break; 
             case "icon":  icon = ele.ReadString2(); break; 
             case "desc":  desc = ele.ReadString2(); break; 
             case "resId":  resId = ele.ReadInt(); break; 
             case "unlockCondition":  unlockCondition = cfg.Extensions.xml_unmarshal_cfg_condition_Condition(ele); break; 
             case "skillId":  skillId = ele.ReadInt(); break; 
             case "atkRadiusRange":  atkRadiusRange = ele.ReadFloat(); break; 
             case "atkBlockRange":  atkBlockRange = ele.ReadString2(); break; 
             case "baseAttrs":  baseAttrs = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Tower");
        ele.WriteStartElement("towerType"); ele.WriteEnum(towerType); ele.WriteEndElement();
         ele.WriteStartElement("note"); ele.WriteString2(note); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("quality"); ele.WriteEnum(quality); ele.WriteEndElement();
         ele.WriteStartElement("damageType"); ele.WriteEnum(damageType); ele.WriteEndElement();
         ele.WriteStartElement("targetType"); ele.WriteEnum(targetType); ele.WriteEndElement();
         ele.WriteStartElement("icon"); ele.WriteString2(icon); ele.WriteEndElement();
         ele.WriteStartElement("desc"); ele.WriteString2(desc); ele.WriteEndElement();
         ele.WriteStartElement("resId"); ele.WriteInt(resId); ele.WriteEndElement();
         ele.WriteStartElement("unlockCondition"); cfg.Extensions.xml_marshal_cfg_condition_Condition(unlockCondition,ele); ele.WriteEndElement();
         ele.WriteStartElement("skillId"); ele.WriteInt(skillId); ele.WriteEndElement();
         ele.WriteStartElement("atkRadiusRange"); ele.WriteFloat(atkRadiusRange); ele.WriteEndElement();
         ele.WriteStartElement("atkBlockRange"); ele.WriteString2(atkBlockRange); ele.WriteEndElement();
         ele.WriteStartElement("baseAttrs"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(baseAttrs,ele); ele.WriteEndElement();
         
    }


}
}
}
