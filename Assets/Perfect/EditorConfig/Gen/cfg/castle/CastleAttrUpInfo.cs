using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.castle
{
[System.Serializable]
public  class CastleAttrUpInfo :   cfg.EditorWriter 
 {

    public cfg.attribute.EAttributeType attrType ;
     public int maxLv ;
     public System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo> attrUpgradeLvDic  = new System.Collections.Generic.Dictionary<int,cfg.castle.AttrUpgradeInfo>();
     



    public const int TYPE_ID = 37746;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleAttrUpInfo(Perfect.Marshal.Octets os) {

        attrType = (cfg.attribute.EAttributeType)(os.ReadInt()); 
         maxLv = os.ReadInt(); 
         attrUpgradeLvDic = cfg.Extensions.unmarshal_map_int_cfg_castle_AttrUpgradeInfo(os); 
         
    }

    public CastleAttrUpInfo()
    {
    }

    public CastleAttrUpInfo(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "attrType":  attrType = ele.ReadEnum<cfg.attribute.EAttributeType>(); break; 
             case "maxLv":  maxLv = ele.ReadInt(); break; 
             case "attrUpgradeLvDic":  attrUpgradeLvDic = cfg.Extensions.xml_unmarshal_map_int_cfg_castle_AttrUpgradeInfo(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleAttrUpInfo");
        ele.WriteStartElement("attrType"); ele.WriteEnum(attrType); ele.WriteEndElement();
         ele.WriteStartElement("maxLv"); ele.WriteInt(maxLv); ele.WriteEndElement();
         ele.WriteStartElement("attrUpgradeLvDic"); cfg.Extensions.xml_marshal_map_int_cfg_castle_AttrUpgradeInfo(attrUpgradeLvDic,ele); ele.WriteEndElement();
         
    }


}
}
}
