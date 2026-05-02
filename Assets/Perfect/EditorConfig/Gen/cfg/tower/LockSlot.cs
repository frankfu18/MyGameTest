using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.tower
{
[System.Serializable]
public  class LockSlot : SlotInfo
 {

    public cfg.condition.Condition condition ;
     



    public const int TYPE_ID = 6908;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public LockSlot(Perfect.Marshal.Octets os) : base(os)  {

        condition = cfg.Extensions.unmarshal_cfg_condition_Condition(os); 
         
    }

    public LockSlot()
    {
    }

    public LockSlot(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "condition":  condition = cfg.Extensions.xml_unmarshal_cfg_condition_Condition(ele); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "LockSlot");
        ele.WriteStartElement("condition"); cfg.Extensions.xml_marshal_cfg_condition_Condition(condition,ele); ele.WriteEndElement();
         
    }


}
}
}
