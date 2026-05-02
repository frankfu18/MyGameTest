using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class TowerUpgrade :   cfg.EditorWriter 
 {

    public cfg.tower.ETowerType towerType ;
     public int buffLvWeight ;
     public int maxLv ;
     public System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo> upgrades  = new System.Collections.Generic.Dictionary<int,cfg.tower.TowerUpgradeInfo>();
     



    public const int TYPE_ID = 55969;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public TowerUpgrade(Perfect.Marshal.Octets os) {

        towerType = (cfg.tower.ETowerType)(os.ReadInt()); 
         buffLvWeight = os.ReadInt(); 
         maxLv = os.ReadInt(); 
         upgrades = cfg.Extensions.unmarshal_map_int_cfg_tower_TowerUpgradeInfo(os); 
         
    }

    public TowerUpgrade()
    {
    }

    public TowerUpgrade(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "towerType":  towerType = ele.ReadEnum<cfg.tower.ETowerType>(); break; 
             case "buffLvWeight":  buffLvWeight = ele.ReadInt(); break; 
             case "maxLv":  maxLv = ele.ReadInt(); break; 
             case "upgrades":  upgrades = cfg.Extensions.xml_unmarshal_map_int_cfg_tower_TowerUpgradeInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "TowerUpgrade");
        ele.WriteStartElement("towerType"); ele.WriteEnum(towerType); ele.WriteEndElement();
         ele.WriteStartElement("buffLvWeight"); ele.WriteInt(buffLvWeight); ele.WriteEndElement();
         ele.WriteStartElement("maxLv"); ele.WriteInt(maxLv); ele.WriteEndElement();
         ele.WriteStartElement("upgrades"); cfg.Extensions.xml_marshal_map_int_cfg_tower_TowerUpgradeInfo(upgrades,ele); ele.WriteEndElement();
         
    }


}
}
}
