using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleSkillUpgradeInfo :   cfg.EditorWriter 
 {

    public cfg.common.Cost upgradeCost ;
     public int refSkillId ;
     



    public const int TYPE_ID = 62863;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleSkillUpgradeInfo(Perfect.Marshal.Octets os) {

        upgradeCost = cfg.Extensions.unmarshal_cfg_common_Cost(os); 
         refSkillId = os.ReadInt(); 
         
    }

    public CastleSkillUpgradeInfo()
    {
    }

    public CastleSkillUpgradeInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "upgradeCost":  upgradeCost = cfg.Extensions.xml_unmarshal_cfg_common_Cost(ele); break; 
             case "refSkillId":  refSkillId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleSkillUpgradeInfo");
        ele.WriteStartElement("upgradeCost"); cfg.Extensions.xml_marshal_cfg_common_Cost(upgradeCost,ele); ele.WriteEndElement();
         ele.WriteStartElement("refSkillId"); ele.WriteInt(refSkillId); ele.WriteEndElement();
         
    }


}
}
}
