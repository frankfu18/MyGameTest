using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class ReleaseNumCritical : BuffEffectContent
 {

    public int num ;
     



    public const int TYPE_ID = 4733;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public ReleaseNumCritical(Perfect.Marshal.Octets os) : base(os)  {

        num = os.ReadInt(); 
         
    }

    public ReleaseNumCritical()
    {
    }

    public ReleaseNumCritical(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "num":  num = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "ReleaseNumCritical");
        ele.WriteStartElement("num"); ele.WriteInt(num); ele.WriteEndElement();
         
    }


}
}
}
