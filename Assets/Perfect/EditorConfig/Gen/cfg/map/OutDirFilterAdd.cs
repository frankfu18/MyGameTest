using Perfect.Marshal;
using System.Xml;

namespace editor
{
namespace cfg.map
{
[System.Serializable]
public  class OutDirFilterAdd :   cfg.EditorWriter 
 {

    public cfg.map.EPathDir dir ;
     public int addPercent ;
     



    public const int TYPE_ID = 44467;

    public override int GetTypeId() {
        return TYPE_ID;
    }

    public OutDirFilterAdd(Perfect.Marshal.Octets os) {

        dir = (cfg.map.EPathDir)(os.ReadInt()); 
         addPercent = os.ReadInt(); 
         
    }

    public OutDirFilterAdd()
    {
    }

    public OutDirFilterAdd(XmlElement e)
    {
        foreach (XmlElement ele in e.GetChildren())
        {
            switch (ele.Name)
            {
            case "dir":  dir = ele.ReadEnum<cfg.map.EPathDir>(); break; 
             case "addPercent":  addPercent = ele.ReadInt(); break; 
             
            default: break;
            }
        }
    }

    public override void MarshalXml(XmlWriter ele)
    {
        ele.WriteAttributeString("type", "OutDirFilterAdd");
        ele.WriteStartElement("dir"); ele.WriteEnum(dir); ele.WriteEndElement();
         ele.WriteStartElement("addPercent"); ele.WriteInt(addPercent); ele.WriteEndElement();
         
    }


}
}
}
