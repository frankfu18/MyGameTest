using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class StartBuff :   cfg.EditorWriter 
 {

    public int id ;
     public cfg.battle.BattleStartBuffContent content ;
     



    public const int TYPE_ID = 18719;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public StartBuff(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         content = cfg.Extensions.unmarshal_cfg_battle_BattleStartBuffContent(os); 
         
    }

    public StartBuff()
    {
    }

    public StartBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "content":  content = cfg.Extensions.xml_unmarshal_cfg_battle_BattleStartBuffContent(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "StartBuff");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("content"); cfg.Extensions.xml_marshal_cfg_battle_BattleStartBuffContent(content,ele); ele.WriteEndElement();
         
    }


}
}
}
