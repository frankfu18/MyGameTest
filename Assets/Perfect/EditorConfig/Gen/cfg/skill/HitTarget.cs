using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class HitTarget : BuffTriggerType
 {

    public int bulletId ;
     



    public const int TYPE_ID = 55546;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public HitTarget(Perfect.Marshal.Octets os) : base(os)  {

        bulletId = os.ReadInt(); 
         
    }

    public HitTarget()
    {
    }

    public HitTarget(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "bulletId":  bulletId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "HitTarget");
        ele.WriteStartElement("bulletId"); ele.WriteInt(bulletId); ele.WriteEndElement();
         
    }


}
}
}
