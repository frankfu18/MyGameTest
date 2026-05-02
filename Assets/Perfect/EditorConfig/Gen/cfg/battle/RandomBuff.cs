using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RandomBuff :   cfg.EditorWriter 
 {

    public int id ;
     public System.Collections.Generic.List<cfg.battle.RandomBuffLib> randomList  = new System.Collections.Generic.List<cfg.battle.RandomBuffLib>();
     



    public const int TYPE_ID = 9216;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RandomBuff(Perfect.Marshal.Octets os) {

        id = os.ReadInt(); 
         randomList = cfg.Extensions.unmarshal_list_cfg_battle_RandomBuffLib(os); 
         
    }

    public RandomBuff()
    {
    }

    public RandomBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "id":  id = ele.ReadInt(); break; 
             case "randomList":  randomList = cfg.Extensions.xml_unmarshal_list_cfg_battle_RandomBuffLib(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RandomBuff");
        ele.WriteStartElement("id"); ele.WriteInt(id); ele.WriteEndElement();
         ele.WriteStartElement("randomList"); cfg.Extensions.xml_marshal_list_cfg_battle_RandomBuffLib(randomList,ele); ele.WriteEndElement();
         
    }


}
}
}
