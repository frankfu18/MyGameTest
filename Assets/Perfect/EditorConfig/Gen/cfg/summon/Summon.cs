using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.summon
{
[System.Serializable]
public  class Summon :   cfg.EditorWriter 
 {

    public cfg.summon.ESummonType summonType ;
     public string name  = "";
     public string desc  = "";
     public int addExp ;
     public int adGetCount ;
     public cfg.common.Cost cost ;
     



    public const int TYPE_ID = 42002;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Summon(Perfect.Marshal.Octets os) {

        summonType = (cfg.summon.ESummonType)(os.ReadInt()); 
         name = os.ReadString(); 
         desc = os.ReadString(); 
         addExp = os.ReadInt(); 
         adGetCount = os.ReadInt(); 
         cost = cfg.Extensions.unmarshal_cfg_common_Cost(os); 
         
    }

    public Summon()
    {
    }

    public Summon(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "summonType":  summonType = ele.ReadEnum<cfg.summon.ESummonType>(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "desc":  desc = ele.ReadString2(); break; 
             case "addExp":  addExp = ele.ReadInt(); break; 
             case "adGetCount":  adGetCount = ele.ReadInt(); break; 
             case "cost":  cost = cfg.Extensions.xml_unmarshal_cfg_common_Cost(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Summon");
        ele.WriteStartElement("summonType"); ele.WriteEnum(summonType); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("desc"); ele.WriteString2(desc); ele.WriteEndElement();
         ele.WriteStartElement("addExp"); ele.WriteInt(addExp); ele.WriteEndElement();
         ele.WriteStartElement("adGetCount"); ele.WriteInt(adGetCount); ele.WriteEndElement();
         ele.WriteStartElement("cost"); cfg.Extensions.xml_marshal_cfg_common_Cost(cost,ele); ele.WriteEndElement();
         
    }


}
}
}
