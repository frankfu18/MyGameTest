using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BulletConfig :   cfg.EditorWriter 
 {

    public int id ;
     public string des  = "";
     public int resId ;
     public cfg.skill.EBulletBornType bornType ;
     public int bornEffId ;
     public int buffId ;
     public cfg.skill.BulletType bulletType ;
     public int destroyEffId ;
     public cfg.skill.BulletDestroyType bulletDestroyType ;
     public cfg.skill.BulletEffectType takeEffectType ;
     public int takeEffectRadius ;
     



    public const int TYPE_ID = 49182;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BulletConfig(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         des = os.ReadString(); 
         resId = os.ReadInt(); 
         bornType = (cfg.skill.EBulletBornType)(os.ReadInt()); 
         bornEffId = os.ReadInt(); 
         buffId = os.ReadInt(); 
         bulletType = cfg.Extensions.unmarshal_cfg_skill_BulletType(os); 
         destroyEffId = os.ReadInt(); 
         bulletDestroyType = cfg.Extensions.unmarshal_cfg_skill_BulletDestroyType(os); 
         takeEffectType = cfg.Extensions.unmarshal_cfg_skill_BulletEffectType(os); 
         takeEffectRadius = os.ReadInt(); 
         
    }

    public BulletConfig()
    {
    }

    public BulletConfig(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "des":  des = ele.ReadString2(); break; 
             case "resId":  resId = ele.ReadInt(); break; 
             case "bornType":  bornType = ele.ReadEnum<cfg.skill.EBulletBornType>(); break; 
             case "bornEffId":  bornEffId = ele.ReadInt(); break; 
             case "buffId":  buffId = ele.ReadInt(); break; 
             case "bulletType":  bulletType = cfg.Extensions.xml_unmarshal_cfg_skill_BulletType(ele); break; 
             case "destroyEffId":  destroyEffId = ele.ReadInt(); break; 
             case "bulletDestroyType":  bulletDestroyType = cfg.Extensions.xml_unmarshal_cfg_skill_BulletDestroyType(ele); break; 
             case "takeEffectType":  takeEffectType = cfg.Extensions.xml_unmarshal_cfg_skill_BulletEffectType(ele); break; 
             case "takeEffectRadius":  takeEffectRadius = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BulletConfig");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("des"); ele.WriteString2(des); ele.WriteEndElement();
         ele.WriteStartElement("resId"); ele.WriteInt(resId); ele.WriteEndElement();
         ele.WriteStartElement("bornType"); ele.WriteEnum(bornType); ele.WriteEndElement();
         ele.WriteStartElement("bornEffId"); ele.WriteInt(bornEffId); ele.WriteEndElement();
         ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         ele.WriteStartElement("bulletType"); cfg.Extensions.xml_marshal_cfg_skill_BulletType(bulletType,ele); ele.WriteEndElement();
         ele.WriteStartElement("destroyEffId"); ele.WriteInt(destroyEffId); ele.WriteEndElement();
         ele.WriteStartElement("bulletDestroyType"); cfg.Extensions.xml_marshal_cfg_skill_BulletDestroyType(bulletDestroyType,ele); ele.WriteEndElement();
         ele.WriteStartElement("takeEffectType"); cfg.Extensions.xml_marshal_cfg_skill_BulletEffectType(takeEffectType,ele); ele.WriteEndElement();
         ele.WriteStartElement("takeEffectRadius"); ele.WriteInt(takeEffectRadius); ele.WriteEndElement();
         
    }


}
}
}
