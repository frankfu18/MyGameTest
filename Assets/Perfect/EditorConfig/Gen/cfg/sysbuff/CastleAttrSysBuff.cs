using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.sysbuff
{
[System.Serializable]
public  class CastleAttrSysBuff : SysBuffInfo
 {

    public System.Collections.Generic.List<cfg.attribute.AttributeLongNumber> attrDic  = new System.Collections.Generic.List<cfg.attribute.AttributeLongNumber>();
     



    public const int TYPE_ID = 9500;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleAttrSysBuff(Perfect.Marshal.Octets os) : base(os)  {

        attrDic = cfg.Extensions.unmarshal_list_cfg_attribute_AttributeLongNumber(os); 
         
    }

    public CastleAttrSysBuff()
    {
    }

    public CastleAttrSysBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "attrDic":  attrDic = cfg.Extensions.xml_unmarshal_list_cfg_attribute_AttributeLongNumber(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleAttrSysBuff");
        ele.WriteStartElement("attrDic"); cfg.Extensions.xml_marshal_list_cfg_attribute_AttributeLongNumber(attrDic,ele); ele.WriteEndElement();
         
    }


}
}
}
