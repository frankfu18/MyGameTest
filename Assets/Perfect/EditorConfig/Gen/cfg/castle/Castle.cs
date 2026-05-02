using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class Castle :   cfg.EditorWriter 
 {

    public float radius ;
     public int maxLv ;
     public int resId ;
     public int normalSkillId ;
     public int atkRange ;
     public System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> baseAttrs  = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
     public System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo> attrUpInfoList  = new System.Collections.Generic.List<cfg.castle.CastleAttrUpInfo>();
     



    public const int TYPE_ID = 47839;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Castle(Perfect.Marshal.Octets os) {

        radius = os.ReadFloat(); 
         maxLv = os.ReadInt(); 
         resId = os.ReadInt(); 
         normalSkillId = os.ReadInt(); 
         atkRange = os.ReadInt(); 
         baseAttrs = cfg.Extensions.unmarshal_list_cfg_attribute_AttributeLongNumber(os); 
         attrUpInfoList = cfg.Extensions.unmarshal_list_cfg_castle_CastleAttrUpInfo(os); 
         
    }

    public Castle()
    {
    }

    public Castle(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "radius":  radius = ele.ReadFloat(); break; 
             case "maxLv":  maxLv = ele.ReadInt(); break; 
             case "resId":  resId = ele.ReadInt(); break; 
             case "normalSkillId":  normalSkillId = ele.ReadInt(); break; 
             case "atkRange":  atkRange = ele.ReadInt(); break; 
             case "baseAttrs":  baseAttrs = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             case "attrUpInfoList":  attrUpInfoList = cfg.Extensions.xml_unmarshal_list_cfg_castle_CastleAttrUpInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Castle");
        ele.WriteStartElement("radius"); ele.WriteFloat(radius); ele.WriteEndElement();
         ele.WriteStartElement("maxLv"); ele.WriteInt(maxLv); ele.WriteEndElement();
         ele.WriteStartElement("resId"); ele.WriteInt(resId); ele.WriteEndElement();
         ele.WriteStartElement("normalSkillId"); ele.WriteInt(normalSkillId); ele.WriteEndElement();
         ele.WriteStartElement("atkRange"); ele.WriteInt(atkRange); ele.WriteEndElement();
         ele.WriteStartElement("baseAttrs"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(baseAttrs,ele); ele.WriteEndElement();
         ele.WriteStartElement("attrUpInfoList"); cfg.Extensions.xml_marshal_list_cfg_castle_CastleAttrUpInfo(attrUpInfoList,ele); ele.WriteEndElement();
         
    }


}
}
}
