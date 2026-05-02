using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitInterval : BulletEffectType
 {

    public float intervalTime ;
     



    public const int TYPE_ID = 54645;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitInterval(Perfect.Marshal.Octets os) : base(os)  {

        intervalTime = os.ReadFloat(); 
         
    }

    public HitInterval()
    {
    }

    public HitInterval(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "intervalTime":  intervalTime = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "HitInterval");
        ele.WriteStartElement("intervalTime"); ele.WriteFloat(intervalTime); ele.WriteEndElement();
         
    }


}
}
}
