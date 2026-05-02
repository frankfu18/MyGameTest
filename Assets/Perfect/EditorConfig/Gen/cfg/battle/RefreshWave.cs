using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RefreshWave :   cfg.EditorWriter 
 {

    public float startDelay ;
     public float attackMultiple ;
     public float hpMultiple ;
     public float speedMultiple ;
     public System.Collections.Generic.List<cfg.battle.RefreshMonster> refreshMonster  = new System.Collections.Generic.List<cfg.battle.RefreshMonster>();
     



    public const int TYPE_ID = 59168;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RefreshWave(Perfect.Marshal.Octets os) {

        startDelay = os.ReadFloat(); 
         attackMultiple = os.ReadFloat(); 
         hpMultiple = os.ReadFloat(); 
         speedMultiple = os.ReadFloat(); 
         refreshMonster = cfg.Extensions.unmarshal_list_cfg_battle_RefreshMonster(os); 
         
    }

    public RefreshWave()
    {
    }

    public RefreshWave(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "startDelay":  startDelay = ele.ReadFloat(); break; 
             case "attackMultiple":  attackMultiple = ele.ReadFloat(); break; 
             case "hpMultiple":  hpMultiple = ele.ReadFloat(); break; 
             case "speedMultiple":  speedMultiple = ele.ReadFloat(); break; 
             case "refreshMonster":  refreshMonster = cfg.Extensions.xml_unmarshal_list_cfg_battle_RefreshMonster(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RefreshWave");
        ele.WriteStartElement("startDelay"); ele.WriteFloat(startDelay); ele.WriteEndElement();
         ele.WriteStartElement("attackMultiple"); ele.WriteFloat(attackMultiple); ele.WriteEndElement();
         ele.WriteStartElement("hpMultiple"); ele.WriteFloat(hpMultiple); ele.WriteEndElement();
         ele.WriteStartElement("speedMultiple"); ele.WriteFloat(speedMultiple); ele.WriteEndElement();
         ele.WriteStartElement("refreshMonster"); cfg.Extensions.xml_marshal_list_cfg_battle_RefreshMonster(refreshMonster,ele); ele.WriteEndElement();
         
    }


}
}
}
