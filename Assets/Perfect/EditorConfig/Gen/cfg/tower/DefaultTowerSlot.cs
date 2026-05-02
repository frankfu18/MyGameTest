using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class DefaultTowerSlot : SlotInfo
 {

    public cfg.tower.ETowerType towerType ;
     



    public const int TYPE_ID = 11452;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DefaultTowerSlot(Perfect.Marshal.Octets os) : base(os)  {

        towerType = (cfg.tower.ETowerType)(os.ReadInt()); 
         
    }

    public DefaultTowerSlot()
    {
    }

    public DefaultTowerSlot(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "towerType":  towerType = ele.ReadEnum<cfg.tower.ETowerType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DefaultTowerSlot");
        ele.WriteStartElement("towerType"); ele.WriteEnum(towerType); ele.WriteEndElement();
         
    }


}
}
}
