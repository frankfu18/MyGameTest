using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.sysbuff
{
[System.Serializable]
public  class SysBuff :   cfg.EditorWriter 
 {

    public int id ;
     public string name  = "";
     public string icon  = "";
     public string desc  = "";
     public cfg.sysbuff.SysBuffInfo buffInfo ;
     



    public const int TYPE_ID = 10973;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SysBuff(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         name = os.ReadString(); 
         icon = os.ReadString(); 
         desc = os.ReadString(); 
         buffInfo = cfg.Extensions.unmarshal_cfg_sysbuff_SysBuffInfo(os); 
         
    }

    public SysBuff()
    {
    }

    public SysBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "icon":  icon = ele.ReadString2(); break; 
             case "desc":  desc = ele.ReadString2(); break; 
             case "buffInfo":  buffInfo = cfg.Extensions.xml_unmarshal_cfg_sysbuff_SysBuffInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SysBuff");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("icon"); ele.WriteString2(icon); ele.WriteEndElement();
         ele.WriteStartElement("desc"); ele.WriteString2(desc); ele.WriteEndElement();
         ele.WriteStartElement("buffInfo"); cfg.Extensions.xml_marshal_cfg_sysbuff_SysBuffInfo(buffInfo,ele); ele.WriteEndElement();
         
    }


}
}
}
