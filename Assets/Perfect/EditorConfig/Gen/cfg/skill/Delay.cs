using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class Delay : BuffEffectType
 {

    public float time ;
     



    public const int TYPE_ID = 9748;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public Delay(Perfect.Marshal.Octets os) : base(os)  {

        time = os.ReadFloat(); 
         
    }

    public Delay()
    {
    }

    public Delay(XmlElement e)
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
        ele.WriteAttributeString("type", "Delay");
        ele.WriteStartElement("time"); ele.WriteFloat(time); ele.WriteEndElement();
         
    }


}
}
}
