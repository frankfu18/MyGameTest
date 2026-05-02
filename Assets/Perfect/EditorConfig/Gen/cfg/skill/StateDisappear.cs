using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class StateDisappear : BuffDestroyType
 {

    public cfg.skill.EBuffStateType stateType ;
     



    public const int TYPE_ID = 12635;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public StateDisappear(Perfect.Marshal.Octets os) : base(os)  {

        stateType = (cfg.skill.EBuffStateType)(os.ReadInt()); 
         
    }

    public StateDisappear()
    {
    }

    public StateDisappear(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "stateType":  stateType = ele.ReadEnum<cfg.skill.EBuffStateType>(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "StateDisappear");
        ele.WriteStartElement("stateType"); ele.WriteEnum(stateType); ele.WriteEndElement();
         
    }


}
}
}
