using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.user
{
[System.Serializable]
public  class UserTitle :   cfg.EditorWriter 
 {

    public int level ;
     public string name  = "";
     public int sysbuffId ;
     



    public const int TYPE_ID = 22518;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public UserTitle(Perfect.Marshal.Octets os) {

        level = os.ReadInt(); 
         name = os.ReadString(); 
         sysbuffId = os.ReadInt(); 
         
    }

    public UserTitle()
    {
    }

    public UserTitle(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             case "name":  name = ele.ReadString2(); break; 
             case "sysbuffId":  sysbuffId = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "UserTitle");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         ele.WriteStartElement("name"); ele.WriteString2(name); ele.WriteEndElement();
         ele.WriteStartElement("sysbuffId"); ele.WriteInt(sysbuffId); ele.WriteEndElement();
         
    }


}
}
}
