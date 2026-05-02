using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class BuffRemove : BuffDestroyType
 {

    public int buffId ;
     



    public const int TYPE_ID = 24144;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public BuffRemove(Perfect.Marshal.Octets os) : base(os)  {

        buffId = os.ReadInt(); 
         
    }

    public BuffRemove()
    {
    }

    public BuffRemove(XmlElement e)
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
        ele.WriteAttributeString("type", "BuffRemove");
        ele.WriteStartElement("buffId"); ele.WriteInt(buffId); ele.WriteEndElement();
         
    }


}
}
}
