using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.level
{
[System.Serializable]
public  class ChapterBox :   cfg.EditorWriter 
 {

    public int star ;
     public cfg.bonus.Bonus rewardBonus ;
     



    public const int TYPE_ID = 8649;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ChapterBox(Perfect.Marshal.Octets os) {

        star = os.ReadInt(); 
         rewardBonus = cfg.Extensions.unmarshal_cfg_bonus_Bonus(os); 
         
    }

    public ChapterBox()
    {
    }

    public ChapterBox(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "star":  star = ele.ReadInt(); break; 
             case "rewardBonus":  rewardBonus = cfg.Extensions.xml_unmarshal_cfg_bonus_Bonus(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ChapterBox");
        ele.WriteStartElement("star"); ele.WriteInt(star); ele.WriteEndElement();
         ele.WriteStartElement("rewardBonus"); cfg.Extensions.xml_marshal_cfg_bonus_Bonus(rewardBonus,ele); ele.WriteEndElement();
         
    }


}
}
}
