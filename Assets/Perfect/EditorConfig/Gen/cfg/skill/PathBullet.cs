using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class PathBullet : BulletType
 {

    public float speed ;
     public float maxMoveDistance ;
     public int backNum ;
     



    public const int TYPE_ID = 35645;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public PathBullet(Perfect.Marshal.Octets os) : base(os)  {

        speed = os.ReadFloat(); 
         maxMoveDistance = os.ReadFloat(); 
         backNum = os.ReadInt(); 
         
    }

    public PathBullet()
    {
    }

    public PathBullet(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "speed":  speed = ele.ReadFloat(); break; 
             case "maxMoveDistance":  maxMoveDistance = ele.ReadFloat(); break; 
             case "backNum":  backNum = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "PathBullet");
        ele.WriteStartElement("speed"); ele.WriteFloat(speed); ele.WriteEndElement();
         ele.WriteStartElement("maxMoveDistance"); ele.WriteFloat(maxMoveDistance); ele.WriteEndElement();
         ele.WriteStartElement("backNum"); ele.WriteInt(backNum); ele.WriteEndElement();
         
    }


}
}
}
