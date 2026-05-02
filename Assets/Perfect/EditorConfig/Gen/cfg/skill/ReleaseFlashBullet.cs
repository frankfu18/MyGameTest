using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class ReleaseFlashBullet : BuffEffectContent
 {

    public int bulletId ;
     public float radius ;
     public int num ;
     public float damageSub ;
     



    public const int TYPE_ID = 7293;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ReleaseFlashBullet(Perfect.Marshal.Octets os) : base(os)  {

        bulletId = os.ReadInt(); 
         radius = os.ReadFloat(); 
         num = os.ReadInt(); 
         damageSub = os.ReadFloat(); 
         
    }

    public ReleaseFlashBullet()
    {
    }

    public ReleaseFlashBullet(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "bulletId":  bulletId = ele.ReadInt(); break; 
             case "radius":  radius = ele.ReadFloat(); break; 
             case "num":  num = ele.ReadInt(); break; 
             case "damageSub":  damageSub = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ReleaseFlashBullet");
        ele.WriteStartElement("bulletId"); ele.WriteInt(bulletId); ele.WriteEndElement();
         ele.WriteStartElement("radius"); ele.WriteFloat(radius); ele.WriteEndElement();
         ele.WriteStartElement("num"); ele.WriteInt(num); ele.WriteEndElement();
         ele.WriteStartElement("damageSub"); ele.WriteFloat(damageSub); ele.WriteEndElement();
         
    }


}
}
}
