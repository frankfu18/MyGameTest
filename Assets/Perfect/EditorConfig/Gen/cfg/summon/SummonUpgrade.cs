using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.summon
{
[System.Serializable]
public  class SummonUpgrade :   cfg.EditorWriter 
 {

    public int level ;
     public int totalExp ;
     public System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus> addBonusMap  = new System.Collections.Generic.Dictionary<cfg.summon.ESummonType,cfg.bonus.Bonus>();
     



    public const int TYPE_ID = 61598;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SummonUpgrade(Perfect.Marshal.Octets os) {

        level = os.ReadInt(); 
         totalExp = os.ReadInt(); 
         addBonusMap = cfg.Extensions.unmarshal_map_cfg_summon_ESummonType_cfg_bonus_Bonus(os); 
         
    }

    public SummonUpgrade()
    {
    }

    public SummonUpgrade(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             case "totalExp":  totalExp = ele.ReadInt(); break; 
             case "addBonusMap":  addBonusMap = cfg.Extensions.xml_unmarshal_map_cfg_summon_ESummonType_cfg_bonus_Bonus(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SummonUpgrade");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         ele.WriteStartElement("totalExp"); ele.WriteInt(totalExp); ele.WriteEndElement();
         ele.WriteStartElement("addBonusMap"); cfg.Extensions.xml_marshal_map_cfg_summon_ESummonType_cfg_bonus_Bonus(addBonusMap,ele); ele.WriteEndElement();
         
    }


}
}
}
