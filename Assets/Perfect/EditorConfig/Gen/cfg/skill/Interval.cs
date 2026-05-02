using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class Interval : BuffEffectType
 {

    public float time ;
     



    public const int TYPE_ID = 46743;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Interval(Perfect.Marshal.Octets os) : base(os)  {

        time = os.ReadFloat(); 
         
    }

    public Interval()
    {
    }

    public Interval(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "time":  time = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "Interval");
        ele.WriteStartElement("time"); ele.WriteFloat(time); ele.WriteEndElement();
         
    }


}
}
}
