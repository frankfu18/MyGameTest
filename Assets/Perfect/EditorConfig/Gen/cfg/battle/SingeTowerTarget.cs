using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SingeTowerTarget : EffectTarget
 {

    public cfg.tower.ETowerType towerType ;
     



    public const int TYPE_ID = 2608;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SingeTowerTarget(Perfect.Marshal.Octets os) : base(os)  {

        towerType = (cfg.tower.ETowerType)(os.ReadInt()); 
         
    }

    public SingeTowerTarget()
    {
    }

    public SingeTowerTarget(XmlElement e)
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
        ele.WriteAttributeString("type", "SingeTowerTarget");
        ele.WriteStartElement("towerType"); ele.WriteEnum(towerType); ele.WriteEndElement();
         
    }


}
}
}
