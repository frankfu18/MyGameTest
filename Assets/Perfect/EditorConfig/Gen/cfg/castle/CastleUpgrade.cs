using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleUpgrade :   cfg.EditorWriter 
 {

    public int level ;
     public int exp ;
     public cfg.castle.CastleUpgradeReward reward ;
     



    public const int TYPE_ID = 47184;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleUpgrade(Perfect.Marshal.Octets os) {

        level = os.ReadInt(); 
         exp = os.ReadInt(); 
         reward = cfg.Extensions.unmarshal_cfg_castle_CastleUpgradeReward(os); 
         
    }

    public CastleUpgrade()
    {
    }

    public CastleUpgrade(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             case "exp":  exp = ele.ReadInt(); break; 
             case "reward":  reward = cfg.Extensions.xml_unmarshal_cfg_castle_CastleUpgradeReward(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleUpgrade");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         ele.WriteStartElement("exp"); ele.WriteInt(exp); ele.WriteEndElement();
         ele.WriteStartElement("reward"); cfg.Extensions.xml_marshal_cfg_castle_CastleUpgradeReward(reward,ele); ele.WriteEndElement();
         
    }


}
}
}
