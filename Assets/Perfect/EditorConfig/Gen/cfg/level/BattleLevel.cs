using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.level
{
[System.Serializable]
public  class BattleLevel :   cfg.EditorWriter 
 {

    public cfg.level.ELevelType levelType ;
     public int initPower ;
     public int maxPower ;
     



    public const int TYPE_ID = 13048;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BattleLevel(Perfect.Marshal.Octets os) {

        levelType = (cfg.level.ELevelType)(os.ReadInt()); 
         initPower = os.ReadInt(); 
         maxPower = os.ReadInt(); 
         
    }

    public BattleLevel()
    {
    }

    public BattleLevel(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "levelType":  levelType = ele.ReadEnum<cfg.level.ELevelType>(); break; 
             case "initPower":  initPower = ele.ReadInt(); break; 
             case "maxPower":  maxPower = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BattleLevel");
        ele.WriteStartElement("levelType"); ele.WriteEnum(levelType); ele.WriteEndElement();
         ele.WriteStartElement("initPower"); ele.WriteInt(initPower); ele.WriteEndElement();
         ele.WriteStartElement("maxPower"); ele.WriteInt(maxPower); ele.WriteEndElement();
         
    }


}
}
}
