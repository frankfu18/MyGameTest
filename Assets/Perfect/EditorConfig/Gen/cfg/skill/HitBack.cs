using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitBack : BuffEffectContent
 {

    public float distance ;
     



    public const int TYPE_ID = 47801;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitBack(Perfect.Marshal.Octets os) : base(os)  {

        distance = os.ReadFloat(); 
         
    }

    public HitBack()
    {
    }

    public HitBack(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "distance":  distance = ele.ReadFloat(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "HitBack");
        ele.WriteStartElement("distance"); ele.WriteFloat(distance); ele.WriteEndElement();
         
    }


}
}
}
