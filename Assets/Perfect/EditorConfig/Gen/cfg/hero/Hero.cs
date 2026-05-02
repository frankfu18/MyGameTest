using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.hero
{
[System.Serializable]
public  class Hero :   cfg.EditorWriter 
 {

    public int id ;
     public string icon  = "";
     public cfg.item.EItemQuality quality ;
     public string name  = "";
     public cfg.hero.EHeroJob job ;
     public int assetId ;
     public int atkRange ;
     public int skillPower ;
     public System.Collections.Generic.List<int> skills  = new System.Collections.Generic.List<int>();
     public float volumeRadius ;
     public System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> baseAttrs  = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
     



    public const int TYPE_ID = 24677;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Hero(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         icon = os.ReadString(); 
         quality = (cfg.item.EItemQuality)(os.ReadInt()); 
         name = os.ReadString(); 
         job = (cfg.hero.EHeroJob)(os.ReadInt()); 
         assetId = os.ReadInt(); 
         atkRange = os.ReadInt(); 
         skillPower = os.ReadInt(); 
         skills = cfg.Extensions.unmarshal_list_int(os); 
         volumeRadius = os.ReadFloat(); 
         baseAttrs = cfg.Extensions.unmarshal_list_cfg_attribute_AttributeLongNumber(os); 
         
    }

    public Hero()
    {
    }

    public Hero(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "icon":  icon = ele.ReadString2(); break; 
             case "quality":  quality = ele.ReadEnum<cfg.item.EItemQuality>(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "job":  job = ele.ReadEnum<cfg.hero.EHeroJob>(); break; 
             case "assetId":  assetId = ele.ReadInt(); break; 
             case "atkRange":  atkRange = ele.ReadInt(); break; 
             case "skillPower":  skillPower = ele.ReadInt(); break; 
             case "skills":  skills = cfg.Extensions.xml_unmarshal_list_int(ele); break; 
             case "volumeRadius":  volumeRadius = ele.ReadFloat(); break; 
             case "baseAttrs":  baseAttrs = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Hero");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("icon"); ele.WriteString2(icon); ele.WriteEndElement();
         ele.WriteStartElement("quality"); ele.WriteEnum(quality); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("job"); ele.WriteEnum(job); ele.WriteEndElement();
         ele.WriteStartElement("assetId"); ele.WriteInt(assetId); ele.WriteEndElement();
         ele.WriteStartElement("atkRange"); ele.WriteInt(atkRange); ele.WriteEndElement();
         ele.WriteStartElement("skillPower"); ele.WriteInt(skillPower); ele.WriteEndElement();
         ele.WriteStartElement("skills"); cfg.Extensions.xml_marshal_list_int(skills,ele); ele.WriteEndElement();
         ele.WriteStartElement("volumeRadius"); ele.WriteFloat(volumeRadius); ele.WriteEndElement();
         ele.WriteStartElement("baseAttrs"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(baseAttrs,ele); ele.WriteEndElement();
         
    }


}
}
}
