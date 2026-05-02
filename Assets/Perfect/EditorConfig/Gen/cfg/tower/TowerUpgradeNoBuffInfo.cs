using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class TowerUpgradeNoBuffInfo : TowerUpgradeInfo
 {




    public const int TYPE_ID = 15725;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public TowerUpgradeNoBuffInfo(Perfect.Marshal.Octets os) : base(os)  {

    }

    public TowerUpgradeNoBuffInfo()
    {
    }

    public TowerUpgradeNoBuffInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "upgradeCost":  upgradeCost = cfg.Extensions.xml_unmarshal_cfg_common_Cost(ele); break; 
             case "attrs":  attrs = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "TowerUpgradeNoBuffInfo");
        ele.WriteStartElement("upgradeCost"); cfg.Extensions.xml_marshal_cfg_common_Cost(upgradeCost,ele); ele.WriteEndElement();
         ele.WriteStartElement("attrs"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(attrs,ele); ele.WriteEndElement();
         
    }


}
}
}
