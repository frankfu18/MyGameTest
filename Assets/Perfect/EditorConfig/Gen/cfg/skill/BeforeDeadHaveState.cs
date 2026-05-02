using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BeforeDeadHaveState : BuffTriggerType
 {

    public cfg.skill.EBuffStateType buffState ;
     



    public const int TYPE_ID = 29762;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BeforeDeadHaveState(Perfect.Marshal.Octets os) : base(os)  {

        buffState = (cfg.skill.EBuffStateType)(os.ReadInt()); 
         
    }

    public BeforeDeadHaveState()
    {
    }

    public BeforeDeadHaveState(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffState":  buffState = ele.ReadEnum<cfg.skill.EBuffStateType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "BeforeDeadHaveState");
        ele.WriteStartElement("buffState"); ele.WriteEnum(buffState); ele.WriteEndElement();
         
    }


}
}
}
