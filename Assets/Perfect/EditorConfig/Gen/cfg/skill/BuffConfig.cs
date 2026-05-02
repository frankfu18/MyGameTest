using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BuffConfig :   cfg.EditorWriter 
 {

    public int id ;
     public string des  = "";
     public cfg.skill.EBuffType buffType ;
     public int triggerPercent ;
     public cfg.skill.BuffTriggerType triggerType ;
     public cfg.skill.BuffDestroyType destroyType ;
     public int resId ;
     public cfg.skill.EBuffStateType buffStateType ;
     public cfg.skill.BuffStatcking buffStacking ;
     public cfg.skill.BuffEffectType effectType ;
     public cfg.skill.BuffEffectContent effectContent ;
     



    public const int TYPE_ID = 65000;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BuffConfig(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         des = os.ReadString(); 
         buffType = (cfg.skill.EBuffType)(os.ReadInt()); 
         triggerPercent = os.ReadInt(); 
         triggerType = cfg.Extensions.unmarshal_cfg_skill_BuffTriggerType(os); 
         destroyType = cfg.Extensions.unmarshal_cfg_skill_BuffDestroyType(os); 
         resId = os.ReadInt(); 
         buffStateType = (cfg.skill.EBuffStateType)(os.ReadInt()); 
         buffStacking = cfg.Extensions.unmarshal_cfg_skill_BuffStatcking(os); 
         effectType = cfg.Extensions.unmarshal_cfg_skill_BuffEffectType(os); 
         effectContent = cfg.Extensions.unmarshal_cfg_skill_BuffEffectContent(os); 
         
    }

    public BuffConfig()
    {
    }

    public BuffConfig(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "des":  des = ele.ReadString2(); break; 
             case "buffType":  buffType = ele.ReadEnum<cfg.skill.EBuffType>(); break; 
             case "triggerPercent":  triggerPercent = ele.ReadInt(); break; 
             case "triggerType":  triggerType = cfg.Extensions.xml_unmarshal_cfg_skill_BuffTriggerType(ele); break; 
             case "destroyType":  destroyType = cfg.Extensions.xml_unmarshal_cfg_skill_BuffDestroyType(ele); break; 
             case "resId":  resId = ele.ReadInt(); break; 
             case "buffStateType":  buffStateType = ele.ReadEnum<cfg.skill.EBuffStateType>(); break; 
             case "buffStacking":  buffStacking = cfg.Extensions.xml_unmarshal_cfg_skill_BuffStatcking(ele); break; 
             case "effectType":  effectType = cfg.Extensions.xml_unmarshal_cfg_skill_BuffEffectType(ele); break; 
             case "effectContent":  effectContent = cfg.Extensions.xml_unmarshal_cfg_skill_BuffEffectContent(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BuffConfig");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("des"); ele.WriteString2(des); ele.WriteEndElement();
         ele.WriteStartElement("buffType"); ele.WriteEnum(buffType); ele.WriteEndElement();
         ele.WriteStartElement("triggerPercent"); ele.WriteInt(triggerPercent); ele.WriteEndElement();
         ele.WriteStartElement("triggerType"); cfg.Extensions.xml_marshal_cfg_skill_BuffTriggerType(triggerType,ele); ele.WriteEndElement();
         ele.WriteStartElement("destroyType"); cfg.Extensions.xml_marshal_cfg_skill_BuffDestroyType(destroyType,ele); ele.WriteEndElement();
         ele.WriteStartElement("resId"); ele.WriteInt(resId); ele.WriteEndElement();
         ele.WriteStartElement("buffStateType"); ele.WriteEnum(buffStateType); ele.WriteEndElement();
         ele.WriteStartElement("buffStacking"); cfg.Extensions.xml_marshal_cfg_skill_BuffStatcking(buffStacking,ele); ele.WriteEndElement();
         ele.WriteStartElement("effectType"); cfg.Extensions.xml_marshal_cfg_skill_BuffEffectType(effectType,ele); ele.WriteEndElement();
         ele.WriteStartElement("effectContent"); cfg.Extensions.xml_marshal_cfg_skill_BuffEffectContent(effectContent,ele); ele.WriteEndElement();
         
    }


}
}
}
