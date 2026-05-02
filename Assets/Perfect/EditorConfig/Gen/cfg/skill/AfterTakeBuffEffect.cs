using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class AfterTakeBuffEffect : BuffTriggerType
 {

    public int buffId ;
     



    public const int TYPE_ID = 15639;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AfterTakeBuffEffect(Perfect.Marshal.Octets os) : base(os)  {

        buffId = os.ReadInt(); 
         
    }

    public AfterTakeBuffEffect()
    {
    }

    public AfterTakeBuffEffect(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "buffId":  buffId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "AfterTakeBuffEffect");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         
    }


}
}
}
