using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.skill
{
[System.Serializable]
public  class AfterTime : BulletDestroyType
 {

    public float time ;
     



    public const int TYPE_ID = 51293;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public AfterTime(Perfect.Marshal.Octets os) : base(os)  {

        time = os.ReadFloat(); 
         
    }

    public AfterTime()
    {
    }

    public AfterTime(XmlElement e)
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
        ele.WriteAttributeString("type", "AfterTime");
        ele.WriteStartElement("time"); ele.WriteFloat(time); ele.WriteEndElement();
         
    }


}
}
}
