using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BuffChange : BuffEffectContent
 {

    public int buffId ;
     public System.Collections.Generic.List<cfg.skill.BuffChangeContent> content  = new System.Collections.Generic.List<cfg.skill.BuffChangeContent>();
     



    public const int TYPE_ID = 27921;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BuffChange(Perfect.Marshal.Octets os) : base(os)  {

        buffId = os.ReadInt(); 
         content = cfg.Extensions.unmarshal_list_cfg_skill_BuffChangeContent(os); 
         
    }

    public BuffChange()
    {
    }

    public BuffChange(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffId":  buffId = ele.ReadInt(); break; 
             case "content":  content = cfg.Extensions.xml_unmarshal_list_cfg_skill_BuffChangeContent(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BuffChange");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         ele.WriteStartElement("content"); cfg.Extensions.xml_marshal_list_cfg_skill_BuffChangeContent(content,ele); ele.WriteEndElement();
         
    }


}
}
}
