using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class SelectBuffType3 : SelectBuffType
 {

    public cfg.battle.SelectBuffType3Trigger triggerType ;
     



    public const int TYPE_ID = 62028;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public SelectBuffType3(Perfect.Marshal.Octets os) : base(os)  {

        triggerType = cfg.Extensions.unmarshal_cfg_battle_SelectBuffType3Trigger(os); 
         
    }

    public SelectBuffType3()
    {
    }

    public SelectBuffType3(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "triggerType":  triggerType = cfg.Extensions.xml_unmarshal_cfg_battle_SelectBuffType3Trigger(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "SelectBuffType3");
        ele.WriteStartElement("triggerType"); cfg.Extensions.xml_marshal_cfg_battle_SelectBuffType3Trigger(triggerType,ele); ele.WriteEndElement();
         
    }


}
}
}
