using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class GlobalTarget : EffectTarget
 {

    public cfg.battle.EGlobalBuffType globalBuffType ;
     public float value ;
     



    public const int TYPE_ID = 55366;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public GlobalTarget(Perfect.Marshal.Octets os) : base(os)  {

        globalBuffType = (cfg.battle.EGlobalBuffType)(os.ReadInt()); 
         value = os.ReadFloat(); 
         
    }

    public GlobalTarget()
    {
    }

    public GlobalTarget(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "globalBuffType":  globalBuffType = ele.ReadEnum<cfg.battle.EGlobalBuffType>(); break; 
             case "value":  value = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "GlobalTarget");
        ele.WriteStartElement("globalBuffType"); ele.WriteEnum(globalBuffType); ele.WriteEndElement();
         ele.WriteStartElement("value"); ele.WriteFloat(value); ele.WriteEndElement();
         
    }


}
}
}
