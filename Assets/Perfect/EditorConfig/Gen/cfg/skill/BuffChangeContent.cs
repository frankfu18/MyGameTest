using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BuffChangeContent :   cfg.EditorWriter 
 {

    public cfg.skill.EBuffChangeType changeType ;
     public float value ;
     



    public const int TYPE_ID = 63517;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BuffChangeContent(Perfect.Marshal.Octets os) {

        changeType = (cfg.skill.EBuffChangeType)(os.ReadInt()); 
         value = os.ReadFloat(); 
         
    }

    public BuffChangeContent()
    {
    }

    public BuffChangeContent(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "changeType":  changeType = ele.ReadEnum<cfg.skill.EBuffChangeType>(); break; 
             case "value":  value = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BuffChangeContent");
        ele.WriteStartElement("changeType"); ele.WriteEnum(changeType); ele.WriteEndElement();
         ele.WriteStartElement("value"); ele.WriteFloat(value); ele.WriteEndElement();
         
    }


}
}
}
