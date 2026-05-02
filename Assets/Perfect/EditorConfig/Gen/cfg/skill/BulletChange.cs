using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BulletChange : BuffEffectContent
 {

    public int bulletId ;
     public cfg.skill.EBulletChangeType changeType ;
     public float value ;
     



    public const int TYPE_ID = 12103;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BulletChange(Perfect.Marshal.Octets os) : base(os)  {

        bulletId = os.ReadInt(); 
         changeType = (cfg.skill.EBulletChangeType)(os.ReadInt()); 
         value = os.ReadFloat(); 
         
    }

    public BulletChange()
    {
    }

    public BulletChange(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "bulletId":  bulletId = ele.ReadInt(); break; 
             case "changeType":  changeType = ele.ReadEnum<cfg.skill.EBulletChangeType>(); break; 
             case "value":  value = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BulletChange");
        ele.WriteStartElement("bulletId"); ele.WriteInt(bulletId); ele.WriteEndElement();
         ele.WriteStartElement("changeType"); ele.WriteEnum(changeType); ele.WriteEndElement();
         ele.WriteStartElement("value"); ele.WriteFloat(value); ele.WriteEndElement();
         
    }


}
}
}
