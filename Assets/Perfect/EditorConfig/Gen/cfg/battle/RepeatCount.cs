using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.battle
{
[System.Serializable]
public  class RepeatCount : SelectCount
 {

    public int count ;
     



    public const int TYPE_ID = 12359;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public RepeatCount(Perfect.Marshal.Octets os) : base(os)  {

        count = os.ReadInt(); 
         
    }

    public RepeatCount()
    {
    }

    public RepeatCount(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "count":  count = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "RepeatCount");
        ele.WriteStartElement("count"); ele.WriteInt(count); ele.WriteEndElement();
         
    }


}
}
}
