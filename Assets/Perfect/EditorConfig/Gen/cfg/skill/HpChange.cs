using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HpChange : BuffEffectContent
 {

    public bool isAdd ;
     public bool isPercent ;
     public float changeValue ;
     public cfg.skill.EHpChangeType hpChangeType ;
     



    public const int TYPE_ID = 46536;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HpChange(Perfect.Marshal.Octets os) : base(os)  {

        isAdd = os.ReadBool(); 
         isPercent = os.ReadBool(); 
         changeValue = os.ReadFloat(); 
         hpChangeType = (cfg.skill.EHpChangeType)(os.ReadInt()); 
         
    }

    public HpChange()
    {
    }

    public HpChange(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "isAdd":  isAdd = ele.ReadBool(); break; 
             case "isPercent":  isPercent = ele.ReadBool(); break; 
             case "changeValue":  changeValue = ele.ReadFloat(); break; 
             case "hpChangeType":  hpChangeType = ele.ReadEnum<cfg.skill.EHpChangeType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "HpChange");
        ele.WriteStartElement("isAdd"); ele.WriteBool(isAdd); ele.WriteEndElement();
         ele.WriteStartElement("isPercent"); ele.WriteBool(isPercent); ele.WriteEndElement();
         ele.WriteStartElement("changeValue"); ele.WriteFloat(changeValue); ele.WriteEndElement();
         ele.WriteStartElement("hpChangeType"); ele.WriteEnum(hpChangeType); ele.WriteEndElement();
         
    }


}
}
}
