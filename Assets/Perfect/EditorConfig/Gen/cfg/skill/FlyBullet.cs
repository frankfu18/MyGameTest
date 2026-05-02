using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class FlyBullet : BulletType
 {

    public float speed ;
     public cfg.skill.EBulletTrackType moveTrackType ;
     public cfg.skill.EBulletFlyDirType flyDirType ;
     public cfg.skill.EBulletBornLayout mutiBulletBornLayout ;
     



    public const int TYPE_ID = 41809;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public FlyBullet(Perfect.Marshal.Octets os) : base(os)  {

        speed = os.ReadFloat(); 
         moveTrackType = (cfg.skill.EBulletTrackType)(os.ReadInt()); 
         flyDirType = (cfg.skill.EBulletFlyDirType)(os.ReadInt()); 
         mutiBulletBornLayout = (cfg.skill.EBulletBornLayout)(os.ReadInt()); 
         
    }

    public FlyBullet()
    {
    }

    public FlyBullet(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "speed":  speed = ele.ReadFloat(); break; 
             case "moveTrackType":  moveTrackType = ele.ReadEnum<cfg.skill.EBulletTrackType>(); break; 
             case "flyDirType":  flyDirType = ele.ReadEnum<cfg.skill.EBulletFlyDirType>(); break; 
             case "mutiBulletBornLayout":  mutiBulletBornLayout = ele.ReadEnum<cfg.skill.EBulletBornLayout>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "FlyBullet");
        ele.WriteStartElement("speed"); ele.WriteFloat(speed); ele.WriteEndElement();
         ele.WriteStartElement("moveTrackType"); ele.WriteEnum(moveTrackType); ele.WriteEndElement();
         ele.WriteStartElement("flyDirType"); ele.WriteEnum(flyDirType); ele.WriteEndElement();
         ele.WriteStartElement("mutiBulletBornLayout"); ele.WriteEnum(mutiBulletBornLayout); ele.WriteEndElement();
         
    }


}
}
}
