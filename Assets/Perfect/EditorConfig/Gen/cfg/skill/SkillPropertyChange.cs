using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class SkillPropertyChange : BuffEffectContent
 {

    public cfg.skill.ESkillPropertyType skillPropertyType ;
     public int skillId ;
     public bool isAdd ;
     public bool isPercent ;
     public float propertyValue ;
     public float limitValue ;
     



    public const int TYPE_ID = 32891;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SkillPropertyChange(Perfect.Marshal.Octets os) : base(os)  {

        skillPropertyType = (cfg.skill.ESkillPropertyType)(os.ReadInt()); 
         skillId = os.ReadInt(); 
         isAdd = os.ReadBool(); 
         isPercent = os.ReadBool(); 
         propertyValue = os.ReadFloat(); 
         limitValue = os.ReadFloat(); 
         
    }

    public SkillPropertyChange()
    {
    }

    public SkillPropertyChange(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "skillPropertyType":  skillPropertyType = ele.ReadEnum<cfg.skill.ESkillPropertyType>(); break; 
             case "skillId":  skillId = ele.ReadInt(); break; 
             case "isAdd":  isAdd = ele.ReadBool(); break; 
             case "isPercent":  isPercent = ele.ReadBool(); break; 
             case "propertyValue":  propertyValue = ele.ReadFloat(); break; 
             case "limitValue":  limitValue = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SkillPropertyChange");
        ele.WriteStartElement("skillPropertyType"); ele.WriteEnum(skillPropertyType); ele.WriteEndElement();
         ele.WriteStartElement("skillId"); ele.WriteInt(skillId); ele.WriteEndElement();
         ele.WriteStartElement("isAdd"); ele.WriteBool(isAdd); ele.WriteEndElement();
         ele.WriteStartElement("isPercent"); ele.WriteBool(isPercent); ele.WriteEndElement();
         ele.WriteStartElement("propertyValue"); ele.WriteFloat(propertyValue); ele.WriteEndElement();
         ele.WriteStartElement("limitValue"); ele.WriteFloat(limitValue); ele.WriteEndElement();
         
    }


}
}
}
