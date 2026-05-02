using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitDelay : BulletEffectType
 {

    public float delayTime ;
     



    public const int TYPE_ID = 16968;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitDelay(Perfect.Marshal.Octets os) : base(os)  {

        delayTime = os.ReadFloat(); 
         
    }

    public HitDelay()
    {
    }

    public HitDelay(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "delayTime":  delayTime = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "HitDelay");
        ele.WriteStartElement("delayTime"); ele.WriteFloat(delayTime); ele.WriteEndElement();
         
    }


}
}
}
