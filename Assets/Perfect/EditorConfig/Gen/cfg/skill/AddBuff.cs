using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class AddBuff : BuffEffectContent
 {

    public int buffId ;
     public float radius ;
     



    public const int TYPE_ID = 53274;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AddBuff(Perfect.Marshal.Octets os) : base(os)  {

        buffId = os.ReadInt(); 
         radius = os.ReadFloat(); 
         
    }

    public AddBuff()
    {
    }

    public AddBuff(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffId":  buffId = ele.ReadInt(); break; 
             case "radius":  radius = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "AddBuff");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         ele.WriteStartElement("radius"); ele.WriteFloat(radius); ele.WriteEndElement();
         
    }


}
}
}
