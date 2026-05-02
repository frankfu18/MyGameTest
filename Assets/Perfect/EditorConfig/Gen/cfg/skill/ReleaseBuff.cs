using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class ReleaseBuff : SkillReleaseType
 {

    public int buffId ;
     public cfg.battle.EffectTarget effectType ;
     



    public const int TYPE_ID = 50220;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ReleaseBuff(Perfect.Marshal.Octets os) : base(os)  {

        buffId = os.ReadInt(); 
         effectType = cfg.Extensions.unmarshal_cfg_battle_EffectTarget(os); 
         
    }

    public ReleaseBuff()
    {
    }

    public ReleaseBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffId":  buffId = ele.ReadInt(); break; 
             case "effectType":  effectType = cfg.Extensions.xml_unmarshal_cfg_battle_EffectTarget(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ReleaseBuff");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         ele.WriteStartElement("effectType"); cfg.Extensions.xml_marshal_cfg_battle_EffectTarget(effectType,ele); ele.WriteEndElement();
         
    }


}
}
}
