using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class AOEPlusDamage : BuffEffectContent
 {

    public int bulletId ;
     public float damageSub ;
     



    public const int TYPE_ID = 16184;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AOEPlusDamage(Perfect.Marshal.Octets os) : base(os)  {

        bulletId = os.ReadInt(); 
         damageSub = os.ReadFloat(); 
         
    }

    public AOEPlusDamage()
    {
    }

    public AOEPlusDamage(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "bulletId":  bulletId = ele.ReadInt(); break; 
             case "damageSub":  damageSub = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "AOEPlusDamage");
        ele.WriteStartElement("bulletId"); ele.WriteInt(bulletId); ele.WriteEndElement();
         ele.WriteStartElement("damageSub"); ele.WriteFloat(damageSub); ele.WriteEndElement();
         
    }


}
}
}
