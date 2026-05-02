using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class ReleasePlusBullet : BuffEffectContent
 {

    public int skillId ;
     public float releaseInterval ;
     public float damageSub ;
     



    public const int TYPE_ID = 58996;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ReleasePlusBullet(Perfect.Marshal.Octets os) : base(os)  {

        skillId = os.ReadInt(); 
         releaseInterval = os.ReadFloat(); 
         damageSub = os.ReadFloat(); 
         
    }

    public ReleasePlusBullet()
    {
    }

    public ReleasePlusBullet(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "skillId":  skillId = ele.ReadInt(); break; 
             case "releaseInterval":  releaseInterval = ele.ReadFloat(); break; 
             case "damageSub":  damageSub = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ReleasePlusBullet");
        ele.WriteStartElement("skillId"); ele.WriteInt(skillId); ele.WriteEndElement();
         ele.WriteStartElement("releaseInterval"); ele.WriteFloat(releaseInterval); ele.WriteEndElement();
         ele.WriteStartElement("damageSub"); ele.WriteFloat(damageSub); ele.WriteEndElement();
         
    }


}
}
}
