using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.summon
{
[System.Serializable]
public  class SummonReward :   cfg.EditorWriter 
 {

    public cfg.summon.ESummonType summonType ;
     public cfg.bonus.Bonus firstBonus ;
     public cfg.bonus.Bonus normalBonus ;
     



    public const int TYPE_ID = 28787;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SummonReward(Perfect.Marshal.Octets os) {

        summonType = (cfg.summon.ESummonType)(os.ReadInt()); 
         firstBonus = cfg.Extensions.unmarshal_cfg_bonus_Bonus(os); 
         normalBonus = cfg.Extensions.unmarshal_cfg_bonus_Bonus(os); 
         
    }

    public SummonReward()
    {
    }

    public SummonReward(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "summonType":  summonType = ele.ReadEnum<cfg.summon.ESummonType>(); break; 
             case "firstBonus":  firstBonus = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(ele); break; 
             case "normalBonus":  normalBonus = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SummonReward");
        ele.WriteStartElement("summonType"); ele.WriteEnum(summonType); ele.WriteEndElement();
         ele.WriteStartElement("firstBonus"); cfg.Extensions.xml_marshal_cfg_bonus_Bonus(firstBonus,ele); ele.WriteEndElement();
         ele.WriteStartElement("normalBonus"); cfg.Extensions.xml_marshal_cfg_bonus_Bonus(normalBonus,ele); ele.WriteEndElement();
         
    }


}
}
}
