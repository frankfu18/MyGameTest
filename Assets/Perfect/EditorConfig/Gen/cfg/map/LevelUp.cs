using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class LevelUp :   cfg.EditorWriter 
 {

    public int level ;
     public int exp ;
     



    public const int TYPE_ID = 13269;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public LevelUp(Perfect.Marshal.Octets os) {

        level = os.ReadInt(); 
         exp = os.ReadInt(); 
         
    }

    public LevelUp()
    {
    }

    public LevelUp(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             case "exp":  exp = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "LevelUp");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         ele.WriteStartElement("exp"); ele.WriteInt(exp); ele.WriteEndElement();
         
    }


}
}
}
