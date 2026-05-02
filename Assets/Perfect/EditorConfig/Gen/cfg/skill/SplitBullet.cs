using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class SplitBullet : BuffEffectContent
 {

    public int bulletId ;
     public int bulletNum ;
     public int radius ;
     public float damageRatio ;
     



    public const int TYPE_ID = 59923;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SplitBullet(Perfect.Marshal.Octets os) : base(os)  {

        bulletId = os.ReadInt(); 
         bulletNum = os.ReadInt(); 
         radius = os.ReadInt(); 
         damageRatio = os.ReadFloat(); 
         
    }

    public SplitBullet()
    {
    }

    public SplitBullet(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "bulletId":  bulletId = ele.ReadInt(); break; 
             case "bulletNum":  bulletNum = ele.ReadInt(); break; 
             case "radius":  radius = ele.ReadInt(); break; 
             case "damageRatio":  damageRatio = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SplitBullet");
        ele.WriteStartElement("bulletId"); ele.WriteInt(bulletId); ele.WriteEndElement();
         ele.WriteStartElement("bulletNum"); ele.WriteInt(bulletNum); ele.WriteEndElement();
         ele.WriteStartElement("radius"); ele.WriteInt(radius); ele.WriteEndElement();
         ele.WriteStartElement("damageRatio"); ele.WriteFloat(damageRatio); ele.WriteEndElement();
         
    }


}
}
}
