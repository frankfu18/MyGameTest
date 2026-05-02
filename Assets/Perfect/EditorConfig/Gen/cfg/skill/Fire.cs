using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class Fire : BuffEffectContent
 {

    public float damage ;
     public float explosionRadius ;
     public float explosionDamage ;
     



    public const int TYPE_ID = 48121;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Fire(Perfect.Marshal.Octets os) : base(os)  {

        damage = os.ReadFloat(); 
         explosionRadius = os.ReadFloat(); 
         explosionDamage = os.ReadFloat(); 
         
    }

    public Fire()
    {
    }

    public Fire(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "damage":  damage = ele.ReadFloat(); break; 
             case "explosionRadius":  explosionRadius = ele.ReadFloat(); break; 
             case "explosionDamage":  explosionDamage = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Fire");
        ele.WriteStartElement("damage"); ele.WriteFloat(damage); ele.WriteEndElement();
         ele.WriteStartElement("explosionRadius"); ele.WriteFloat(explosionRadius); ele.WriteEndElement();
         ele.WriteStartElement("explosionDamage"); ele.WriteFloat(explosionDamage); ele.WriteEndElement();
         
    }


}
}
}
