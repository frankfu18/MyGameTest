using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class IntervalCheck : BulletEffectType
 {

    public float intervalTime ;
     



    public const int TYPE_ID = 25225;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public IntervalCheck(Perfect.Marshal.Octets os) : base(os)  {

        intervalTime = os.ReadFloat(); 
         
    }

    public IntervalCheck()
    {
    }

    public IntervalCheck(XmlElement e)
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
        ele.WriteAttributeString("type", "IntervalCheck");
        ele.WriteStartElement("intervalTime"); ele.WriteFloat(intervalTime); ele.WriteEndElement();
         
    }


}
}
}
