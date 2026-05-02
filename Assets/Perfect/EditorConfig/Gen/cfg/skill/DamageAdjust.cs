using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class DamageAdjust : BuffEffectContent
 {

    public cfg.skill.EDamageAdjustType adjustType ;
     public float changeValue ;
     



    public const int TYPE_ID = 57409;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public DamageAdjust(Perfect.Marshal.Octets os) : base(os)  {

        adjustType = (cfg.skill.EDamageAdjustType)(os.ReadInt()); 
         changeValue = os.ReadFloat(); 
         
    }

    public DamageAdjust()
    {
    }

    public DamageAdjust(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "adjustType":  adjustType = ele.ReadEnum<cfg.skill.EDamageAdjustType>(); break; 
             case "changeValue":  changeValue = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "DamageAdjust");
        ele.WriteStartElement("adjustType"); ele.WriteEnum(adjustType); ele.WriteEndElement();
         ele.WriteStartElement("changeValue"); ele.WriteFloat(changeValue); ele.WriteEndElement();
         
    }


}
}
}
