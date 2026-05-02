using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class TowerUpgradeWithBuffInfo : TowerUpgradeInfo
 {

    public int selectBuffId ;
     



    public const int TYPE_ID = 44057;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public TowerUpgradeWithBuffInfo(Perfect.Marshal.Octets os) : base(os)  {

        selectBuffId = os.ReadInt(); 
         
    }

    public TowerUpgradeWithBuffInfo()
    {
    }

    public TowerUpgradeWithBuffInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "upgradeCost":  upgradeCost = cfg.Extensions.xml_unmarshal_cfg_common_Cost(ele); break; 
             case "attrs":  attrs = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             case "selectBuffId":  selectBuffId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "TowerUpgradeWithBuffInfo");
        ele.WriteStartElement("upgradeCost"); cfg.Extensions.xml_marshal_cfg_common_Cost(upgradeCost,ele); ele.WriteEndElement();
         ele.WriteStartElement("attrs"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(attrs,ele); ele.WriteEndElement();
         ele.WriteStartElement("selectBuffId"); ele.WriteInt(selectBuffId); ele.WriteEndElement();
         
    }


}
}
}
