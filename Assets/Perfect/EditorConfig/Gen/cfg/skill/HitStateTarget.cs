using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitStateTarget : BuffTriggerType
 {

    public cfg.skill.EBuffStateType stateType ;
     



    public const int TYPE_ID = 30508;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitStateTarget(Perfect.Marshal.Octets os) : base(os)  {

        stateType = (cfg.skill.EBuffStateType)(os.ReadInt()); 
         
    }

    public HitStateTarget()
    {
    }

    public HitStateTarget(XmlElement e)
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
        ele.WriteAttributeString("type", "HitStateTarget");
        ele.WriteStartElement("stateType"); ele.WriteEnum(stateType); ele.WriteEndElement();
         
    }


}
}
}
