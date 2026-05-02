using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SelectBuff :   cfg.EditorWriter 
 {

    public int id ;
     public string desc  = "";
     public cfg.item.EItemQuality quality ;
     public cfg.battle.SelectBuffType buffType ;
     public cfg.battle.EffectTarget target ;
     public cfg.battle.SelectCount selectCount ;
     public int buffId ;
     public int weight ;
     



    public const int TYPE_ID = 53587;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SelectBuff(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         desc = os.ReadString(); 
         quality = (cfg.item.EItemQuality)(os.ReadInt()); 
         buffType = cfg.Extensions.unmarshal_cfg_battle_SelectBuffType(os); 
         target = cfg.Extensions.unmarshal_cfg_battle_EffectTarget(os); 
         selectCount = cfg.Extensions.unmarshal_cfg_battle_SelectCount(os); 
         buffId = os.ReadInt(); 
         weight = os.ReadInt(); 
         
    }

    public SelectBuff()
    {
    }

    public SelectBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "desc":  desc = ele.ReadString2(); break; 
             case "quality":  quality = ele.ReadEnum<cfg.item.EItemQuality>(); break; 
             case "buffType":  buffType = cfg.Extensions.xml_unmarshal_cfg_battle_SelectBuffType(ele); break; 
             case "target":  target = cfg.Extensions.xml_unmarshal_cfg_battle_EffectTarget(ele); break; 
             case "selectCount":  selectCount = cfg.Extensions.xml_unmarshal_cfg_battle_SelectCount(ele); break; 
             case "buffId":  buffId = ele.ReadInt(); break; 
             case "weight":  weight = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SelectBuff");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("desc"); ele.WriteString2(desc); ele.WriteEndElement();
         ele.WriteStartElement("quality"); ele.WriteEnum(quality); ele.WriteEndElement();
         ele.WriteStartElement("buffType"); cfg.Extensions.xml_marshal_cfg_battle_SelectBuffType(buffType,ele); ele.WriteEndElement();
         ele.WriteStartElement("target"); cfg.Extensions.xml_marshal_cfg_battle_EffectTarget(target,ele); ele.WriteEndElement();
         ele.WriteStartElement("selectCount"); cfg.Extensions.xml_marshal_cfg_battle_SelectCount(selectCount,ele); ele.WriteEndElement();
         ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         ele.WriteStartElement("weight"); ele.WriteInt(weight); ele.WriteEndElement();
         
    }


}
}
}
