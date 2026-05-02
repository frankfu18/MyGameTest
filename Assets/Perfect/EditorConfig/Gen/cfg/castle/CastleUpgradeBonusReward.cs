using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleUpgradeBonusReward : CastleUpgradeReward
 {

    public cfg.bonus.Bonus bonus ;
     



    public const int TYPE_ID = 42259;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleUpgradeBonusReward(Perfect.Marshal.Octets os) : base(os)  {

        bonus = cfg.Extensions.unmarshal_cfg_bonus_Bonus(os); 
         
    }

    public CastleUpgradeBonusReward()
    {
    }

    public CastleUpgradeBonusReward(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "bonus":  bonus = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleUpgradeBonusReward");
        ele.WriteStartElement("bonus"); cfg.Extensions.xml_marshal_cfg_bonus_Bonus(bonus,ele); ele.WriteEndElement();
         
    }


}
}
}
