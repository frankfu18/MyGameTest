using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitSpTypeMonster : BuffTriggerType
 {

    public cfg.monster.EMonsterType monsterType ;
     



    public const int TYPE_ID = 41057;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitSpTypeMonster(Perfect.Marshal.Octets os) : base(os)  {

        monsterType = (cfg.monster.EMonsterType)(os.ReadInt()); 
         
    }

    public HitSpTypeMonster()
    {
    }

    public HitSpTypeMonster(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "monsterType":  monsterType = ele.ReadEnum<cfg.monster.EMonsterType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "HitSpTypeMonster");
        ele.WriteStartElement("monsterType"); ele.WriteEnum(monsterType); ele.WriteEndElement();
         
    }


}
}
}
