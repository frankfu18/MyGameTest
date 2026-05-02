using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.condition
{
[System.Serializable]
public  class CastleLevel : Condition
 {

    public int level ;
     



    public const int TYPE_ID = 1197;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public CastleLevel(Perfect.Marshal.Octets os) : base(os)  {

        level = os.ReadInt(); 
         
    }

    public CastleLevel()
    {
    }

    public CastleLevel(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "level":  level = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "CastleLevel");
        ele.WriteStartElement("level"); ele.WriteInt(level); ele.WriteEndElement();
         
    }


}
}
}
