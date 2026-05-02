using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SpDamageTypeTowerTarget : EffectTarget
 {

    public cfg.attribute.EDamageType damageType ;
     



    public const int TYPE_ID = 53180;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SpDamageTypeTowerTarget(Perfect.Marshal.Octets os) : base(os)  {

        damageType = (cfg.attribute.EDamageType)(os.ReadInt()); 
         
    }

    public SpDamageTypeTowerTarget()
    {
    }

    public SpDamageTypeTowerTarget(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "damageType":  damageType = ele.ReadEnum<cfg.attribute.EDamageType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SpDamageTypeTowerTarget");
        ele.WriteStartElement("damageType"); ele.WriteEnum(damageType); ele.WriteEndElement();
         
    }


}
}
}
