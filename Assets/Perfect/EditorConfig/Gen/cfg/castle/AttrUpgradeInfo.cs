using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class AttrUpgradeInfo :   cfg.EditorWriter 
 {

    public cfg.common.Cost upgradeCost ;
     public cfg.condition.Condition upgradeCondition ;
     public long curValue ;
     



    public const int TYPE_ID = 1949;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AttrUpgradeInfo(Perfect.Marshal.Octets os) {

        upgradeCost = cfg.Extensions.unmarshal_cfg_common_Cost(os); 
         upgradeCondition = cfg.Extensions.unmarshal_cfg_condition_Condition(os); 
         curValue = os.ReadLong(); 
         
    }

    public AttrUpgradeInfo()
    {
    }

    public AttrUpgradeInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "upgradeCost":  upgradeCost = cfg.Extensions.xml_unmarshal_cfg_common_Cost(ele); break; 
             case "upgradeCondition":  upgradeCondition = cfg.Extensions.xml_unmarshal_cfg_condition_Condition(ele); break; 
             case "curValue":  curValue = ele.ReadLong(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "AttrUpgradeInfo");
        ele.WriteStartElement("upgradeCost"); cfg.Extensions.xml_marshal_cfg_common_Cost(upgradeCost,ele); ele.WriteEndElement();
         ele.WriteStartElement("upgradeCondition"); cfg.Extensions.xml_marshal_cfg_condition_Condition(upgradeCondition,ele); ele.WriteEndElement();
         ele.WriteStartElement("curValue"); ele.WriteLong(curValue); ele.WriteEndElement();
         
    }


}
}
}
