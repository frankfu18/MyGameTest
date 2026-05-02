using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BulletTrackConfig :   cfg.EditorWriter 
 {

    public int id ;
     public cfg.skill.EBulletTrackType bulletTrackType ;
     public float randomXMin ;
     public float randomXMax ;
     public float randomYMin ;
     public float randomYMax ;
     



    public const int TYPE_ID = 40877;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BulletTrackConfig(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         bulletTrackType = (cfg.skill.EBulletTrackType)(os.ReadInt()); 
         randomXMin = os.ReadFloat(); 
         randomXMax = os.ReadFloat(); 
         randomYMin = os.ReadFloat(); 
         randomYMax = os.ReadFloat(); 
         
    }

    public BulletTrackConfig()
    {
    }

    public BulletTrackConfig(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "bulletTrackType":  bulletTrackType = ele.ReadEnum<cfg.skill.EBulletTrackType>(); break; 
             case "randomXMin":  randomXMin = ele.ReadFloat(); break; 
             case "randomXMax":  randomXMax = ele.ReadFloat(); break; 
             case "randomYMin":  randomYMin = ele.ReadFloat(); break; 
             case "randomYMax":  randomYMax = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BulletTrackConfig");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("bulletTrackType"); ele.WriteEnum(bulletTrackType); ele.WriteEndElement();
         ele.WriteStartElement("randomXMin"); ele.WriteFloat(randomXMin); ele.WriteEndElement();
         ele.WriteStartElement("randomXMax"); ele.WriteFloat(randomXMax); ele.WriteEndElement();
         ele.WriteStartElement("randomYMin"); ele.WriteFloat(randomYMin); ele.WriteEndElement();
         ele.WriteStartElement("randomYMax"); ele.WriteFloat(randomYMax); ele.WriteEndElement();
         
    }


}
}
}
