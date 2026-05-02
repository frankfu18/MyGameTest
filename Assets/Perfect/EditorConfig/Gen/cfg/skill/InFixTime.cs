using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class InFixTime : BuffDestroyType
 {

    public float time ;
     



    public const int TYPE_ID = 30151;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public InFixTime(Perfect.Marshal.Octets os) : base(os)  {

        time = os.ReadFloat(); 
         
    }

    public InFixTime()
    {
    }

    public InFixTime(XmlElement e)
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
        ele.WriteAttributeString("type", "InFixTime");
        ele.WriteStartElement("time"); ele.WriteFloat(time); ele.WriteEndElement();
         
    }


}
}
}
