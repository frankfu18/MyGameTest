using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.item
{
[System.Serializable]
public  class TowerFragmentInfo : ItemInfo
 {

    public cfg.tower.ETowerType towerType ;
     



    public const int TYPE_ID = 41267;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public TowerFragmentInfo(Perfect.Marshal.Octets os) : base(os)  {

        towerType = (cfg.tower.ETowerType)(os.ReadInt()); 
         
    }

    public TowerFragmentInfo()
    {
    }

    public TowerFragmentInfo(XmlElement e)
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
        ele.WriteAttributeString("type", "TowerFragmentInfo");
        ele.WriteStartElement("towerType"); ele.WriteEnum(towerType); ele.WriteEndElement();
         
    }


}
}
}
