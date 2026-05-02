using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class SkillReleaseConfig :   cfg.EditorWriter 
 {

    public int id ;
     public string note  = "";
     public cfg.skill.ESkillType skillType ;
     public int baseId ;
     public float skillCD ;
     public cfg.skill.SkillReleaseType releaseType ;
     public cfg.skill.ESkillTargetStrategy skillTargetStrategy ;
     public bool mark ;
     public float beforeReleaseTime ;
     public float releaseDuration ;
     public float releaseInterval ;
     public int releaseNum ;
     public int releaseId ;
     public bool multiMuzzle ;
     



    public const int TYPE_ID = 17610;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SkillReleaseConfig(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         note = os.ReadString(); 
         skillType = (cfg.skill.ESkillType)(os.ReadInt()); 
         baseId = os.ReadInt(); 
         skillCD = os.ReadFloat(); 
         releaseType = cfg.Extensions.unmarshal_cfg_skill_SkillReleaseType(os); 
         skillTargetStrategy = (cfg.skill.ESkillTargetStrategy)(os.ReadInt()); 
         mark = os.ReadBool(); 
         beforeReleaseTime = os.ReadFloat(); 
         releaseDuration = os.ReadFloat(); 
         releaseInterval = os.ReadFloat(); 
         releaseNum = os.ReadInt(); 
         releaseId = os.ReadInt(); 
         multiMuzzle = os.ReadBool(); 
         
    }

    public SkillReleaseConfig()
    {
    }

    public SkillReleaseConfig(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "note":  note = ele.ReadString2(); break; 
             case "skillType":  skillType = ele.ReadEnum<cfg.skill.ESkillType>(); break; 
             case "baseId":  baseId = ele.ReadInt(); break; 
             case "skillCD":  skillCD = ele.ReadFloat(); break; 
             case "releaseType":  releaseType = cfg.Extensions.xml_unmarshal_cfg_skill_SkillReleaseType(ele); break; 
             case "skillTargetStrategy":  skillTargetStrategy = ele.ReadEnum<cfg.skill.ESkillTargetStrategy>(); break; 
             case "mark":  mark = ele.ReadBool(); break; 
             case "beforeReleaseTime":  beforeReleaseTime = ele.ReadFloat(); break; 
             case "releaseDuration":  releaseDuration = ele.ReadFloat(); break; 
             case "releaseInterval":  releaseInterval = ele.ReadFloat(); break; 
             case "releaseNum":  releaseNum = ele.ReadInt(); break; 
             case "releaseId":  releaseId = ele.ReadInt(); break; 
             case "multiMuzzle":  multiMuzzle = ele.ReadBool(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SkillReleaseConfig");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("note"); ele.WriteString2(note); ele.WriteEndElement();
         ele.WriteStartElement("skillType"); ele.WriteEnum(skillType); ele.WriteEndElement();
         ele.WriteStartElement("baseId"); ele.WriteInt(baseId); ele.WriteEndElement();
         ele.WriteStartElement("skillCD"); ele.WriteFloat(skillCD); ele.WriteEndElement();
         ele.WriteStartElement("releaseType"); cfg.Extensions.xml_marshal_cfg_skill_SkillReleaseType(releaseType,ele); ele.WriteEndElement();
         ele.WriteStartElement("skillTargetStrategy"); ele.WriteEnum(skillTargetStrategy); ele.WriteEndElement();
         ele.WriteStartElement("mark"); ele.WriteBool(mark); ele.WriteEndElement();
         ele.WriteStartElement("beforeReleaseTime"); ele.WriteFloat(beforeReleaseTime); ele.WriteEndElement();
         ele.WriteStartElement("releaseDuration"); ele.WriteFloat(releaseDuration); ele.WriteEndElement();
         ele.WriteStartElement("releaseInterval"); ele.WriteFloat(releaseInterval); ele.WriteEndElement();
         ele.WriteStartElement("releaseNum"); ele.WriteInt(releaseNum); ele.WriteEndElement();
         ele.WriteStartElement("releaseId"); ele.WriteInt(releaseId); ele.WriteEndElement();
         ele.WriteStartElement("multiMuzzle"); ele.WriteBool(multiMuzzle); ele.WriteEndElement();
         
    }


}
}
}
